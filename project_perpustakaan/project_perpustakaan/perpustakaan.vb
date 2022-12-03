
Public Class perpustakaan

    Public Shared koleksi As koleksi

    Dim selected As String
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama 
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        koleksi = New koleksi()
        ReloadDataTableDatabase()
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim tambah = New tambahKoleksi()
        tambah.Show()
    End Sub

    Private Sub HapusKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim hapus = New hapusKoleksi()
        hapus.Show()
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Dim tambah = New tambahKoleksi()
        tambah.Show()
    End Sub
    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        Dim hapus = New hapusKoleksi()

        selected = LBKoleksiBuku.SelectedItem()
        If selected IsNot Nothing Then
            hapus.Show()
        Else
            MessageBox.Show("Pilih Koleksi yang ingin dihapus")
        End If
    End Sub

    Private Sub ArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrayToolStripMenuItem.Click
        Dim array = New array()
        array.Show()
    End Sub

    'Public Sub UpdateDataTableArrayList()
    '    DataGridKoleksi.Rows.Clear()
    '    For Each rowKoleksi In koleksi.getKoleksiDataTable()
    '        Dim dataTable As String() = {rowKoleksi(1),
    '                                     rowKoleksi(2),
    '                                     rowKoleksi(3),
    '                                     rowKoleksi(4),
    '                                     rowKoleksi(5),
    '                                     rowKoleksi(6),
    '                                     rowKoleksi(7),
    '                                     rowKoleksi(8),
    '                                     rowKoleksi(10),
    '                                     rowKoleksi(9)}
    '        DataGridKoleksi.Rows.Add(dataTable)
    '    Next
    'End Sub

    Private Sub perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'LBKoleksiBuku.Items.Clear()
        'For Each koll In koleksi.getKoleksiItem
        '    LBKoleksiBuku.Items.Add(koll)
        'Next
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    'Private Sub BtnSelect_Click(sender As Object, e As EventArgs)
    '    Dim dataSelected = koleksi.getKoleksiDataTable.Item(selectedTableKoleksi)

    '    koleksi.namaKoleksiProperty = dataSelected(1)
    '    koleksi.jenisKoleksiProperty = dataSelected(2)
    '    koleksi.deskripsiKoleksiProperty = dataSelected(3)
    '    koleksi.penerbitProperty = dataSelected(4)
    '    koleksi.tahunTerbitProperty = dataSelected(5)
    '    koleksi.lokasiProperty = dataSelected(6)
    '    koleksi.tanggalMasukKoleksiProperty = dataSelected(7)
    '    koleksi.stockProperty = dataSelected(8)
    '    koleksi.bahasaProperty = dataSelected(9)

    '    Dim data_koleksi As List(Of String) = koleksi.ConvertStringToKoleksi(dataSelected(10))

    '    'For Each info_tambah In data_koleksi
    '    '    koleksi.AddKategori(info_tambah)
    '    'Next

    '    Dim infoTambah = New infoTambahKoleksi()
    '    infoTambah.Show()
    'End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = koleksi.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        koleksi.dirGambarBukuProperty = selectedKoleksi(2)

        koleksi.namaKoleksiProperty = selectedKoleksi(1)
        koleksi.jenisKoleksiProperty = selectedKoleksi(5)
        koleksi.deskripsiKoleksiProperty = selectedKoleksi(3)
        koleksi.penerbitProperty = selectedKoleksi(4)
        koleksi.tahunTerbitProperty = selectedKoleksi(6)
        koleksi.lokasiProperty = selectedKoleksi(7)
        koleksi.tanggalMasukKoleksiProperty = selectedKoleksi(8)
        koleksi.stockProperty = selectedKoleksi(9)
        koleksi.bahasaProperty = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            koleksi.AddKategori(info_kategori)
        Next

        Dim formUpdate = New updateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim formhapus = New hapusKoleksi()
        formhapus.Show()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        koleksi.dirGambarBukuProperty = selectedKoleksi(2)

        koleksi.namaKoleksiProperty = selectedKoleksi(1)
        koleksi.jenisKoleksiProperty = selectedKoleksi(5)
        koleksi.deskripsiKoleksiProperty = selectedKoleksi(3)
        koleksi.penerbitProperty = selectedKoleksi(4)
        koleksi.tahunTerbitProperty = selectedKoleksi(6)
        koleksi.lokasiProperty = selectedKoleksi(7)
        koleksi.tanggalMasukKoleksiProperty = selectedKoleksi(8)
        koleksi.stockProperty = selectedKoleksi(9)
        koleksi.bahasaProperty = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            koleksi.AddKategori(info_kategori)
        Next

        Dim infoTambah = New infoTambahKoleksi()
        infoTambah.Show()
    End Sub
End Class