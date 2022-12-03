<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahKoleksi
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
        Me.GBKategori = New System.Windows.Forms.GroupBox()
        Me.chkBudaya = New System.Windows.Forms.CheckBox()
        Me.chkTeknologi = New System.Windows.Forms.CheckBox()
        Me.chkSosial = New System.Windows.Forms.CheckBox()
        Me.chkSains = New System.Windows.Forms.CheckBox()
        Me.GBBahasa = New System.Windows.Forms.GroupBox()
        Me.RBInggris = New System.Windows.Forms.RadioButton()
        Me.RBIndonesia = New System.Windows.Forms.RadioButton()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.DateMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TxtLokasirRak = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.RTBDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CBJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TxtNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.LblTanggalMasuk = New System.Windows.Forms.Label()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.PictKoleksi = New System.Windows.Forms.PictureBox()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.OpenImageKoleksi = New System.Windows.Forms.OpenFileDialog()
        Me.GBKategori.SuspendLayout()
        Me.GBBahasa.SuspendLayout()
        CType(Me.PictKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBKategori
        '
        Me.GBKategori.Controls.Add(Me.chkBudaya)
        Me.GBKategori.Controls.Add(Me.chkTeknologi)
        Me.GBKategori.Controls.Add(Me.chkSosial)
        Me.GBKategori.Controls.Add(Me.chkSains)
        Me.GBKategori.Location = New System.Drawing.Point(380, 477)
        Me.GBKategori.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBKategori.Name = "GBKategori"
        Me.GBKategori.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBKategori.Size = New System.Drawing.Size(256, 120)
        Me.GBKategori.TabIndex = 49
        Me.GBKategori.TabStop = False
        Me.GBKategori.Text = "Kategori"
        '
        'chkBudaya
        '
        Me.chkBudaya.AutoSize = True
        Me.chkBudaya.Location = New System.Drawing.Point(14, 92)
        Me.chkBudaya.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkBudaya.Name = "chkBudaya"
        Me.chkBudaya.Size = New System.Drawing.Size(65, 19)
        Me.chkBudaya.TabIndex = 28
        Me.chkBudaya.Text = "Budaya"
        Me.chkBudaya.UseVisualStyleBackColor = True
        '
        'chkTeknologi
        '
        Me.chkTeknologi.AutoSize = True
        Me.chkTeknologi.Location = New System.Drawing.Point(14, 69)
        Me.chkTeknologi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkTeknologi.Name = "chkTeknologi"
        Me.chkTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.chkTeknologi.TabIndex = 27
        Me.chkTeknologi.Text = "Teknologi"
        Me.chkTeknologi.UseVisualStyleBackColor = True
        '
        'chkSosial
        '
        Me.chkSosial.AutoSize = True
        Me.chkSosial.Location = New System.Drawing.Point(14, 45)
        Me.chkSosial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSosial.Name = "chkSosial"
        Me.chkSosial.Size = New System.Drawing.Size(56, 19)
        Me.chkSosial.TabIndex = 26
        Me.chkSosial.Text = "Sosial"
        Me.chkSosial.UseVisualStyleBackColor = True
        '
        'chkSains
        '
        Me.chkSains.AutoSize = True
        Me.chkSains.Location = New System.Drawing.Point(14, 21)
        Me.chkSains.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkSains.Name = "chkSains"
        Me.chkSains.Size = New System.Drawing.Size(53, 19)
        Me.chkSains.TabIndex = 25
        Me.chkSains.Text = "Sains"
        Me.chkSains.UseVisualStyleBackColor = True
        '
        'GBBahasa
        '
        Me.GBBahasa.Controls.Add(Me.RBInggris)
        Me.GBBahasa.Controls.Add(Me.RBIndonesia)
        Me.GBBahasa.Location = New System.Drawing.Point(380, 393)
        Me.GBBahasa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBBahasa.Name = "GBBahasa"
        Me.GBBahasa.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GBBahasa.Size = New System.Drawing.Size(256, 75)
        Me.GBBahasa.TabIndex = 48
        Me.GBBahasa.TabStop = False
        Me.GBBahasa.Text = "Bahasa"
        '
        'RBInggris
        '
        Me.RBInggris.AutoSize = True
        Me.RBInggris.Location = New System.Drawing.Point(14, 44)
        Me.RBInggris.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBInggris.Name = "RBInggris"
        Me.RBInggris.Size = New System.Drawing.Size(101, 19)
        Me.RBInggris.TabIndex = 24
        Me.RBInggris.TabStop = True
        Me.RBInggris.Text = "Bahasa Inggris"
        Me.RBInggris.UseVisualStyleBackColor = True
        '
        'RBIndonesia
        '
        Me.RBIndonesia.AutoSize = True
        Me.RBIndonesia.Location = New System.Drawing.Point(14, 19)
        Me.RBIndonesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBIndonesia.Name = "RBIndonesia"
        Me.RBIndonesia.Size = New System.Drawing.Size(116, 19)
        Me.RBIndonesia.TabIndex = 23
        Me.RBIndonesia.TabStop = True
        Me.RBIndonesia.Text = "Bahasa Indonesia"
        Me.RBIndonesia.UseVisualStyleBackColor = True
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(380, 363)
        Me.TxtStok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(257, 23)
        Me.TxtStok.TabIndex = 47
        '
        'DateMasukKoleksi
        '
        Me.DateMasukKoleksi.CustomFormat = "dddd, MMMM d, yyyy"
        Me.DateMasukKoleksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateMasukKoleksi.Location = New System.Drawing.Point(380, 330)
        Me.DateMasukKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateMasukKoleksi.Name = "DateMasukKoleksi"
        Me.DateMasukKoleksi.Size = New System.Drawing.Size(257, 23)
        Me.DateMasukKoleksi.TabIndex = 23
        '
        'TxtLokasirRak
        '
        Me.TxtLokasirRak.Location = New System.Drawing.Point(380, 298)
        Me.TxtLokasirRak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtLokasirRak.Name = "TxtLokasirRak"
        Me.TxtLokasirRak.Size = New System.Drawing.Size(257, 23)
        Me.TxtLokasirRak.TabIndex = 45
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(380, 266)
        Me.TxtTahunTerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(257, 23)
        Me.TxtTahunTerbit.TabIndex = 44
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(380, 235)
        Me.TxtPenerbit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(257, 23)
        Me.TxtPenerbit.TabIndex = 43
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(380, 115)
        Me.RTBDeskripsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(257, 108)
        Me.RTBDeskripsi.TabIndex = 42
        Me.RTBDeskripsi.Text = ""
        '
        'CBJenisKoleksi
        '
        Me.CBJenisKoleksi.FormattingEnabled = True
        Me.CBJenisKoleksi.Location = New System.Drawing.Point(380, 80)
        Me.CBJenisKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBJenisKoleksi.Name = "CBJenisKoleksi"
        Me.CBJenisKoleksi.Size = New System.Drawing.Size(257, 23)
        Me.CBJenisKoleksi.TabIndex = 41
        '
        'TxtNamaKoleksi
        '
        Me.TxtNamaKoleksi.Location = New System.Drawing.Point(380, 48)
        Me.TxtNamaKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNamaKoleksi.Name = "TxtNamaKoleksi"
        Me.TxtNamaKoleksi.Size = New System.Drawing.Size(257, 23)
        Me.TxtNamaKoleksi.TabIndex = 40
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(245, 631)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(160, 29)
        Me.btnTambah.TabIndex = 39
        Me.btnTambah.Text = "Tambah Koleksi"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(221, 481)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(51, 15)
        Me.LblKategori.TabIndex = 38
        Me.LblKategori.Text = "Kategori"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(221, 398)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(44, 15)
        Me.LblBahasa.TabIndex = 37
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Location = New System.Drawing.Point(221, 366)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(36, 15)
        Me.LblStok.TabIndex = 36
        Me.LblStok.Text = "Stock"
        '
        'LblTanggalMasuk
        '
        Me.LblTanggalMasuk.AutoSize = True
        Me.LblTanggalMasuk.Location = New System.Drawing.Point(221, 335)
        Me.LblTanggalMasuk.Name = "LblTanggalMasuk"
        Me.LblTanggalMasuk.Size = New System.Drawing.Size(126, 15)
        Me.LblTanggalMasuk.TabIndex = 35
        Me.LblTanggalMasuk.Text = "Tanggal Masuk Koleksi"
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Location = New System.Drawing.Point(221, 302)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(62, 15)
        Me.LblLokasiRak.TabIndex = 34
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(221, 269)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(71, 15)
        Me.LblTahunTerbit.TabIndex = 33
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(221, 238)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(51, 15)
        Me.LblPenerbit.TabIndex = 32
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(221, 116)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(54, 15)
        Me.LblDeskripsi.TabIndex = 31
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(221, 83)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(72, 15)
        Me.LblJenisKoleksi.TabIndex = 30
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(221, 51)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(79, 15)
        Me.LblNamaKoleksi.TabIndex = 29
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(26, 235)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(174, 24)
        Me.BtnTambahGambar.TabIndex = 28
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'PictKoleksi
        '
        Me.PictKoleksi.Location = New System.Drawing.Point(26, 51)
        Me.PictKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictKoleksi.Name = "PictKoleksi"
        Me.PictKoleksi.Size = New System.Drawing.Size(174, 173)
        Me.PictKoleksi.TabIndex = 27
        Me.PictKoleksi.TabStop = False
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJudul.Location = New System.Drawing.Point(26, 9)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(174, 30)
        Me.LblJudul.TabIndex = 26
        Me.LblJudul.Text = "Tambah Koleksi"
        '
        'OpenImageKoleksi
        '
        Me.OpenImageKoleksi.FileName = "OpenImageKoleksi"
        '
        'tambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 671)
        Me.Controls.Add(Me.GBKategori)
        Me.Controls.Add(Me.GBBahasa)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.DateMasukKoleksi)
        Me.Controls.Add(Me.TxtLokasirRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.RTBDeskripsi)
        Me.Controls.Add(Me.CBJenisKoleksi)
        Me.Controls.Add(Me.TxtNamaKoleksi)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStok)
        Me.Controls.Add(Me.LblTanggalMasuk)
        Me.Controls.Add(Me.LblLokasiRak)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.PictKoleksi)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "tambahKoleksi"
        Me.Text = "Tambah Koleksi"
        Me.GBKategori.ResumeLayout(False)
        Me.GBKategori.PerformLayout()
        Me.GBBahasa.ResumeLayout(False)
        Me.GBBahasa.PerformLayout()
        CType(Me.PictKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBKategori As GroupBox
    Friend WithEvents chkBudaya As CheckBox
    Friend WithEvents chkTeknologi As CheckBox
    Friend WithEvents chkSosial As CheckBox
    Friend WithEvents chkSains As CheckBox
    Friend WithEvents GBBahasa As GroupBox
    Friend WithEvents RBInggris As RadioButton
    Friend WithEvents RBIndonesia As RadioButton
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents DateMasukKoleksi As DateTimePicker
    Friend WithEvents TxtLokasirRak As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents RTBDeskripsi As RichTextBox
    Friend WithEvents CBJenisKoleksi As ComboBox
    Friend WithEvents TxtNamaKoleksi As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents LblKategori As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents LblTanggalMasuk As Label
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents PictKoleksi As PictureBox
    Friend WithEvents LblJudul As Label
    Friend WithEvents OpenImageKoleksi As OpenFileDialog
End Class
