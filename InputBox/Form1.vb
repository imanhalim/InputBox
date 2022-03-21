Public Class Form1
    Private Sub TxtName_Click(sender As Object, e As EventArgs) Handles TxtName.Click
        Dim strNama As String = TextName.Text
        Dim strOutput As String = "Hello " + strNama + " Cantik "

        LblOutput.Text = strOutput

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub enter_Click(sender As Object, e As EventArgs) Handles enter.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblOutput.Click

    End Sub
End Class
