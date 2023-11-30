Public Class prompt_chat
    Public taskColor As Color = Color.FromArgb(0, 131, 208)
    Public taskName As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        taskName = TextBox1.Text
        If TextBox1.Text = "" Then
            Me.DialogResult = DialogResult.Cancel
        End If
        Me.DialogResult = DialogResult.OK
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If sender.text = "" Then
            Button1.Text = "Cancelar"
        Else
            Button1.Text = "Criar Tarefa"
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Dim colorDialog As New ColorDialog
        colorDialog.ShowDialog()
        Panel1.BackColor = colorDialog.Color
        taskColor = colorDialog.Color
    End Sub
End Class