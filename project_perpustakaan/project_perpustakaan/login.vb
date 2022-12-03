Public Class login
    Public Shared Users As Users
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername = TxtUserName.Text
        Dim plainPassword = TxtPassword.Text
        Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)
        If AuthStatus Then
            MessageBox.Show("Login Berhasil !!")
            perpustakaan.Show()
        End If

        'Try And Catch Statement
        Try
            If AuthStatus = False Then
                Throw New System.Exception()
            End If
        Catch ex As Exception
            MessageBox.Show("Username & Password Salah !")
        End Try
    End Sub
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Dim daftar_form = New daftar()
        daftar_form.Show()
    End Sub
End Class