Public Class updateKoleksi

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictKoleksi.Load(perpustakaan.koleksi.dirGambarBukuProperty)
        PictKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        DateMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TxtNamaKoleksi.Text = perpustakaan.koleksi.namaKoleksiProperty
        CbJenisKoleksi.SelectedItem() = perpustakaan.koleksi.jenisKoleksiProperty
        RtxDeskripsi.Text = perpustakaan.koleksi.deskripsiKoleksiProperty
        TxtPenerbit.Text = perpustakaan.koleksi.penerbitProperty
        TxtTahunTerbit.Text = perpustakaan.koleksi.tahunTerbitProperty
        TxtLokasiRak.Text = perpustakaan.koleksi.lokasiProperty
        DateMasukKoleksi.Value = perpustakaan.koleksi.tanggalMasukKoleksiProperty
        TxtStock.Text = perpustakaan.koleksi.stockProperty

        If String.Compare(perpustakaan.koleksi.bahasaProperty, "Indonesia") = 0 Then
            RbIndonesia.Checked = True
        ElseIf String.Compare(perpustakaan.koleksi.bahasaProperty, "Inggris") = 0 Then
            RbInggris.Checked = True
        End If

        For Each kategoriItem In perpustakaan.koleksi.getKategoriItem

            If String.Compare(kategoriItem, "Sains") = 0 Then
                ChkSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                ChkSocial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                ChkTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                ChkBudaya.Checked = True
            End If

        Next
        perpustakaan.koleksi.resetKategori()
    End Sub

    Private Sub BtnUpdateGambar_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambar.Click
        OpenImageKoleksi.Title = "Open Gambar Koleksi"
        OpenImageKoleksi.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Imahe JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|"
        OpenImageKoleksi.ShowDialog()

        Dim pictKoleksiDir As String = OpenImageKoleksi.FileName

        PictKoleksi.Load(pictKoleksiDir)
        PictKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        perpustakaan.koleksi.dirGambarBukuProperty = pictKoleksiDir.ToString()
        perpustakaan.koleksi.dirGambarBukuProperty = perpustakaan.koleksi.dirGambarBukuProperty.Replace("\", "/")
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        perpustakaan.koleksi.namaKoleksiProperty = TxtNamaKoleksi.Text.ToString()
        perpustakaan.koleksi.jenisKoleksiProperty = CbJenisKoleksi.SelectedItem().ToString()
        perpustakaan.koleksi.deskripsiKoleksiProperty = RtxDeskripsi.Text.ToString()
        perpustakaan.koleksi.penerbitProperty = TxtPenerbit.Text.ToString()
        perpustakaan.koleksi.tahunTerbitProperty = Integer.Parse(TxtTahunTerbit.Text)

        perpustakaan.koleksi.lokasiProperty = TxtLokasiRak.Text.ToString()
        perpustakaan.koleksi.tanggalMasukKoleksiProperty = DateMasukKoleksi.Value.ToString("yyyy/MM/dd")
        perpustakaan.koleksi.stockProperty = Integer.Parse(TxtStock.Text)

        If RbIndonesia.Checked Then
            perpustakaan.koleksi.bahasaProperty = "Indonesia"
        ElseIf RbInggris.Checked Then
            perpustakaan.koleksi.bahasaProperty = "Inggris"
        End If

        If ChkSains.Checked Then
            perpustakaan.koleksi.AddKategori("Sains")
        End If

        If ChkSocial.Checked Then
            perpustakaan.koleksi.AddKategori("Sosial")
        End If

        If ChkTeknologi.Checked Then
            perpustakaan.koleksi.AddKategori("Teknologi")
        End If

        If ChkBudaya.Checked Then
            perpustakaan.koleksi.AddKategori("Budaya")
        End If

        perpustakaan.koleksi.AddKoleksi(TxtNamaKoleksi.Text.ToString())

        Dim convertedKoleksi = perpustakaan.koleksi.ConvertKoleksiToString(perpustakaan.koleksi.getKategoriItem)
        perpustakaan.koleksi.UpdateDataKoleksiByIDDatabase(perpustakaan.selectedTableKoleksi,
                                                           perpustakaan.koleksi.dirGambarBukuProperty,
                                                           perpustakaan.koleksi.namaKoleksiProperty,
                                                           perpustakaan.koleksi.jenisKoleksiProperty,
                                                           perpustakaan.koleksi.penerbitProperty,
                                                           perpustakaan.koleksi.deskripsiKoleksiProperty,
                                                           perpustakaan.koleksi.tahunTerbitProperty,
                                                           perpustakaan.koleksi.lokasiProperty,
                                                           perpustakaan.koleksi.tanggalMasukKoleksiProperty,
                                                           perpustakaan.koleksi.stockProperty,
                                                           perpustakaan.koleksi.bahasaProperty,
                                                           convertedKoleksi
                                                           )
        Dim infoTambah = New infoTambahKoleksi()

        infoTambah.Show()
        Me.Close()
    End Sub
End Class