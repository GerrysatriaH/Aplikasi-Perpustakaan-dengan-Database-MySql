Imports System.Globalization

Public Class tambahKoleksi

    Dim jenis_koleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"}
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CBJenisKoleksi.DataSource = jenis_koleksi

        DateMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateMasukKoleksi.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenImageKoleksi.Title = "Open Gambar Koleksi"
        OpenImageKoleksi.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Imahe JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenImageKoleksi.ShowDialog()

        Dim picKoleksiDir As String = OpenImageKoleksi.FileName

        PictKoleksi.Load(picKoleksiDir)
        PictKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        perpustakaan.koleksi.dirGambarBukuProperty = picKoleksiDir.ToString()
        perpustakaan.koleksi.dirGambarBukuProperty = perpustakaan.koleksi.dirGambarBukuProperty.Replace("\", "/")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        perpustakaan.koleksi.namaKoleksiProperty = TxtNamaKoleksi.Text.ToString()
        perpustakaan.koleksi.jenisKoleksiProperty = CBJenisKoleksi.SelectedItem().ToString()
        perpustakaan.koleksi.deskripsiKoleksiProperty = RTBDeskripsi.Text.ToString()
        perpustakaan.koleksi.penerbitProperty = TxtPenerbit.Text.ToString()

        If TxtTahunTerbit.Text = "" Then
            MessageBox.Show("Tahun Terbit tidak boleh kosong !!")
        Else
            perpustakaan.koleksi.tahunTerbitProperty = Integer.Parse(TxtTahunTerbit.Text)
        End If

        perpustakaan.koleksi.lokasiProperty = TxtLokasirRak.Text.ToString()
        perpustakaan.koleksi.tanggalMasukKoleksiProperty = DateMasukKoleksi.Value.ToShortDateString()

        If TxtStok.Text = "" Then
            MessageBox.Show("Stok tidak boleh kosong !!")
        Else
            perpustakaan.koleksi.stockProperty = Integer.Parse(TxtStok.Text)
        End If

        If RBIndonesia.Checked Then
            perpustakaan.koleksi.bahasaProperty = "Indonesia"
        ElseIf RBInggris.Checked Then
            perpustakaan.koleksi.bahasaProperty = "Inggris"
        End If

        If chkSains.Checked() Then
            perpustakaan.koleksi.AddKategori("Sains")
        End If

        If chkSosial.Checked() Then
            perpustakaan.koleksi.AddKategori("Sosial")
        End If

        If chkTeknologi.Checked() Then
            perpustakaan.koleksi.AddKategori("Teknologi")
        End If

        If chkBudaya.Checked() Then
            perpustakaan.koleksi.AddKategori("Budaya")
        End If

        perpustakaan.koleksi.AddKoleksi(TxtNamaKoleksi.Text.ToString())


        If perpustakaan.koleksi.dirGambarBukuProperty IsNot Nothing Then
            Dim convertedKoleksi = perpustakaan.koleksi.ConvertKoleksiToString(perpustakaan.koleksi.getKategoriItem)
            perpustakaan.koleksi.AddDataKoleksiDatabase(perpustakaan.koleksi.dirGambarBukuProperty,
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
        Else
            MessageBox.Show("Masukkan Gambar terlebih dahulu")
        End If
    End Sub

    Private Sub TxtTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please insert number only")
        End If
    End Sub

    Private Sub TxtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please insert number only")
        End If
    End Sub
End Class