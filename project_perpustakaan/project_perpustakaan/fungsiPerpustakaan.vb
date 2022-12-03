Public Class fungsiPerpustakaan

    Private foto As String
    Private nama As String
    Private jenis
    Private deskripsi
    Private penerbit As String
    Private tahun_terbit As String
    Private lokasi_rak As String
    Private tanggal_masuk
    Private stok As String
    Private bahasa As String
    Private kategori_list As New List(Of String)

    '==================[ Getter & Setter ]=====================
    Public Property GSfoto() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property

    Public Property GSnama() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property GSJenis() As String
        Get
            Return jenis
        End Get
        Set(ByVal value As String)
            jenis = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahun() As String
        Get
            Return tahun_terbit
        End Get
        Set(ByVal value As String)
            tahun_terbit = value
        End Set
    End Property

    Public Property GSTanggal() As String
        Get
            Return tanggal_masuk
        End Get
        Set(ByVal value As String)
            tanggal_masuk = value
        End Set
    End Property

    Public Property GSLokasi() As String
        Get
            Return lokasi_rak
        End Get
        Set(ByVal value As String)
            lokasi_rak = value
        End Set
    End Property

    Public Property GSStok() As String
        Get
            Return stok
        End Get
        Set(ByVal value As String)
            stok = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategori()
        Get
            Return kategori_list
        End Get
        Set(ByVal value)
            kategori_list = value
        End Set
    End Property
End Class