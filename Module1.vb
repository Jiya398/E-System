Imports MySql.Data.MySqlClient

Module Module1
    Public con As New MySqlConnection("Server= localhost; User Id= root; Password =1234; database= finalenroll; Port=3306;  SslMode=None;")
    Public cmd As New MySqlCommand()
    Public da As New MySqlDataAdapter()
    Public dt As New DataTable()

    'Sub openCon()
    'con.ConnectionString = "server=localhost; username=root; password=; database= finalenroll"

    'con.Open()
    'End Sub

End Module
