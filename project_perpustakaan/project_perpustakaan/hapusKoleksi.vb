Public Class hapusKoleksi
    'Dim selected = perpustakaan.DataGridKoleksi.
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LblSelectedName.Text = selected
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim hapus_item = perpustakaan.LBKoleksiBuku.SelectedItem()
        perpustakaan.koleksi.RemoveKoleksi(hapus_item)
        perpustakaan.koleksi.DeleteDataKoleksiByIdDatabase(perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class