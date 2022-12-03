Public Class daftar
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub BtnDaftarUser_Click(sender As Object, e As EventArgs) Handles BtnDaftarUser.Click
        login.Users.usernameProperty = TxtDaftarUsername.Text
        login.Users.passwordProperty = TxtDaftarPassword.Text
        login.Users.accountUser(TxtDaftarUsername.Text,
                          TxtDaftarPassword.Text)

        login.Show()
        Me.Close()
    End Sub
End Class