<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoTambahKoleksi
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
        Me.PBGambarKoleksi = New System.Windows.Forms.PictureBox()
        Me.LblJudul = New System.Windows.Forms.Label()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.LblLokasiRak = New System.Windows.Forms.Label()
        Me.LblTanggalMasuk = New System.Windows.Forms.Label()
        Me.LblStok = New System.Windows.Forms.Label()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.valueBahasa = New System.Windows.Forms.Label()
        Me.valueStok = New System.Windows.Forms.Label()
        Me.valueTanggalMasuk = New System.Windows.Forms.Label()
        Me.valueLokasiRak = New System.Windows.Forms.Label()
        Me.valueTahunTerbit = New System.Windows.Forms.Label()
        Me.valuePenerbit = New System.Windows.Forms.Label()
        Me.valueDeskripsi = New System.Windows.Forms.Label()
        Me.valueJenis = New System.Windows.Forms.Label()
        Me.valueNama = New System.Windows.Forms.Label()
        Me.LBKategori = New System.Windows.Forms.ListBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.PBGambarKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBGambarKoleksi
        '
        Me.PBGambarKoleksi.Location = New System.Drawing.Point(27, 67)
        Me.PBGambarKoleksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBGambarKoleksi.Name = "PBGambarKoleksi"
        Me.PBGambarKoleksi.Size = New System.Drawing.Size(155, 173)
        Me.PBGambarKoleksi.TabIndex = 51
        Me.PBGambarKoleksi.TabStop = False
        '
        'LblJudul
        '
        Me.LblJudul.AutoSize = True
        Me.LblJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJudul.Location = New System.Drawing.Point(249, 9)
        Me.LblJudul.Name = "LblJudul"
        Me.LblJudul.Size = New System.Drawing.Size(133, 30)
        Me.LblJudul.TabIndex = 50
        Me.LblJudul.Text = "Info Koleksi"
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(222, 67)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(79, 15)
        Me.LblNamaKoleksi.TabIndex = 53
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(222, 99)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(72, 15)
        Me.LblJenisKoleksi.TabIndex = 54
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(222, 132)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(54, 15)
        Me.LblDeskripsi.TabIndex = 55
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(222, 225)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(51, 15)
        Me.LblPenerbit.TabIndex = 56
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(222, 256)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(71, 15)
        Me.LblTahunTerbit.TabIndex = 57
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'LblLokasiRak
        '
        Me.LblLokasiRak.AutoSize = True
        Me.LblLokasiRak.Location = New System.Drawing.Point(222, 289)
        Me.LblLokasiRak.Name = "LblLokasiRak"
        Me.LblLokasiRak.Size = New System.Drawing.Size(62, 15)
        Me.LblLokasiRak.TabIndex = 58
        Me.LblLokasiRak.Text = "Lokasi Rak"
        '
        'LblTanggalMasuk
        '
        Me.LblTanggalMasuk.AutoSize = True
        Me.LblTanggalMasuk.Location = New System.Drawing.Point(222, 322)
        Me.LblTanggalMasuk.Name = "LblTanggalMasuk"
        Me.LblTanggalMasuk.Size = New System.Drawing.Size(126, 15)
        Me.LblTanggalMasuk.TabIndex = 59
        Me.LblTanggalMasuk.Text = "Tanggal Masuk Koleksi"
        '
        'LblStok
        '
        Me.LblStok.AutoSize = True
        Me.LblStok.Location = New System.Drawing.Point(222, 353)
        Me.LblStok.Name = "LblStok"
        Me.LblStok.Size = New System.Drawing.Size(36, 15)
        Me.LblStok.TabIndex = 60
        Me.LblStok.Text = "Stock"
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(222, 385)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(44, 15)
        Me.LblBahasa.TabIndex = 61
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(222, 422)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(51, 15)
        Me.LblKategori.TabIndex = 62
        Me.LblKategori.Text = "Kategori"
        '
        'valueBahasa
        '
        Me.valueBahasa.AutoSize = True
        Me.valueBahasa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueBahasa.Location = New System.Drawing.Point(402, 385)
        Me.valueBahasa.Name = "valueBahasa"
        Me.valueBahasa.Size = New System.Drawing.Size(53, 15)
        Me.valueBahasa.TabIndex = 71
        Me.valueBahasa.Text = "(Bahasa)"
        '
        'valueStok
        '
        Me.valueStok.AutoSize = True
        Me.valueStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueStok.Location = New System.Drawing.Point(402, 353)
        Me.valueStok.Name = "valueStok"
        Me.valueStok.Size = New System.Drawing.Size(47, 15)
        Me.valueStok.TabIndex = 70
        Me.valueStok.Text = "(Stock)"
        '
        'valueTanggalMasuk
        '
        Me.valueTanggalMasuk.AutoSize = True
        Me.valueTanggalMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueTanggalMasuk.Location = New System.Drawing.Point(402, 322)
        Me.valueTanggalMasuk.Name = "valueTanggalMasuk"
        Me.valueTanggalMasuk.Size = New System.Drawing.Size(139, 15)
        Me.valueTanggalMasuk.TabIndex = 69
        Me.valueTanggalMasuk.Text = "(Tanggal Masuk Koleksi)"
        '
        'valueLokasiRak
        '
        Me.valueLokasiRak.AutoSize = True
        Me.valueLokasiRak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueLokasiRak.Location = New System.Drawing.Point(402, 289)
        Me.valueLokasiRak.Name = "valueLokasiRak"
        Me.valueLokasiRak.Size = New System.Drawing.Size(73, 15)
        Me.valueLokasiRak.TabIndex = 68
        Me.valueLokasiRak.Text = "(Lokasi Rak)"
        '
        'valueTahunTerbit
        '
        Me.valueTahunTerbit.AutoSize = True
        Me.valueTahunTerbit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueTahunTerbit.Location = New System.Drawing.Point(402, 256)
        Me.valueTahunTerbit.Name = "valueTahunTerbit"
        Me.valueTahunTerbit.Size = New System.Drawing.Size(84, 15)
        Me.valueTahunTerbit.TabIndex = 67
        Me.valueTahunTerbit.Text = "(Tahun Terbit)"
        '
        'valuePenerbit
        '
        Me.valuePenerbit.AutoSize = True
        Me.valuePenerbit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valuePenerbit.Location = New System.Drawing.Point(402, 225)
        Me.valuePenerbit.Name = "valuePenerbit"
        Me.valuePenerbit.Size = New System.Drawing.Size(63, 15)
        Me.valuePenerbit.TabIndex = 66
        Me.valuePenerbit.Text = "(Penerbit)"
        '
        'valueDeskripsi
        '
        Me.valueDeskripsi.AutoSize = True
        Me.valueDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueDeskripsi.Location = New System.Drawing.Point(402, 132)
        Me.valueDeskripsi.Name = "valueDeskripsi"
        Me.valueDeskripsi.Size = New System.Drawing.Size(66, 15)
        Me.valueDeskripsi.TabIndex = 65
        Me.valueDeskripsi.Text = "(Deskripsi)"
        '
        'valueJenis
        '
        Me.valueJenis.AutoSize = True
        Me.valueJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueJenis.Location = New System.Drawing.Point(402, 99)
        Me.valueJenis.Name = "valueJenis"
        Me.valueJenis.Size = New System.Drawing.Size(85, 15)
        Me.valueJenis.TabIndex = 64
        Me.valueJenis.Text = "(Jenis Koleksi)"
        '
        'valueNama
        '
        Me.valueNama.AutoSize = True
        Me.valueNama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.valueNama.Location = New System.Drawing.Point(402, 67)
        Me.valueNama.Name = "valueNama"
        Me.valueNama.Size = New System.Drawing.Size(90, 15)
        Me.valueNama.TabIndex = 63
        Me.valueNama.Text = "(Nama Koleksi)"
        '
        'LBKategori
        '
        Me.LBKategori.FormattingEnabled = True
        Me.LBKategori.ItemHeight = 15
        Me.LBKategori.Location = New System.Drawing.Point(402, 422)
        Me.LBKategori.Name = "LBKategori"
        Me.LBKategori.Size = New System.Drawing.Size(215, 94)
        Me.LBKategori.TabIndex = 72
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(285, 552)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 73
        Me.BtnClose.Text = "Tutup"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'infoTambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 587)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LBKategori)
        Me.Controls.Add(Me.valueBahasa)
        Me.Controls.Add(Me.valueStok)
        Me.Controls.Add(Me.valueTanggalMasuk)
        Me.Controls.Add(Me.valueLokasiRak)
        Me.Controls.Add(Me.valueTahunTerbit)
        Me.Controls.Add(Me.valuePenerbit)
        Me.Controls.Add(Me.valueDeskripsi)
        Me.Controls.Add(Me.valueJenis)
        Me.Controls.Add(Me.valueNama)
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
        Me.Controls.Add(Me.PBGambarKoleksi)
        Me.Controls.Add(Me.LblJudul)
        Me.Name = "infoTambahKoleksi"
        Me.Text = "infoTambahKoleksi"
        CType(Me.PBGambarKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBGambarKoleksi As PictureBox
    Friend WithEvents LblJudul As Label
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents LblLokasiRak As Label
    Friend WithEvents LblTanggalMasuk As Label
    Friend WithEvents LblStok As Label
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblKategori As Label
    Friend WithEvents valueBahasa As Label
    Friend WithEvents valueStok As Label
    Friend WithEvents valueTanggalMasuk As Label
    Friend WithEvents valueLokasiRak As Label
    Friend WithEvents valueTahunTerbit As Label
    Friend WithEvents valuePenerbit As Label
    Friend WithEvents valueDeskripsi As Label
    Friend WithEvents valueJenis As Label
    Friend WithEvents valueNama As Label
    Friend WithEvents LBKategori As ListBox
    Friend WithEvents BtnClose As Button
End Class
