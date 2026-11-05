Imports System.Diagnostics
Imports System.Text.RegularExpressions
Public Class Main

    Dim _BackPath As String = ".\DCS_CONTROL_EXE_BUILD\back-end-build\app.exe"
    Dim _FrontPath As String = ".\DCS_CONTROL_EXE_BUILD\front-end-build\dcs-panel-app.exe"

    Dim isBackRun As Boolean = False
    Dim isFrontRun As Boolean = False

    Dim strBackConsoleText As String = ""
    Dim strFrontConsoleText As String = ""

    Private _BackProcess As Process = Nothing
    Private _FrontProcess As Process = Nothing

    Dim FrontUrls As New List(Of String)()

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim processes() As Process = Process.GetProcessesByName("dcs-panel-app")

            For Each p As Process In processes
                p.Kill()
                p.WaitForExit() ' Optional: Waits for the process to fully terminate
                p.Close()       ' Frees resources associated with the component
            Next

        Catch ex As Exception
            Console.WriteLine("Error killing process: " & ex.Message)
        End Try

        isBackRun = False
        btnBackStart.Text = "Start"
        _BackProcess = Nothing
        txtBackConsoleStatus.Text = ""
        strBackConsoleText = ""
        lblBackStatus.Text = ""

        isFrontRun = False
        btnFrontStart.Text = "Start"
        _FrontProcess = Nothing
        txtFrontConsoleStatus.Text = ""
        strFrontConsoleText = ""
        lblFrontStatus.Text = ""
    End Sub

    Private Sub btnBackStart_Click(sender As Object, e As EventArgs) Handles btnBackStart.Click
        If Not isBackRun Then
            ' --- สั่งรัน Service ---
            isBackRun = True
            btnBackStart.Text = "Stop"

            ' เรียกใช้งานฟังก์ชัน Background
            _BackProcess = RunExeInBackground(_BackPath, Sub(logBackText)
                                                             ' ใช้ Invoke เพื่ออัปเดต UI จาก Thread อื่นได้อย่างปลอดภัย
                                                             Me.Invoke(Sub()
                                                                           strBackConsoleText &= Environment.NewLine & logBackText
                                                                           Console.WriteLine(logBackText)
                                                                           txtBackConsoleStatus.Text = strBackConsoleText
                                                                           ' ถ้ามี TextBox ไว้แสดงผล ให้เอาไปใส่ต่อตรงนี้ เช่น txtConsole.AppendText(...)
                                                                           isBackRun = True
                                                                           lblBackStatus.Text = "RUNNING"
                                                                       End Sub)
                                                         End Sub)
        Else
            ' --- สถานะ: สั่ง STOP (Kill Process) ---
            KillProcess(_BackProcess)
            isBackRun = False
            btnBackStart.Text = "Start"
            _BackProcess = Nothing
            txtBackConsoleStatus.Text = ""
            strBackConsoleText = ""
            lblBackStatus.Text = ""
        End If

    End Sub
    Private Sub btnFrontStart_Click(sender As Object, e As EventArgs) Handles btnFrontStart.Click
        If Not isFrontRun Then
            ' --- สั่งรัน Service ---
            isFrontRun = True
            btnFrontStart.Text = "Stop"

            ' เรียกใช้งานฟังก์ชัน Background
            _FrontProcess = RunExeInBackground(_FrontPath, Sub(logFrontText)
                                                               ' ใช้ Invoke เพื่ออัปเดต UI จาก Thread อื่นได้อย่างปลอดภัย
                                                               Me.Invoke(Sub()
                                                                             strFrontConsoleText &= Environment.NewLine & logFrontText
                                                                             Console.WriteLine(logFrontText)
                                                                             txtFrontConsoleStatus.Text = strFrontConsoleText
                                                                             ExtractAndStoreUrls(logFrontText)
                                                                             ' ถ้ามี TextBox ไว้แสดงผล ให้เอาไปใส่ต่อตรงนี้ เช่น txtConsole.AppendText(...)
                                                                             isFrontRun = True
                                                                             lblFrontStatus.Text = "RUNNING"
                                                                         End Sub)
                                                           End Sub)
        Else
            ' --- สถานะ: สั่ง STOP (Kill Process) ---
            KillProcess(_FrontProcess)
            isFrontRun = False
            btnFrontStart.Text = "Start"
            _FrontProcess = Nothing
            txtFrontConsoleStatus.Text = ""
            strFrontConsoleText = ""
            lblFrontStatus.Text = ""
        End If

    End Sub

    ' ==========================================
    ' ฟังก์ชันสำหรับรัน Process แบบ Background (Long-running)
    ' ==========================================
    Private Function RunExeInBackground(filePath As String, outputCallback As Action(Of String)) As Process
        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = filePath
        startInfo.UseShellExecute = False
        startInfo.RedirectStandardOutput = True
        startInfo.RedirectStandardError = True
        startInfo.CreateNoWindow = True
        startInfo.WindowStyle = ProcessWindowStyle.Hidden

        startInfo.StandardOutputEncoding = System.Text.Encoding.UTF8
        startInfo.StandardErrorEncoding = System.Text.Encoding.UTF8

        Dim proc As New Process()
        proc.StartInfo = startInfo

        ' ดึงข้อมูล Output แบบ Real-time
        AddHandler proc.OutputDataReceived, Sub(sender, e)
                                                If Not String.IsNullOrEmpty(e.Data) Then
                                                    outputCallback(e.Data)
                                                End If
                                            End Sub

        ' ดึงข้อมูล Error Log แบบ Real-time
        AddHandler proc.ErrorDataReceived, Sub(sender, e)
                                               If Not String.IsNullOrEmpty(e.Data) Then
                                                   outputCallback(e.Data)
                                               End If
                                           End Sub

        Try
            proc.Start()
            proc.BeginOutputReadLine()
            proc.BeginErrorReadLine()

            ' คืนค่า Object Process กลับไปเก็บไว้ใช้งานข้างนอก
            Return proc
        Catch ex As Exception
            outputCallback("Exception Error : " & ex.Message)
            Return Nothing
        End Try
    End Function

    ' ==========================================
    ' ฟังก์ชันสำหรับสั่งปิด (Kill) โปรแกรมลูกอย่างปลอดภัย
    ' ==========================================
    Private Sub KillProcess(targetProc As Process)
        If targetProc IsNot Nothing Then
            Try
                If Not targetProc.HasExited Then
                    targetProc.Kill() ' สั่งปิดกระบวนการทำงานทันที

                    ' เอา targetProc.WaitForExit() ออก เพื่อไม่ให้ UI Thread ถูกบล็อกและค้าง
                End If
            Catch ex As Exception
                Console.WriteLine("Kill Error: " & ex.Message)
            End Try
        End If
    End Sub

    ' ==========================================
    ' ฟังก์ชันสำหรับดึง URL จากข้อความ Log ด้วย Regex
    ' ==========================================
    Private Sub ExtractAndStoreUrls(logText As String)
        ' รูปแบบ Regex สำหรับค้นหาลิงก์ http:// หรือ https://
        Dim pattern As String = "https?://[^\s]+"
        Dim matches As MatchCollection = Regex.Matches(logText, pattern)

        For Each match As Match In matches
            Dim foundUrl As String = match.Value

            ' ป้องกันการเก็บลิงก์ซ้ำกัน
            If Not FrontUrls.Contains(foundUrl) Then
                FrontUrls.Add(foundUrl)

                ' ทดสอบพิมพ์ดูใน Console หรือเอาไปใส่ ComboBox / ListBox
                Console.WriteLine("Found link: " & foundUrl)
            End If
        Next
    End Sub

    ' ==========================================
    ' ข้อแนะนำเพิ่มเติม: ควรดักตอนปิดฟอร์มหลัก (Form Close) เพื่อเคลียร์ Service ทิ้งด้วย
    ' ==========================================
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Console.WriteLine("Form Closing")
        Console.WriteLine(_BackProcess)
        Console.WriteLine(_FrontProcess)
        KillProcess(_BackProcess)
        KillProcess(_FrontProcess)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Console.WriteLine("Form Closing")
        Console.WriteLine(_BackProcess)
        Console.WriteLine(_FrontProcess)
        KillProcess(_BackProcess)
        KillProcess(_FrontProcess)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
End Class
