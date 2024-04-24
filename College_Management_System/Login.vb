Public Class Login
    Public user As String = "GJ"
    Public pass As Integer = 1315

    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    '    Dim r = New Reset_login
    '    r.Show()


    'End Sub

    Private Sub btnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog.Click
        If tbPass.Text = "" Or tbUser.Text = "" Then
            MsgBox("Enter Username and Password!")
        ElseIf tbUser.Text = user And tbPass.Text = pass Then
            Dim obj = New Main
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password")
            tbPass.Text = ""
            tbUser.Text = ""
        End If
    End Sub
    Private Sub btnCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        Application.Exit()
    End Sub
End Class