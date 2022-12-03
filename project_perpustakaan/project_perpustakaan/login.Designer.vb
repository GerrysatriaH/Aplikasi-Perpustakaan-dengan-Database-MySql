<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.Location = New System.Drawing.Point(28, 67)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(97, 25)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPassword.Location = New System.Drawing.Point(28, 114)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(91, 25)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Password"
        '
        'TxtUserName
        '
        Me.TxtUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtUserName.Location = New System.Drawing.Point(198, 67)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(394, 29)
        Me.TxtUserName.TabIndex = 2
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPassword.Location = New System.Drawing.Point(198, 114)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(394, 29)
        Me.TxtPassword.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogin.Location = New System.Drawing.Point(249, 217)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(118, 28)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblLogin.Location = New System.Drawing.Point(272, 18)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(78, 30)
        Me.LblLogin.TabIndex = 5
        Me.LblLogin.Text = "LOGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(198, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Belum Punya Akun ?"
        '
        'BtnDaftar
        '
        Me.BtnDaftar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDaftar.Location = New System.Drawing.Point(356, 159)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(109, 28)
        Me.BtnDaftar.TabIndex = 7
        Me.BtnDaftar.Text = "Daftar User"
        Me.BtnDaftar.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 257)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblLogin As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnDaftar As Button
End Class
