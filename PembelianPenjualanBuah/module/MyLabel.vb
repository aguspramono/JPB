Public Class MyLabel
    Inherits Label

    Private _IndexButton As Integer = 0
    Private _Width2 As Integer = 0
    Private _Height2 As Integer = 0
    Private _NumberOfSides As Integer = 0
    Private _OffsetAngleInDegrees As Double = 0
    Private _IndexKebun As Integer = 0
    Private _IndexKebunS As String = ""


    ' <param name="myQuery">select*from customer where NoAccount=@NoAccount kalo pake like WHERE (body LIKE '%' + @query + '%')</param>
    ' <param name="namaKolom">Nama Kolom </param>
    ' <param name="isiKolom">Isi Kolom</param>
    ' <param name="opt">Isi 1 kalo mau pake kolom</param>
    ''' <summary>
    ''' Width ke 2
    ''' </summary>
    ''' 
    Public Property Width2() As Integer
        Get
            Return _Width2
        End Get
        Set(ByVal value As Integer)
            _Width2 = value
        End Set
    End Property

    ''' <summary>
    ''' Height ke 2
    ''' </summary>
    ''' 
    Public Property Height2() As Integer
        Get
            Return _Height2
        End Get
        Set(ByVal value As Integer)
            _Height2 = value
        End Set
    End Property

    ''' <summary>
    ''' NumberOfSides
    ''' </summary>
    ''' 
    Public Property NumberOfSides() As Integer
        Get
            Return _NumberOfSides
        End Get
        Set(ByVal value As Integer)
            _NumberOfSides = value
        End Set
    End Property

    ''' <summary>
    ''' Height ke 2
    ''' </summary>
    ''' 
    Public Property OffsetAngleInDegrees() As Double
        Get
            Return _OffsetAngleInDegrees
        End Get
        Set(ByVal value As Double)
            _OffsetAngleInDegrees = value
        End Set
    End Property

    ''' <summary>
    ''' IndexKebun
    ''' </summary>
    ''' 
    Public Property IndexKebun() As Integer
        Get
            Return _IndexKebun
        End Get
        Set(ByVal value As Integer)
            _IndexKebun = value
        End Set
    End Property

    ''' <summary>
    ''' IndexKebun String
    ''' </summary>
    ''' 
    Public Property IndexKebunS() As String
        Get
            Return _IndexKebunS
        End Get
        Set(ByVal value As String)
            _IndexKebunS = value
        End Set
    End Property



    ''' <summary>
    ''' IndexButton Integer
    ''' </summary>
    ''' 
    Public Property IndexButton() As Integer
        Get
            Return _IndexButton
        End Get
        Set(ByVal value As Integer)
            _IndexButton = value
        End Set
    End Property
End Class
