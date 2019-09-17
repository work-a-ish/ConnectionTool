Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ConnectionTool
    Private DS As New DataSet

#Region "###mdb###"

    '該当テーブルを開き、データセットに格納。DGVにバインドする(Access)
    Public Function MdbOpen(ByVal iDSname As String, ByVal iDSpass As String, ByVal iTablename As String, idgv As DataGridView) As Integer
        Try
            Dim strConn As String =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & iDSname & ";Jet OLEDB:Database Password=" & iDSpass & ";"
            Dim cn As New OleDbConnection(strConn)
            Dim cmd As OleDbCommand = cn.CreateCommand
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dgvTable As New DataTable

            cmd.CommandText = "SELECT * FROM [" & iTablename & "]"
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''DSの初期化''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DS.Reset()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            adapter.Fill(DS, "Table01")
            idgv.DataSource = DS.Tables("Table01")
            idgv.CurrentCell = Nothing

            Return 1
        Catch ex As Exception

            Return -100

        End Try

    End Function

    'コンボボックス表示用のテーブル名リストを取得する(Access)
    Public Function Mdb_MakeTableList(ByVal iDSname As String, ByVal iDSpass As String, iCobox As ComboBox) As Integer

        Try
            Dim strConn As String =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & iDSname & ";Jet OLEDB:Database Password=" & iDSpass & ";"
            Dim cn As New OleDbConnection(strConn)
            Dim cmd As OleDbCommand = cn.CreateCommand
            Dim mdbtables As DataTable

            cn.Open()

            '[TABLE]というオブジェクト名だけに限定する
            mdbtables = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                      New Object() {Nothing, Nothing, Nothing, "TABLE"})

            '順番にテーブル名を取得してコンボボックスに追加する
            For i = 0 To mdbtables.Rows.Count - 1
                iCobox.Items.Add(mdbtables.Rows(i)!TABLE_NAME.ToString)
            Next i

            cn.Close()

            Return 1

        Catch ex As Exception
            Return -200
        End Try

    End Function

    'DGVの内容をDBに反映する(OleDbCommandBuilder)
    Public Function Mdb_Submit(ByVal iDSname As String, ByVal iDSpass As String, iTablename As String) As Integer
        Try
            Dim strConn As String =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & iDSname & ";Jet OLEDB:Database Password=" & iDSpass & ";"
            Dim cn As New OleDbConnection(strConn)
            Dim cmd As OleDbCommand = cn.CreateCommand
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dgvTable As New DataTable

            cmd.CommandText = "SELECT * FROM [" & iTablename & "]"

            Dim cmdBuilder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
            adapter.Update(DS.Tables("Table01"))

            cn.Close()

            Return 1
        Catch ex As Exception
            Return -300
        End Try
    End Function

#End Region

#Region "###SQL Server###"

    '該当テーブルを開き、データセットに格納。DGVにバインドする(SQL)
    Public Function SQLOpen(ByVal iServerName As String, ByVal iDBName As String, ByVal iUserID As String, ByVal iUserPass As String,
                                             ByVal iTablename As String, idgv As DataGridView) As Integer
        Try
            Dim strConn As String =
                "Server=" + iServerName + ";Database=" + iDBName + ";User ID=" + iUserID + ";Password=" + iUserPass + ";"
            Dim cn As New SqlConnection(strConn)
            Dim cmd As SqlCommand = cn.CreateCommand
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dgvTable As New DataTable

            cmd.CommandText = "SELECT * FROM [" & iTablename & "]"
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''DSの初期化''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DS.Reset()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            adapter.Fill(DS, "Table01")
            idgv.DataSource = DS.Tables("Table01")
            idgv.CurrentCell = Nothing

            Return 1
        Catch ex As Exception

            Return -100

        End Try

    End Function

    'コンボボックス表示用のテーブル名リストを取得する(SQL)
    Public Function SQL_MakeTableList(ByVal iServerName As String, ByVal iDBName As String, ByVal iUserID As String, ByVal iUserPass As String,
                                                                iCobox As ComboBox) As Integer

        Try
            Dim strConn As String =
                "Server=" + iServerName + ";Database=" + iDBName + ";User ID=" + iUserID + ";Password=" + iUserPass + ";"
            Dim cn As New SqlConnection(strConn)
            Dim cmd As SqlCommand = cn.CreateCommand
            Dim adapter As New SqlDataAdapter(cmd)
            Dim SQLtables As DataTable

            cmd.CommandText = "SELECT name FROM sys.tables"

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''DSの初期化''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DS.Reset()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            adapter.Fill(DS, "Table02")
            SQLtables = DS.Tables("Table02")

            '順番にテーブル名を取得してコンボボックスに追加する
            For i = 0 To SQLtables.Rows.Count - 1
                iCobox.Items.Add(SQLtables.Rows(i).Item(0).ToString)
            Next i

            cn.Close()

            Return 1

        Catch ex As Exception
            Return -201
        End Try

    End Function

    'DGVの内容をDBに反映する(sqlCommandBuilder)
    Public Function SQL_Submit(ByVal iServerName As String, ByVal iDBName As String, ByVal iUserID As String, ByVal iUserPass As String,
                                                    iTablename As String) As Integer
        Try
            Dim strConn As String =
                "Server=" + iServerName + ";Database=" + iDBName + ";User ID=" + iUserID + ";Password=" + iUserPass + ";"
            Dim cn As New SqlConnection(strConn)
            Dim cmd As SqlCommand = cn.CreateCommand
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dgvTable As New DataTable

            cmd.CommandText = "SELECT * FROM [" & iTablename & "]"

            Dim cmdBuilder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
            adapter.Update(DS.Tables("Table01"))

            cn.Close()

            Return 1
        Catch ex As Exception
            Return -300
        End Try
    End Function

#End Region

End Class