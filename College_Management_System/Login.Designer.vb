<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPass = New MetroFramework.Controls.MetroTextBox()
        Me.tbUser = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnLog.FlatAppearance.BorderSize = 0
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLog.Location = New System.Drawing.Point(110, 231)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(139, 28)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "Login"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(159, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Reset"
        '
        'tbPass
        '
        '
        '
        '
        Me.tbPass.CustomButton.Image = Nothing
        Me.tbPass.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.tbPass.CustomButton.Name = ""
        Me.tbPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPass.CustomButton.TabIndex = 1
        Me.tbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPass.CustomButton.UseSelectable = True
        Me.tbPass.CustomButton.Visible = False
        Me.tbPass.DisplayIcon = True
        Me.tbPass.Icon = Global.CMS.My.Resources.Resources.Pass_icon
        Me.tbPass.Lines = New String(-1) {}
        Me.tbPass.Location = New System.Drawing.Point(84, 180)
        Me.tbPass.MaxLength = 32767
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPass.PromptText = "Password"
        Me.tbPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPass.SelectedText = ""
        Me.tbPass.SelectionLength = 0
        Me.tbPass.SelectionStart = 0
        Me.tbPass.ShortcutsEnabled = True
        Me.tbPass.Size = New System.Drawing.Size(191, 23)
        Me.tbPass.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPass.TabIndex = 2
        Me.tbPass.UseSelectable = True
        Me.tbPass.UseStyleColors = True
        Me.tbPass.UseSystemPasswordChar = True
        Me.tbPass.WaterMark = "Password"
        Me.tbPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbUser
        '
        '
        '
        '
        Me.tbUser.CustomButton.Image = Nothing
        Me.tbUser.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.tbUser.CustomButton.Name = ""
        Me.tbUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUser.CustomButton.TabIndex = 1
        Me.tbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUser.CustomButton.UseSelectable = True
        Me.tbUser.CustomButton.Visible = False
        Me.tbUser.DisplayIcon = True
        Me.tbUser.Icon = Global.CMS.My.Resources.Resources.User_icon
        Me.tbUser.Lines = New String(-1) {}
        Me.tbUser.Location = New System.Drawing.Point(84, 133)
        Me.tbUser.MaxLength = 32767
        Me.tbUser.Name = "tbUser"
        Me.tbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUser.PromptText = "Username"
        Me.tbUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUser.SelectedText = ""
        Me.tbUser.SelectionLength = 0
        Me.tbUser.SelectionStart = 0
        Me.tbUser.ShortcutsEnabled = True
        Me.tbUser.Size = New System.Drawing.Size(191, 23)
        Me.tbUser.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUser.TabIndex = 1
        Me.tbUser.UseSelectable = True
        Me.tbUser.UseStyleColors = True
        Me.tbUser.WaterMark = "Username"
        Me.tbUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CMS.My.Resources.Resources.CMS_final
        Me.PictureBox1.Location = New System.Drawing.Point(76, -28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnCloseForm
        '
        Me.btnCloseForm.FlatAppearance.BorderSize = 0
        Me.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseForm.Image = Global.CMS.My.Resources.Resources.Close_icon
        Me.btnCloseForm.Location = New System.Drawing.Point(312, 2)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(38, 33)
        Me.btnCloseForm.TabIndex = 8
        Me.btnCloseForm.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 342)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCloseForm As System.Windows.Forms.Button
End Class
