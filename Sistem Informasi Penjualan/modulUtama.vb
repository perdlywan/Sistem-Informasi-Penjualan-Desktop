Imports MySql.Data.MySqlClient
Module modulUtama
    Public StrSQL As String
    Public StrCn As String
    Public VServer As String
    Public VUser As String
    Public VPass As String
    Public VDatabase As String

    Public cn As New MySqlConnection
    Public dAdapter As MySqlDataAdapter
    Public RdData As MySqlDataReader
    Public dSet As DataSet
    Public Status As Boolean
    Public vAdmin As String
    Public Brs As Integer
    Public StatReport As Byte
End Module
