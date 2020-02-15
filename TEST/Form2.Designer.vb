<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccess
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbNameBase = New System.Windows.Forms.TextBox()
        Me.btnBase = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddTable = New System.Windows.Forms.Button()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbQnt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddStr = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnViewStr = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStrCon = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQnt = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNameBase
        '
        Me.tbNameBase.Location = New System.Drawing.Point(36, 35)
        Me.tbNameBase.Name = "tbNameBase"
        Me.tbNameBase.Size = New System.Drawing.Size(353, 20)
        Me.tbNameBase.TabIndex = 0
        '
        'btnBase
        '
        Me.btnBase.Location = New System.Drawing.Point(395, 32)
        Me.btnBase.Name = "btnBase"
        Me.btnBase.Size = New System.Drawing.Size(68, 24)
        Me.btnBase.TabIndex = 1
        Me.btnBase.Text = "Выбрать"
        Me.btnBase.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Выбрать базу данных Access"
        '
        'btnAddTable
        '
        Me.btnAddTable.Location = New System.Drawing.Point(469, 32)
        Me.btnAddTable.Name = "btnAddTable"
        Me.btnAddTable.Size = New System.Drawing.Size(117, 24)
        Me.btnAddTable.TabIndex = 4
        Me.btnAddTable.Text = "Добавить таблицу"
        Me.btnAddTable.UseVisualStyleBackColor = True
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(83, 30)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(160, 20)
        Me.tbName.TabIndex = 5
        '
        'tbQnt
        '
        Me.tbQnt.Location = New System.Drawing.Point(83, 56)
        Me.tbQnt.Name = "tbQnt"
        Me.tbQnt.Size = New System.Drawing.Size(160, 20)
        Me.tbQnt.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddStr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.tbQnt)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 116)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Добавление строки"
        '
        'btnAddStr
        '
        Me.btnAddStr.Location = New System.Drawing.Point(168, 82)
        Me.btnAddStr.Name = "btnAddStr"
        Me.btnAddStr.Size = New System.Drawing.Size(75, 24)
        Me.btnAddStr.TabIndex = 9
        Me.btnAddStr.Text = "Добавить"
        Me.btnAddStr.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Количество"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Название"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblQnt)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.btnViewStr)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(305, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 116)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Последняя строка базы"
        '
        'btnViewStr
        '
        Me.btnViewStr.Location = New System.Drawing.Point(158, 82)
        Me.btnViewStr.Name = "btnViewStr"
        Me.btnViewStr.Size = New System.Drawing.Size(83, 24)
        Me.btnViewStr.TabIndex = 13
        Me.btnViewStr.Text = "Показать"
        Me.btnViewStr.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Количество"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Название"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(128, 17)
        Me.ToolStripStatusLabel1.Text = "Строка подключения:"
        '
        'lblStrCon
        '
        Me.lblStrCon.Name = "lblStrCon"
        Me.lblStrCon.Size = New System.Drawing.Size(104, 17)
        Me.lblStrCon.Text = "нет подключения"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblStrCon})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 227)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.Window
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(97, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(144, 20)
        Me.lblName.TabIndex = 14
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQnt
        '
        Me.lblQnt.BackColor = System.Drawing.SystemColors.Window
        Me.lblQnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQnt.Location = New System.Drawing.Point(97, 55)
        Me.lblQnt.Name = "lblQnt"
        Me.lblQnt.Size = New System.Drawing.Size(144, 21)
        Me.lblQnt.TabIndex = 15
        Me.lblQnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 249)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddTable)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBase)
        Me.Controls.Add(Me.tbNameBase)
        Me.Name = "frmAccess"
        Me.Text = "Access"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNameBase As System.Windows.Forms.TextBox
    Friend WithEvents btnBase As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddTable As System.Windows.Forms.Button
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbQnt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddStr As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewStr As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStrCon As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblQnt As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
