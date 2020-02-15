Imports System.Data
Imports System.Data.OleDb

Public Class frmAccess
    Dim strConnect As String
    Dim CNAccess As New OleDbConnection ' соединение для Access
    Dim DASQL As New OleDbDataAdapter
    Dim StrNameBase As String
    Dim nameTbl As String

    ' активация формы
    Private Sub frmAccess_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        strConnect = ""
        StrNameBase = ""
        Me.lblStrCon.Text = ""
        Me.tbNameBase.Text = ""
        Me.tbQnt.Text = ""
        Me.lblName.Text = ""
        Me.lblQnt.Text = ""
    End Sub

    ' выбор базы
    Private Sub btnBase_Click(sender As System.Object, e As System.EventArgs) Handles btnBase.Click
        If Not SelectBase() Then ' функция вызова диалогового окна выбора файла базы
            MsgBox("Файл базы не выбран!", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.tbNameBase.Text = StrNameBase
        ' подключение
        CNAccess.ConnectionString = strConnect
        ' пишем имя базы в строку статуса 
        Me.lblStrCon.Text = strConnect
    End Sub

    ' добавление таблицы
    Private Sub btnAddTable_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTable.Click
        Dim qSQL As OleDbCommand ' запрос
        Dim strQuery As String

        If strConnect = "" Then
            MsgBox("Нет подключения!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        nameTbl = Now.ToString
        nameTbl = Strings.Replace(nameTbl, " ", "")
        nameTbl = Strings.Replace(nameTbl, ":", "")
        nameTbl = Strings.Replace(nameTbl, ".", "")
        nameTbl = "test" & nameTbl
        strQuery = "CREATE TABLE " & nameTbl & " (" & _
                        "ID COUNTER (1,1) PRIMARY KEY, " & _
                        "Name VARCHAR (30), " & _
                        "Qnt INT)"
        Try
            qSQL = New OleDbCommand(strQuery, CNAccess) ' создаем запрос
            If CNAccess.State = ConnectionState.Closed Then CNAccess.Open() ' открываем соединение
            qSQL.ExecuteNonQuery() ' выполняем запрос
        Catch ex As Exception ' если ошибка
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            CNAccess.Close() ' закрываем соединение
            MsgBox("Готово.", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnAddStr_Click(sender As System.Object, e As System.EventArgs) Handles btnAddStr.Click
        ' проверки
        If strConnect = "" Then
            MsgBox("Нет подключения!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If nameTbl = "" Then
            MsgBox("Не создана таблица!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.tbName.Text = "" Then
            MsgBox("Отсутствует название!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Me.tbQnt.Text = "" Then
            MsgBox("Отсутствует количество!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim qSQL As OleDbCommand ' запрос
        Dim strQuery As String

        strQuery = "INSERT INTO " & nameTbl & _
                        " (Name, Qnt)" & _
                        " VALUES ('" & Me.tbName.Text & "', " & Me.tbQnt.Text & ")"
        Try
            qSQL = New OleDbCommand(strQuery, CNAccess) ' создаем запрос
            If CNAccess.State = ConnectionState.Closed Then CNAccess.Open() ' открываем соединение
            qSQL.ExecuteNonQuery() ' выполняем запрос
        Catch ex As Exception ' если ошибка
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            CNAccess.Close() ' закрываем соединение
            MsgBox("Готово.", MsgBoxStyle.Information)
        End Try
    End Sub

    ' показать последнюю строку
    Private Sub btnViewStr_Click(sender As System.Object, e As System.EventArgs) Handles btnViewStr.Click
        ' проверки
        If strConnect = "" Then
            MsgBox("Нет подключения!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If nameTbl = "" Then
            MsgBox("Не создана таблица!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim qSQL As OleDbCommand ' запрос
        Dim strQuery As String
        Dim DA As OleDbDataAdapter
        Dim DT As New DataTable

        strQuery = "SELECT Name,Qnt FROM " & nameTbl & " WHERE ID=(SELECT MAX(ID) FROM " & nameTbl & ")"
        qSQL = New OleDbCommand(strQuery, CNAccess) ' создаем запрос
        Try
            If CNAccess.State = ConnectionState.Closed Then CNAccess.Open() ' открываем соединение
            qSQL.ExecuteNonQuery() ' выполняем запрос
        Catch ex As Exception ' если ошибка
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        Finally
            CNAccess.Close() ' закрываем соединение
        End Try
        DA = New OleDbDataAdapter(qSQL) 'Через адаптер получаем результаты запроса
        DA.Fill(DT) ' Заполняем таблицу результатами
        If DT.Rows.Count = 0 Then
            MsgBox("В таблице нет данных!", MsgBoxStyle.Information)
            Exit Sub
        End If
        ' показываем последнюю строку
        Me.lblName.Text = DT.Rows(0).Item("Name")
        Me.lblQnt.Text = DT.Rows(0).Item("Qnt")
    End Sub

    ' контроль ввода количества
    Private Sub tbQnt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tbQnt.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8 ' цифры 0 - 9 и <Backspace> (эти символы всегда разрешены)
            Case Else
                e.KeyChar = Chr(0) ' остальные символы запрещены
        End Select
    End Sub

    ' ========================================================
    ' функция выбора базы для подключения
    ' возвращает TRUE при выборе файла
    ' ========================================================
    Public Function SelectBase() As Boolean
        Dim openFileDial As New OpenFileDialog()
        SelectBase = True
        'Настройка параметров диалогового окна
        openFileDial.InitialDirectory = "%USERPROFILE%\desktop\" 'начальная папка 
        openFileDial.Filter = "база Access |*.accdb" 'допустимые расширения
        openFileDial.RestoreDirectory = True 'запомнить путь
        'запуск и обработка диалогового окна открытия файла
        If openFileDial.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            StrNameBase = openFileDial.FileName
            strConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & StrNameBase
            SelectBase = True
        Else
            SelectBase = False
        End If
    End Function
End Class