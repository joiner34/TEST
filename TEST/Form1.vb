Imports System.Windows.Forms

Public Class mainForm

    ' Меню -> Access
    Private Sub AccessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccessToolStripMenuItem.Click
        Dim flag As Boolean = False
        ' проверяем что не открыта
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Text = "Access" Then
                flag = True
                ChildForm.Activate()
                Exit For
            End If
        Next
        If Not flag Then ' если не открыта
            ' создаем ее
            Dim fAccess As New frmAccess
            fAccess.MdiParent = Me ' дочерняя форма к этой
            fAccess.WindowState = FormWindowState.Maximized
            fAccess.Show() ' открываем
        End If
    End Sub

    Private Sub MySQLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MySQLToolStripMenuItem.Click
        Dim flag As Boolean = False
        ' проверяем что не открыта
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Text = "SQL" Then
                flag = True
                ChildForm.Activate()
                Exit For
            End If
        Next
        If Not flag Then ' если не открыта
            ' создаем ее
            Dim fSQL As New frmSQL
            fSQL.MdiParent = Me ' дочерняя форма к этой
            fSQL.WindowState = FormWindowState.Maximized
            fSQL.Show() ' открываем
        End If
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
