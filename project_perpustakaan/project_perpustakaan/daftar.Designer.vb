<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar
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
        Me.TxtDaftarPassword = New System.Windows.Forms.TextBox()
        Me.TxtDaftarUsername = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblDaftar = New System.Windows.Forms.Label()
        Me.BtnDaftarUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtDaftarPassword
        '
        Me.TxtDaftarPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDaftarPassword.Location = New System.Drawing.Point(197, 137)
        Me.TxtDaftarPassword.Name = "TxtDaftarPassword"
        Me.TxtDaftarPassword.Size = New System.Drawing.Size(394, 29)
        Me.TxtDaftarPassword.TabIndex = 7
        '
        'TxtDaftarUsername
        '
        Me.TxtDaftarUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDaftarUsername.Location = New System.Drawing.Point(197, 90)
        Me.TxtDaftarUsername.Name = "TxtDaftarUsername"
        Me.TxtDaftarUsername.Size = New System.Drawing.Size(394, 29)
        Me.TxtDaftarUsername.TabIndex = 6
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPassword.Location = New System.Drawing.Point(27, 137)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(91, 25)
        Me.LblPassword.TabIndex = 5
        Me.LblPassword.Text = "Password"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.Location = New System.Drawing.Point(27, 90)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(97, 25)
        Me.LblUsername.TabIndex = 4
        Me.LblUsername.Text = "Username"
        '
        'LblDaftar
        '
        Me.LblDaftar.AutoSize = True
        Me.LblDaftar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDaftar.Location = New System.Drawing.Point(238, 27)
        Me.LblDaftar.Name = "LblDaftar"
        Me.LblDaftar.Size = New System.Drawing.Size(152, 30)
        Me.LblDaftar.TabIndex = 8
        Me.LblDaftar.Text = "DAFTAR USER"
        '
        'BtnDaftarUser
        '
        Me.BtnDaftarUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDaftarUser.Location = New System.Drawing.Point(250, 200)
        Me.BtnDaftarUser.Name = "BtnDaftarUser"
        Me.BtnDaftarUser.Size = New System.Drawing.Size(118, 28)
        Me.BtnDaftarUser.TabIndex = 9
        Me.BtnDaftarUser.Text = "Daftar"
        Me.BtnDaftarUser.UseVisualStyleBackColor = True
        '
        'daftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 257)
        Me.Controls.Add(Me.BtnDaftarUser)
        Me.Controls.Add(Me.LblDaftar)
        Me.Controls.Add(Me.TxtDaftarPassword)
        Me.Controls.Add(Me.TxtDaftarUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "daftar"
        Me.Text = "daftar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDaftarPassword As TextBox
    Friend WithEvents TxtDaftarUsername As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblDaftar As Label
    Friend WithEvents BtnDaftarUser As Button
End Class
