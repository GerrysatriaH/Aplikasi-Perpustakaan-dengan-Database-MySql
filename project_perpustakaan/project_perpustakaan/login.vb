Public Class login
    Public Shared perpustakaan As perpustakaan
    Public Shared Users As Users
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        perpustakaan = New perpustakaan()
        Users = New Users()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUserName.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.usernameProperty = data_user(1)
            perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If

        'Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)
        'If AuthStatus Then
        '    MessageBox.Show("Login Berhasil !!")
        '    perpustakaan.Show()
        'End If
        'Try And Catch Statement
        'Try
        '    If AuthStatus = False Then
        '        Throw New System.Exception()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Username & Password Salah !")
        'End Try

    End Sub
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Dim daftar_form = New daftar()
        daftar_form.Show()
        Me.Hide()
    End Sub
End Class