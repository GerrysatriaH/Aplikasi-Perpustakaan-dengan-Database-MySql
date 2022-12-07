Public Class infoTambahKoleksi

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LBKategori.Items.Clear()

        PBGambarKoleksi.Load(perpustakaan.koleksi.dirGambarBukuProperty)
        PBGambarKoleksi.SizeMode = PictureBoxSizeMode.StretchImage

        valueNama.Text = perpustakaan.koleksi.namaKoleksiProperty
        valueJenis.Text = perpustakaan.koleksi.jenisKoleksiProperty
        valueDeskripsi.Text = perpustakaan.koleksi.deskripsiKoleksiProperty
        valuePenerbit.Text = perpustakaan.koleksi.penerbitProperty
        valueTahunTerbit.Text = perpustakaan.koleksi.tahunTerbitProperty
        valueLokasiRak.Text = perpustakaan.koleksi.lokasiProperty
        valueTanggalMasuk.Text = perpustakaan.koleksi.tanggalMasukKoleksiProperty
        valueStok.Text = perpustakaan.koleksi.stockProperty
        valueBahasa.Text = perpustakaan.koleksi.bahasaProperty

        For Each info_tambah In perpustakaan.koleksi.getKategoriItem
            LBKategori.Items.Add(info_tambah)
        Next

        perpustakaan.koleksi.getKategoriItem.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class