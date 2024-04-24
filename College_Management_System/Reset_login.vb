Public Class Reset_login

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim obj = New Login

        Dim oldUser As String = obj.user
        Dim OldPass As Integer = obj.pass
        Dim newUser As String
        Dim newPass As Integer
        If tbOlduser.Text = "" Or tbOldpass.Text = "" Or tbNewUser.Text = "" Or tbNewpass.Text = "" Or tbCnfpass.Text = "" Then
            MsgBox("Missing information!")
        ElseIf tbOlduser.Text <> oldUser Or tbOldpass.Text <> OldPass Then
            MsgBox("Wrong Username or Password")
        ElseIf tbNewpass.Text <> tbCnfpass.Text Then
            MsgBox("Please Confirm the new Password")
        Else
            newUser = tbNewUser.Text
            newPass = tbNewpass.Text
            obj.user = newUser
            obj.pass = newPass
            MsgBox("Username and Password Updated!")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.Hide()


    End Sub
End Class