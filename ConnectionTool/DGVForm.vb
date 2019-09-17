Public Class DGVForm
    Private CTool As New ConnectionTool

#Region "###Form1からの情報受け取り###"

    Private DBType As String = Form1.CBox1.Text
    Private DSname As String = Form1.FileNameBox.Text
    Private DSpass As String = Form1.PassWordBox.Text
    Private ServerName As String = Form1.ServerNameBox.Text
    Private DBName As String = Form1.DBNameBox.Text
    Private UserID As String = Form1.UserIDBox.Text
    Private UserPass As String = Form1.UserPassBox.Text

#End Region

    'ログボックスに書き出し
    Private Sub LogMemo(ByVal iStr As String)
        LogBox.AppendText(iStr & vbCrLf)
    End Sub

    'LoadイベントでDBを読込。コンボボックスにリストを作る
    Private Sub DGVForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If DBType = "Microsoft Access" Then
                Access_Init()
            ElseIf DBType = "SQLServer" Then
                SQL_Init()
            End If
        Catch ex As Exception
            LogMemo(Err.Description)
        End Try
    End Sub

    '[読込]ボタンクリック。コンボボックスからテーブル名を取得し、DGVにバインドする
    Private Sub Read_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        Dim Tablename As String = TableListBox.Text
        Dim resultCode As Integer

        If DBType = "Microsoft Access" Then
            resultCode = CTool.MdbOpen(DSname, DSpass, Tablename, DGV)
        ElseIf DBType = "SQLServer" Then
            resultCode = CTool.SQLOpen(ServerName, DBName, UserID, UserPass, Tablename, DGV)
        End If

        Try
            If resultCode = 1 Then
                LogMemo("DBOpen完了")
            Else
                LogMemo("エラーが発生しました。(" & resultCode & ")")
            End If
        Catch ex As Exception
            LogMemo(Err.Description)
        End Try
    End Sub

    '[更新]ボタンをクリック。注意メッセージを表示し、更新に進む
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim Tablename As String = TableListBox.Text
        Dim resultCode As Integer

        Try
            If MsgBox("現在の内容で更新します。(更新前の状態には戻せません。)" & vbCrLf & "よろしいですか？", vbYesNo) = 7 Then
                LogMemo("更新を中止しました。")
                Exit Sub
            Else
                If DBType = "Microsoft Access" Then
                    resultCode = CTool.Mdb_Submit(DSname, DSpass, Tablename)
                ElseIf DBType = "SQLServer" Then
                    resultCode = CTool.SQL_Submit(ServerName, DBName, UserID, UserPass, Tablename)
                End If
                If resultCode = 1 Then
                    LogMemo("更新しました。")
                Else
                    LogMemo("エラーが発生しました。(" & resultCode & ")")
                End If
                End If
        Catch ex As Exception
            LogMemo(Err.Description)
        End Try
    End Sub

    '[更新][行削除]ボタンの有効/無効
    Private Sub DGV_DataSourceChanged(sender As Object, e As EventArgs) Handles DGV.DataSourceChanged
        If DGV.DataSource IsNot Nothing Then
            BtnUpdate.Enabled = True
            BtnDelete.Enabled = True
        Else
            BtnUpdate.Enabled = False
            BtnDelete.Enabled = False
        End If
    End Sub

    '[行削除]ボタンクリック。DGVで選択中の行を削除する
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DGV.Rows.Remove(DGV.CurrentRow)
    End Sub

    '初期読込(Access)
    Private Sub Access_Init()
        Me.Text = DSname
        Dim resultCode As Integer = CTool.Mdb_MakeTableList(DSname, DSpass, TableListBox)

        Try
            If resultCode = 1 Then
                LogMemo("テーブルリスト読込完了")
            Else
                LogMemo("エラーが発生しました。(" & resultCode & ")")
                MsgBox("エラーが発生しました。(" & resultCode & ")" & vbCrLf &
                                            "初めの画面から入力内容を確認してください。")
            End If
        Catch ex As Exception
            LogMemo(Err.Description)
        End Try
    End Sub

    '初期読込(SQL Server)
    Private Sub SQL_Init()
        Me.Text = ServerName & "--" & DBName
        Dim resultCode As Integer = CTool.SQL_MakeTableList(ServerName, DBName, UserID, UserPass, TableListBox)

        Try
            If resultCode = 1 Then
                LogMemo("テーブルリスト読込完了")
            Else
                LogMemo("エラーが発生しました。(" & resultCode & ")")
                MsgBox("エラーが発生しました。(" & resultCode & ")" & vbCrLf &
                                            "初めの画面から入力内容を確認してください。")
            End If
        Catch ex As Exception
            LogMemo(Err.Description)
        End Try
    End Sub

End Class