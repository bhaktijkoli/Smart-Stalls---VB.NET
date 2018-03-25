<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabMain = New MetroFramework.Controls.MetroTabControl()
        Me.TabRegister = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Txtaadhaar = New MetroFramework.Controls.MetroTextBox()
        Me.CmdRegister = New MetroFramework.Controls.MetroButton()
        Me.TabMain.SuspendLayout()
        Me.TabRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TabRegister)
        Me.TabMain.Controls.Add(Me.MetroTabPage2)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMain.HotTrack = True
        Me.TabMain.ItemSize = New System.Drawing.Size(100, 34)
        Me.TabMain.Location = New System.Drawing.Point(0, 0)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(584, 362)
        Me.TabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabMain.TabIndex = 0
        Me.TabMain.UseSelectable = True
        '
        'TabRegister
        '
        Me.TabRegister.Controls.Add(Me.CmdRegister)
        Me.TabRegister.Controls.Add(Me.Txtaadhaar)
        Me.TabRegister.Controls.Add(Me.MetroLabel1)
        Me.TabRegister.HorizontalScrollbarBarColor = True
        Me.TabRegister.HorizontalScrollbarHighlightOnWheel = False
        Me.TabRegister.HorizontalScrollbarSize = 10
        Me.TabRegister.Location = New System.Drawing.Point(4, 38)
        Me.TabRegister.Name = "TabRegister"
        Me.TabRegister.Size = New System.Drawing.Size(576, 320)
        Me.TabRegister.TabIndex = 0
        Me.TabRegister.Text = "Register"
        Me.TabRegister.VerticalScrollbarBarColor = True
        Me.TabRegister.VerticalScrollbarHighlightOnWheel = False
        Me.TabRegister.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(576, 320)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Settings"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 26)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Aadhaar No:"
        '
        'Txtaadhaar
        '
        '
        '
        '
        Me.Txtaadhaar.CustomButton.Image = Nothing
        Me.Txtaadhaar.CustomButton.Location = New System.Drawing.Point(274, 1)
        Me.Txtaadhaar.CustomButton.Name = ""
        Me.Txtaadhaar.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Txtaadhaar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Txtaadhaar.CustomButton.TabIndex = 1
        Me.Txtaadhaar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Txtaadhaar.CustomButton.UseSelectable = True
        Me.Txtaadhaar.CustomButton.Visible = False
        Me.Txtaadhaar.Lines = New String(-1) {}
        Me.Txtaadhaar.Location = New System.Drawing.Point(98, 26)
        Me.Txtaadhaar.MaxLength = 32767
        Me.Txtaadhaar.Name = "Txtaadhaar"
        Me.Txtaadhaar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txtaadhaar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txtaadhaar.SelectedText = ""
        Me.Txtaadhaar.SelectionLength = 0
        Me.Txtaadhaar.SelectionStart = 0
        Me.Txtaadhaar.ShortcutsEnabled = True
        Me.Txtaadhaar.Size = New System.Drawing.Size(296, 23)
        Me.Txtaadhaar.TabIndex = 3
        Me.Txtaadhaar.UseSelectable = True
        Me.Txtaadhaar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Txtaadhaar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CmdRegister
        '
        Me.CmdRegister.Location = New System.Drawing.Point(98, 55)
        Me.CmdRegister.Name = "CmdRegister"
        Me.CmdRegister.Size = New System.Drawing.Size(110, 23)
        Me.CmdRegister.TabIndex = 4
        Me.CmdRegister.Text = "Register"
        Me.CmdRegister.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 362)
        Me.Controls.Add(Me.TabMain)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Stalls"
        Me.TopMost = True
        Me.TabMain.ResumeLayout(False)
        Me.TabRegister.ResumeLayout(False)
        Me.TabRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabMain As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabRegister As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Txtaadhaar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmdRegister As MetroFramework.Controls.MetroButton
End Class
