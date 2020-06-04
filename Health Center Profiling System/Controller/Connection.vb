Imports MySql.Data.MySqlClient
Module Connection
    Public connect As New MySqlConnection
    Public reader As MySqlDataReader
    Public command As New MySqlCommand
    Public Adapter As New MySqlDataAdapter
    Private Transaction As MySqlTransaction

    Public Sub dbConnect()
        If connect.State = ConnectionState.Open Then
            dbDisconnect()
        End If
        connect.ConnectionString = "Server=" & My.Settings.ServerIP & ";Database=" & My.Settings.DatabaseName & ";User=" & My.Settings.Username _
                                              & ";Password=" & My.Settings.Password & ";"
        connect.Open()
    End Sub

    Public Sub dbDisconnect()
        reader.Close()
        connect.Dispose()
    End Sub

    Public Sub ExecuteQuery(query As String)

        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader

    End Sub
    Public Sub ExecuteQueryParameter(query As String)
        command = New MySqlCommand(query, connect)
    End Sub

    Public Sub disposeConnection()
        connect.Close()
    End Sub
    Public Function RetrieveDataTable(ByVal query As String) As System.Data.DataTable
        Dim dataTable As New System.Data.DataTable()
        Try
            connect.Open()
            Dim Adapter As New MySqlDataAdapter(query, connect)
            Adapter.Fill(dataTable)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally

            If connect.State = System.Data.ConnectionState.Open Then
                connect.Close()
            End If
        End Try

        Return (dataTable)
    End Function
    Public Function TestConnection(str As String) As Boolean
        Try
            If connect.State = ConnectionState.Open Then
                disposeConnection()
            End If
            connect.ConnectionString = str
            connect.Open()
            Transaction = connect.BeginTransaction
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
