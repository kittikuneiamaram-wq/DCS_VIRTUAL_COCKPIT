<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnBackStart = New System.Windows.Forms.Button()
        Me.btnFrontStart = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ddMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBackStatus = New System.Windows.Forms.Label()
        Me.lblFrontStatus = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBackConsoleStatus = New System.Windows.Forms.TextBox()
        Me.txtFrontConsoleStatus = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBackStart
        '
        Me.btnBackStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackStart.Location = New System.Drawing.Point(119, 75)
        Me.btnBackStart.Name = "btnBackStart"
        Me.btnBackStart.Size = New System.Drawing.Size(108, 42)
        Me.btnBackStart.TabIndex = 0
        Me.btnBackStart.Text = "Start"
        Me.btnBackStart.UseVisualStyleBackColor = True
        '
        'btnFrontStart
        '
        Me.btnFrontStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrontStart.Location = New System.Drawing.Point(513, 75)
        Me.btnFrontStart.Name = "btnFrontStart"
        Me.btnFrontStart.Size = New System.Drawing.Size(108, 42)
        Me.btnFrontStart.TabIndex = 1
        Me.btnFrontStart.Text = "Start"
        Me.btnFrontStart.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddMenu})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(841, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ddMenu
        '
        Me.ddMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ddMenu.Image = CType(resources.GetObject("ddMenu.Image"), System.Drawing.Image)
        Me.ddMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddMenu.Name = "ddMenu"
        Me.ddMenu.Size = New System.Drawing.Size(51, 22)
        Me.ddMenu.Text = "Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DCS API"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "COCKPIT"
        '
        'lblBackStatus
        '
        Me.lblBackStatus.AutoSize = True
        Me.lblBackStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackStatus.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblBackStatus.Location = New System.Drawing.Point(291, 85)
        Me.lblBackStatus.Name = "lblBackStatus"
        Me.lblBackStatus.Size = New System.Drawing.Size(98, 20)
        Me.lblBackStatus.TabIndex = 6
        Me.lblBackStatus.Text = "<STATUS>"
        '
        'lblFrontStatus
        '
        Me.lblFrontStatus.AutoSize = True
        Me.lblFrontStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrontStatus.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblFrontStatus.Location = New System.Drawing.Point(685, 85)
        Me.lblFrontStatus.Name = "lblFrontStatus"
        Me.lblFrontStatus.Size = New System.Drawing.Size(98, 20)
        Me.lblFrontStatus.TabIndex = 7
        Me.lblFrontStatus.Text = "<STATUS>"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(469, 435)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 28)
        Me.ComboBox1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "VIRTUAL COCKPIT ADDRESS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(689, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "OPEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBackConsoleStatus
        '
        Me.txtBackConsoleStatus.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtBackConsoleStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackConsoleStatus.ForeColor = System.Drawing.Color.Lime
        Me.txtBackConsoleStatus.Location = New System.Drawing.Point(26, 123)
        Me.txtBackConsoleStatus.Multiline = True
        Me.txtBackConsoleStatus.Name = "txtBackConsoleStatus"
        Me.txtBackConsoleStatus.ReadOnly = True
        Me.txtBackConsoleStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBackConsoleStatus.Size = New System.Drawing.Size(355, 256)
        Me.txtBackConsoleStatus.TabIndex = 11
        '
        'txtFrontConsoleStatus
        '
        Me.txtFrontConsoleStatus.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtFrontConsoleStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrontConsoleStatus.ForeColor = System.Drawing.Color.Lime
        Me.txtFrontConsoleStatus.Location = New System.Drawing.Point(420, 123)
        Me.txtFrontConsoleStatus.Multiline = True
        Me.txtFrontConsoleStatus.Name = "txtFrontConsoleStatus"
        Me.txtFrontConsoleStatus.ReadOnly = True
        Me.txtFrontConsoleStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFrontConsoleStatus.Size = New System.Drawing.Size(355, 256)
        Me.txtFrontConsoleStatus.TabIndex = 12
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(841, 566)
        Me.Controls.Add(Me.txtFrontConsoleStatus)
        Me.Controls.Add(Me.txtBackConsoleStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblFrontStatus)
        Me.Controls.Add(Me.lblBackStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnFrontStart)
        Me.Controls.Add(Me.btnBackStart)
        Me.Name = "Main"
        Me.Text = "DCS VIRTUAL COCKPIT"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBackStart As Button
    Friend WithEvents btnFrontStart As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ddMenu As ToolStripDropDownButton
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBackStatus As Label
    Friend WithEvents lblFrontStatus As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBackConsoleStatus As TextBox
    Friend WithEvents txtFrontConsoleStatus As TextBox
End Class
