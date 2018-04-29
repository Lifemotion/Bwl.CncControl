Public Class DirectControl
    Public Property Machine As MachineController

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bYm.Click
        Try
            Machine.MoveRelative(0, -Val(TextBox1.Text), 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bYp.Click
        Try
            Machine.MoveRelative(0, Val(TextBox1.Text), 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bXm.Click
        Try
            Machine.MoveRelative(-Val(TextBox1.Text), 0, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bXp.Click
        Try
            Machine.MoveRelative(Val(TextBox1.Text), 0, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bZm.Click
        Try
            Machine.MoveRelative(0, 0, -Val(TextBox1.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles bZp.Click
        Try
            Machine.MoveRelative(0, 0, Val(TextBox1.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bDist1_Click(sender As Object, e As EventArgs) Handles bDist1.Click
        TextBox1.Text = "1.0"
    End Sub

    Private Sub bDist10_Click(sender As Object, e As EventArgs) Handles bDist10.Click
        TextBox1.Text = "10.0"
    End Sub

    Private Sub bDist100_Click(sender As Object, e As EventArgs) Handles bDist100.Click
        TextBox1.Text = "100.0"
    End Sub
End Class
