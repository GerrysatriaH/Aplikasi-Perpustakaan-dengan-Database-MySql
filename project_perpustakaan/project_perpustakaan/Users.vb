Imports System.Security.Cryptography

Public Class Users
    Private username As String
    Private password As String

    Private data_user As New ArrayList()
    Private TripleDes As New TripleDESCryptoServiceProvider

    Public Property usernameProperty() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property passwordProperty() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public Function EncryptData(ByVal plaintext As String) As String
        'Convert the plaintext string to a byte array
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        'Create the stream
        Dim ms As New System.IO.MemoryStream
        'Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        'Use the crypto stream to write the byte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        'Convert the encryted stream to a printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function accountUser(username As String,
                                password As String)
        data_user.Add({username,
                       password})
    End Function

    Public ReadOnly Property getUser() As ArrayList
        Get
            Return data_user
        End Get
    End Property

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String
        'Static Password
        'Dim realPassword As String = EncryptData("12345")
        'Dim realUsername As String = "gerry"

        'If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPassword) = 0 Then
        '    Return True
        'Else
        '    Return False
        'End If

        For Each rowUser In getUser()
            Dim AuthUser = String.Compare(username, rowUser(0))
            If AuthUser = 0 Then
                Dim AuthPass = String.Compare(EncryptData(plainPassword), EncryptData(rowUser(1)))
                If AuthPass = 0 Then
                    Return True
                End If
            End If
        Next

        Return False

    End Function
End Class