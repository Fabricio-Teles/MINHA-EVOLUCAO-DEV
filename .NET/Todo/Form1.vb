Imports System.Drawing.Printing

Public Class Form1
    Dim ds As New DataSet
    Dim dt As New DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds.Tables.Add("TAREFAS")
        ds.Tables(0).Columns.Add("NOVEMBRO")
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        Dim taskName As String = ""
        If prompt_chat.ShowDialog = DialogResult.OK Then
            taskName = prompt_chat.taskName.ToString
        End If
        ds.Tables(0).Rows.Add(taskName)

        CriarListaDeTarefas(prompt_chat.taskColor, taskName.Substring(0, 1).ToString.ToUpper & taskName.Substring(1, taskName.Length - 1).ToString)

    End Sub
    Sub CriarListaDeTarefas(taskListColor As Color, taskListText As String)
        Dim taskListPanel As New Panel With {
         .Cursor = Cursors.Hand,
         .Name = "taskListPanel",
         .Size = New Size(160, 26),
         .Dock = DockStyle.Top,
         .BackColor = Color.FromArgb(13, 39, 56)
        }

        Dim taskListPanelBorder As New Panel With {
            .Cursor = Cursors.Hand,
            .Name = "taskListPanelBorder",
            .Size = New Size(10, 25),
            .Location = New Point(150, 3),
            .BackColor = taskListColor
        }

        Dim taskListName As New Label With {
            .Cursor = Cursors.Hand,
            .Name = "taskListName",
            .ForeColor = Color.White,
            .Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold),
            .Location = New Point(0, 9),
            .Text = taskListText.ToString
        }

        taskListPanel.Controls.Add(taskListName)
        taskListPanel.Controls.Add(taskListPanelBorder)
        leftPanel.Controls.Add(taskListPanel)

        AddHandler taskListName.MouseEnter, AddressOf ChangeCenterColor
        AddHandler taskListName.MouseLeave, AddressOf RestaureCenterColor
        AddHandler taskListPanelBorder.MouseEnter, AddressOf ChangeCenterColor
        AddHandler taskListPanelBorder.MouseLeave, AddressOf RestaureCenterColor
        AddHandler taskListPanel.MouseEnter, AddressOf ChangeCenterColor
        AddHandler taskListPanel.MouseLeave, AddressOf RestaureCenterColor
    End Sub

    Private Sub ChangeCenterColor(obj As Object, e As EventArgs)
        If obj.name.ToString = "taskListPanel" Then
            obj.backColor = Color.FromArgb(22, 65, 94)
        Else
            obj.parent.backColor = Color.FromArgb(22, 65, 94)
        End If
    End Sub
    Private Sub RestaureCenterColor(obj As Object, e As EventArgs)
        If obj.name.ToString = "taskListPanel" Then
            obj.backColor = Color.FromArgb(13, 39, 56)
        Else
            obj.parent.backColor = Color.FromArgb(13, 39, 56)
        End If
    End Sub
End Class
