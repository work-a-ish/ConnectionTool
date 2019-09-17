<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileNameBox = New System.Windows.Forms.TextBox()
        Me.PassWordBox = New System.Windows.Forms.TextBox()
        Me.Reference = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mdbOpen = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UserPassBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UserIDBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SQLOpen = New System.Windows.Forms.Button()
        Me.DBNameBox = New System.Windows.Forms.TextBox()
        Me.ServerNameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "対象データ："
        '
        'CBox1
        '
        Me.CBox1.FormattingEnabled = True
        Me.CBox1.Items.AddRange(New Object() {"Microsoft Access", "SQLServer"})
        Me.CBox1.Location = New System.Drawing.Point(98, 15)
        Me.CBox1.Name = "CBox1"
        Me.CBox1.Size = New System.Drawing.Size(121, 20)
        Me.CBox1.TabIndex = 0
        Me.CBox1.Text = "データ形式を選択"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ファイル名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "パスワード："
        '
        'FileNameBox
        '
        Me.FileNameBox.Location = New System.Drawing.Point(85, 23)
        Me.FileNameBox.Name = "FileNameBox"
        Me.FileNameBox.Size = New System.Drawing.Size(185, 19)
        Me.FileNameBox.TabIndex = 0
        '
        'PassWordBox
        '
        Me.PassWordBox.Location = New System.Drawing.Point(85, 73)
        Me.PassWordBox.Name = "PassWordBox"
        Me.PassWordBox.Size = New System.Drawing.Size(185, 19)
        Me.PassWordBox.TabIndex = 4
        '
        'Reference
        '
        Me.Reference.Location = New System.Drawing.Point(277, 21)
        Me.Reference.Name = "Reference"
        Me.Reference.Size = New System.Drawing.Size(75, 23)
        Me.Reference.TabIndex = 1
        Me.Reference.Text = "参照"
        Me.Reference.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(85, 51)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 16)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "あり"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(133, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(42, 16)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "なし"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mdbOpen)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Reference)
        Me.GroupBox1.Controls.Add(Me.PassWordBox)
        Me.GroupBox1.Controls.Add(Me.FileNameBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 210)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Access接続"
        Me.GroupBox1.Visible = False
        '
        'mdbOpen
        '
        Me.mdbOpen.Location = New System.Drawing.Point(276, 71)
        Me.mdbOpen.Name = "mdbOpen"
        Me.mdbOpen.Size = New System.Drawing.Size(75, 23)
        Me.mdbOpen.TabIndex = 5
        Me.mdbOpen.Text = "対象を開く"
        Me.mdbOpen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UserPassBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.UserIDBox)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.SQLOpen)
        Me.GroupBox2.Controls.Add(Me.DBNameBox)
        Me.GroupBox2.Controls.Add(Me.ServerNameBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 210)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SQL Server接続"
        Me.GroupBox2.Visible = False
        '
        'UserPassBox
        '
        Me.UserPassBox.Location = New System.Drawing.Point(85, 123)
        Me.UserPassBox.Name = "UserPassBox"
        Me.UserPassBox.Size = New System.Drawing.Size(185, 19)
        Me.UserPassBox.TabIndex = 3
        Me.UserPassBox.Text = "ni99"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "パスワード："
        '
        'UserIDBox
        '
        Me.UserIDBox.Location = New System.Drawing.Point(85, 90)
        Me.UserIDBox.Name = "UserIDBox"
        Me.UserIDBox.Size = New System.Drawing.Size(185, 19)
        Me.UserIDBox.TabIndex = 2
        Me.UserIDBox.Text = "ni999"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ユーザーID："
        '
        'SQLOpen
        '
        Me.SQLOpen.Location = New System.Drawing.Point(276, 123)
        Me.SQLOpen.Name = "SQLOpen"
        Me.SQLOpen.Size = New System.Drawing.Size(75, 23)
        Me.SQLOpen.TabIndex = 4
        Me.SQLOpen.Text = "対象を開く"
        Me.SQLOpen.UseVisualStyleBackColor = True
        '
        'DBNameBox
        '
        Me.DBNameBox.Location = New System.Drawing.Point(85, 57)
        Me.DBNameBox.Name = "DBNameBox"
        Me.DBNameBox.Size = New System.Drawing.Size(185, 19)
        Me.DBNameBox.TabIndex = 1
        Me.DBNameBox.Text = "K"
        '
        'ServerNameBox
        '
        Me.ServerNameBox.Location = New System.Drawing.Point(85, 23)
        Me.ServerNameBox.Name = "ServerNameBox"
        Me.ServerNameBox.Size = New System.Drawing.Size(185, 19)
        Me.ServerNameBox.TabIndex = 0
        Me.ServerNameBox.Text = "WIN-FVF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DB名："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "サーバー名："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 273)
        Me.Controls.Add(Me.CBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "データ選択"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FileNameBox As TextBox
    Friend WithEvents PassWordBox As TextBox
    Friend WithEvents Reference As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mdbOpen As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UserPassBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UserIDBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SQLOpen As Button
    Friend WithEvents DBNameBox As TextBox
    Friend WithEvents ServerNameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
