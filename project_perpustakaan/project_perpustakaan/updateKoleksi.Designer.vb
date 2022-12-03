<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBBahasa = New System.Windows.Forms.GroupBox()
        Me.RbInggris = New System.Windows.Forms.RadioButton()
        Me.RbIndonesia = New System.Windows.Forms.RadioButton()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.DateMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.RtxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CbJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.LblTanggalMasuk = New System.Windows.Forms.Label()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.BtnUpdateGambar = New System.Windows.Forms.Button()
        Me.PictKoleksi = New System.Windows.Forms.PictureBox()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.GBKategori = New System.Windows.Forms.GroupBox()
        Me.ChkBudaya = New System.Windows.Forms.CheckBox()
        Me.ChkTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChkSocial = New System.Windows.Forms.CheckBox()
        Me.ChkSains = New System.Windows.Forms.CheckBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.OpenImageKoleksi = New System.Windows.Forms.OpenFileDialog()
        Me.GBBahasa.SuspendLayout()
        CType(Me.PictKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBKategori.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBBahasa
        '
        Me.GBBahasa.Controls.Add(Me.RbInggris)
        Me.GBBahasa.Controls.Add(Me.RbIndonesia)
        Me.GBBahasa.Location = New System.Drawing.Point(364, 402)
        Me.GBBahasa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBBahasa.Name = "GBBahasa"
        Me.GBBahasa.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBBahasa.Size = New System.Drawing.Size(256, 75)
        Me.GBBahasa.TabIndex = 69
        Me.GBBahasa.TabStop = False
        Me.GBBahasa.Text = "Bahasa"
        '
        'RbInggris
        '
        Me.RbInggris.AutoSize = True
        Me.RbInggris.Location = New System.Drawing.Point(14, 43)
        Me.RbInggris.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbInggris.Name = "RbInggris"
        Me.RbInggris.Size = New System.Drawing.Size(101, 19)
        Me.RbInggris.TabIndex = 24
        Me.RbInggris.TabStop = True
        Me.RbInggris.Text = "Bahasa Inggris"
        Me.RbInggris.UseVisualStyleBackColor = True
        '
        'RbIndonesia
        '
        Me.RbIndonesia.AutoSize = True
        Me.RbIndonesia.Location = New System.Drawing.Point(14, 18)
        Me.RbIndonesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbIndonesia.Name = "RbIndonesia"
        Me.RbIndonesia.Size = New System.Drawing.Size(116, 19)
        Me.RbIndonesia.TabIndex = 23
        Me.RbIndonesia.TabStop = True
        Me.RbIndonesia.Text = "Bahasa Indonesia"
        Me.RbIndonesia.UseVisualStyleBackColor = True
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(364, 372)
        Me.TxtStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(257, 23)
        Me.TxtStock.TabIndex = 68
        '
        'DateMasukKoleksi
        '
        Me.DateMasukKoleksi.CustomFormat = "dddd, MMMM d, yyyy"
        Me.DateMasukKoleksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateMasukKoleksi.Location = New System.Drawing.Point(364, 339)
        Me.DateMasukKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateMasukKoleksi.Name = "DateMasukKoleksi"
        Me.DateMasukKoleksi.Size = New System.Drawing.Size(257, 23)
        Me.DateMasukKoleksi.TabIndex = 49
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(364, 307)
        Me.TxtLokasiRak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(257, 23)
        Me.TxtLokasiRak.TabIndex = 67
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(364, 275)
        Me.TxtTahunTerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(257, 23)
        Me.TxtTahunTerbit.TabIndex = 66
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(364, 244)
        Me.TxtPenerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(257, 23)
        Me.TxtPenerbit.TabIndex = 65
        '
        'RtxDeskripsi
        '
        Me.RtxDeskripsi.Location = New System.Drawing.Point(364, 124)
        Me.RtxDeskripsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RtxDeskripsi.Name = "RtxDeskripsi"
        Me.RtxDeskripsi.Size = New System.Drawing.Size(257, 108)
        Me.RtxDeskripsi.TabIndex = 64
        Me.RtxDeskripsi.Text = ""
        '
        'CbJenisKoleksi
        '
        Me.CbJenisKoleksi.FormattingEnabled = True
        Me.CbJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CbJenisKoleksi.Location = New System.Drawing.Point(364, 89)
        Me.CbJenisKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CbJenisKoleksi.Name = "CbJenisKoleksi"
        Me.CbJenisKoleksi.Size = New System.Drawing.Size(257, 23)
        Me.CbJenisKoleksi.TabIndex = 63
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(364, 57)
        Me.TxtNamaKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(257, 23)
        Me.TxtNamaKoleksi.TabIndex = 62
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(205, 402)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(44, 15)
        Me.LblBahasa.TabIndex = 61
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Location = New System.Drawing.Point(205, 375)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(36, 15)
        Me.LblStok.TabIndex = 60
        Me.LblStok.Text = "Stock"
        '
        'LblTanggalMasuk
        '
        Me.LblTanggalMasuk.AutoSize = True
        Me.LblTanggalMasuk.Location = New System.Drawing.Point(205, 344)
        Me.LblTanggalMasuk.Name = "LblTanggalMasuk"
        Me.LblTanggalMasuk.Size = New System.Drawing.Size(126, 15)
        Me.LblTanggalMasuk.TabIndex = 59
        Me.LblTanggalMasuk.Text = "Tanggal Masuk Koleksi"
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Location = New System.Drawing.Point(205, 311)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(62, 15)
        Me.LblLokasiRak.TabIndex = 58
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(205, 278)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(71, 15)
        Me.LblTahunTerbit.TabIndex = 57
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(205, 247)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(51, 15)
        Me.LblPenerbit.TabIndex = 56
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(205, 125)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(54, 15)
        Me.LblDeskripsi.TabIndex = 55
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(205, 92)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(72, 15)
        Me.LblJenisKoleksi.TabIndex = 54
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(205, 60)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(79, 15)
        Me.LblNamaKoleksi.TabIndex = 53
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'BtnUpdateGambar
        '
        Me.BtnUpdateGambar.Location = New System.Drawing.Point(23, 243)
        Me.BtnUpdateGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdateGambar.Name = "BtnUpdateGambar"
        Me.BtnUpdateGambar.Size = New System.Drawing.Size(169, 24)
        Me.BtnUpdateGambar.TabIndex = 52
        Me.BtnUpdateGambar.Text = "Tambah Gambar"
        Me.BtnUpdateGambar.UseVisualStyleBackColor = True
        '
        'PictKoleksi
        '
        Me.PictKoleksi.Location = New System.Drawing.Point(23, 59)
        Me.PictKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictKoleksi.Name = "PictKoleksi"
        Me.PictKoleksi.Size = New System.Drawing.Size(169, 173)
        Me.PictKoleksi.TabIndex = 51
        Me.PictKoleksi.TabStop = False
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJudul.Location = New System.Drawing.Point(23, 17)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(169, 30)
        Me.LblJudul.TabIndex = 50
        Me.LblJudul.Text = "Update Koleksi"
        '
        'GBKategori
        '
        Me.GBKategori.Controls.Add(Me.ChkBudaya)
        Me.GBKategori.Controls.Add(Me.ChkTeknologi)
        Me.GBKategori.Controls.Add(Me.ChkSocial)
        Me.GBKategori.Controls.Add(Me.ChkSains)
        Me.GBKategori.Location = New System.Drawing.Point(365, 494)
        Me.GBKategori.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBKategori.Name = "GBKategori"
        Me.GBKategori.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBKategori.Size = New System.Drawing.Size(256, 120)
        Me.GBKategori.TabIndex = 72
        Me.GBKategori.TabStop = False
        Me.GBKategori.Text = "Kategori"
        '
        'ChkBudaya
        '
        Me.ChkBudaya.AutoSize = True
        Me.ChkBudaya.Location = New System.Drawing.Point(14, 91)
        Me.ChkBudaya.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkBudaya.Name = "ChkBudaya"
        Me.ChkBudaya.Size = New System.Drawing.Size(65, 19)
        Me.ChkBudaya.TabIndex = 28
        Me.ChkBudaya.Text = "Budaya"
        Me.ChkBudaya.UseVisualStyleBackColor = True
        '
        'ChkTeknologi
        '
        Me.ChkTeknologi.AutoSize = True
        Me.ChkTeknologi.Location = New System.Drawing.Point(14, 68)
        Me.ChkTeknologi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkTeknologi.Name = "ChkTeknologi"
        Me.ChkTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.ChkTeknologi.TabIndex = 27
        Me.ChkTeknologi.Text = "Teknologi"
        Me.ChkTeknologi.UseVisualStyleBackColor = True
        '
        'ChkSocial
        '
        Me.ChkSocial.AutoSize = True
        Me.ChkSocial.Location = New System.Drawing.Point(14, 44)
        Me.ChkSocial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkSocial.Name = "ChkSocial"
        Me.ChkSocial.Size = New System.Drawing.Size(56, 19)
        Me.ChkSocial.TabIndex = 26
        Me.ChkSocial.Text = "Sosial"
        Me.ChkSocial.UseVisualStyleBackColor = True
        '
        'ChkSains
        '
        Me.ChkSains.AutoSize = True
        Me.ChkSains.Location = New System.Drawing.Point(14, 20)
        Me.ChkSains.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkSains.Name = "ChkSains"
        Me.ChkSains.Size = New System.Drawing.Size(53, 19)
        Me.ChkSains.TabIndex = 25
        Me.ChkSains.Text = "Sains"
        Me.ChkSains.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(242, 644)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(160, 29)
        Me.BtnUpdate.TabIndex = 71
        Me.BtnUpdate.Text = "Tambah Koleksi"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(205, 494)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(51, 15)
        Me.LblKategori.TabIndex = 70
        Me.LblKategori.Text = "Kategori"
        '
        'OpenImageKoleksi
        '
        Me.OpenImageKoleksi.FileName = "OpenImageKoleksi"
        '
        'updateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 702)
        Me.Controls.Add(Me.GBKategori)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.GBBahasa)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.DateMasukKoleksi)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.RtxDeskripsi)
        Me.Controls.Add(Me.CbJenisKoleksi)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.LblTanggalMasuk)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.BtnUpdateGambar)
        Me.Controls.Add(Me.PictKoleksi)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "updateKoleksi"
        Me.Text = "updateKoleksi"
        Me.GBBahasa.ResumeLayout(False)
        Me.GBBahasa.PerformLayout()
        CType(Me.PictKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBKategori.ResumeLayout(False)
        Me.GBKategori.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBBahasa As GroupBox
    Friend WithEvents RbInggris As RadioButton
    Friend WithEvents RbIndonesia As RadioButton
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents DateMasukKoleksi As DateTimePicker
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents RtxDeskripsi As RichTextBox
    Friend WithEvents CbJenisKoleksi As ComboBox
    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents LblTanggalMasuk As Label
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents BtnUpdateGambar As Button
    Friend WithEvents PictKoleksi As PictureBox
    Friend WithEvents LblJudul As Label
    Friend WithEvents GBKategori As GroupBox
    Friend WithEvents ChkBudaya As CheckBox
    Friend WithEvents ChkTeknologi As CheckBox
    Friend WithEvents ChkSocial As CheckBox
    Friend WithEvents ChkSains As CheckBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents LblKategori As Label
    Friend WithEvents OpenImageKoleksi As OpenFileDialog
End Class
