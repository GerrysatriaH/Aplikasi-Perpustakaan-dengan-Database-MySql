Public Class hapusListKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblSelectedName.Text = perpustakaan.selectedListBox
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        perpustakaan.koleksi.DeleteDataKoleksiByNamaKoleksi(perpustakaan.selectedListBox)
        Me.Close()
    End Sub
End Class