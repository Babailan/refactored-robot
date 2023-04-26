Public Class Form2
    Dim UserAuth = "user"
    Dim PassAuth = "admin"
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        If UserName.Text = "" Then
            MsgBox("Username is empty", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf Password.Text = "" Then
            MsgBox("Password is empty", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf Not (UserName.Text = UserAuth) Then
            MsgBox("Username is wrong", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf Not (Password.Text = PassAuth) Then
            MsgBox("Password is wrong", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Me.Hide()
        Form1.Show()
    End Sub
End Class