Public Class daftar

    Private users As Users
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
    End Sub
    Private Sub BtnDaftarUser_Click(sender As Object, e As EventArgs) Handles BtnDaftarUser.Click
        'login.Users.usernameProperty = TxtDaftarUsername.Text
        'login.Users.passwordProperty = TxtDaftarPassword.Text
        'login.Users.accountUser(TxtDaftarUsername.Text,
        '                        TxtDaftarPassword.Text)
        'login.Show()
        'Me.Close()

        If TxtDaftarUsername.Text.Length > 0 And TxtDaftarPassword.Text.Length > 0 Then
            If users.getUserNameFromDB(TxtDaftarUsername.Text) = True Then
                MessageBox.Show("Username sudah Terdaftar")
            Else
                login.Users.AddUsersDatabase(TxtDaftarUsername.Text, TxtDaftarPassword.Text)
                Me.Close()
                login.Show()
            End If
        Else
            MessageBox.Show("Lengkapi Data")
        End If

        'If TxtDaftarUsername.Text.Length > 0 And TxtDaftarPassword.Text.Length > 0 Then
        '    login.Users.AddUsersDatabase(TxtDaftarUsername.Text, TxtDaftarPassword.Text)
        '    Me.Close()
        'Else
        '    MessageBox.Show("Lengkapi Data")
        'End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        login.Show()
        Me.Close()
    End Sub
End Class