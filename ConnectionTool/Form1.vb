Public Class Form1
    Private CTool As New ConnectionTool

    'Shownイベントでラジオボタン１選択を初期値にする
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RadioButton1.Checked = True
    End Sub

    'Accessグループ参照ボタンクリック(ファイルを選択ダイアログの表示)
    Private Sub Reference_Click(sender As Object, e As EventArgs) Handles Reference.Click
        Try
            'OpenFileDialogクラスのインスタンスを作成
            Dim openFileDialog As New OpenFileDialog()

            'はじめに「ファイル名」で表示される文字列を指定する
            'ofd.FileName = "default.html"
            openFileDialog.InitialDirectory = "C:\"
            openFileDialog.Filter = "Microsoft Access データベース(*.mdb)|*.mdb|すべてのファイル(*.*)|*.*"
            '2番目の「すべてのファイル」が選択されているようにする
            'ofd.FilterIndex = 2
            openFileDialog.Title = "開くファイルを選択してください"
            openFileDialog.RestoreDirectory = True

            'ダイアログを表示する
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                'OKボタンがクリックされたとき、選択されたファイル名を表示する
                FileNameBox.Text = openFileDialog.FileName
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    'データ形式選択（表示するグループの選択）
    Private Sub CBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBox1.SelectedIndexChanged
        Try
            If CBox1.SelectedIndex = 0 Then
                GroupBox1.Visible = True
                GroupBox2.Visible = False
            ElseIf CBox1.SelectedIndex = 1 Then
                GroupBox1.Visible = False
                GroupBox2.Visible = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    'パスワード有無([対象を開く]ボタンの表示)
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Try
            If RadioButton1.Checked = True Then
                PassWordBox.Enabled = True
                mdbOpen.Enabled = False
            Else
                PassWordBox.Enabled = False
                PassWordBox.Text = ""
                mdbOpen.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    'パスワードテキスト変更([対象を開く]ボタンの表示)
    Private Sub PassWordBox_TextChanged(sender As Object, e As EventArgs) Handles PassWordBox.TextChanged
        Try
            If PassWordBox.Text = "" Then
                mdbOpen.Enabled = False
            Else
                mdbOpen.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(vbCrLf & Err.Description)
        End Try
    End Sub

    'Accessグループ[対象を開く]ボタンクリック(Open)
    Private Sub MdbOpen_Click(sender As Object, e As EventArgs) Handles mdbOpen.Click
        Try
            DGVForm.Show()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    'SQLグループ[対象を開く]ボタンクリック(Open)
    Private Sub SQLOpen_Click(sender As Object, e As EventArgs) Handles SQLOpen.Click
        Try
            DGVForm.Show()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class
