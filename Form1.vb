Public Class Form1
    Dim total As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Clear()
        price.Text = "0"
        total = 0
    End Sub

    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        If Not ListBox1.SelectedIndex = -1 Then
            Dim n = Split(ListBox1.Items.Item(ListBox1.SelectedIndex), " ")
            ListBox2.Items.Add(n(1))
            total += n(1)
            price.Text = total.ToString()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not ListBox2.SelectedIndex = -1 Then
            total -= Val(ListBox2.Items.Item(ListBox2.SelectedIndex))
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            price.Text = total.ToString()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If Not ListBox1.SelectedIndex = -1 Then
            OrderPlace.Text = ListBox1.Items.Item(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click
        If Cash.Text = "" Then
            MsgBox("Please put a cash", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim change As Integer = (Val(Cash.Text) - total)
        If change < 0 Then
            MsgBox("Money is not enough", MsgBoxStyle.Information)
            Exit Sub
        End If
        MsgBox("Your change is " + change.ToString(), MsgBoxStyle.Information)
    End Sub
End Class
