Imports System.Data.SqlClient

Public Class Main
    Dim Con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\jaafa\Downloads\College_Management_System\College_Management_System\CMSVbDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayStudentInfo()
        fillStDepartment()
        ClearStudent()

        DisplayLecInfo()
        fillLecDepartment()
        ClearLec()

        DisplayDepInfo()
        ClearDep()

        DisplayFeesInfo()
        fillStudentID()
        ClearFees()

        countStudents()
        countLectureres()
        countDepartments()
        countFees()
    End Sub

    ' /////////////////////
    ' // Students Panel // 
    ' ////////////////////    
    Private Sub btnStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudent.Click
        PanelOnBtn.Height = btnStudent.Height
        PanelOnBtn.Top = btnStudent.Top
        PanelStudent.Visible = True
        PanelLecturer.Visible = False
        PanelDepartment.Visible = False
        PanelFees.Visible = False
        PanelDashboard.Visible = False
        DisplayStudentInfo()
        'ClearStudent()
    End Sub
    Private Sub fillStDepartment()
        Con.Open()
        Dim query = "select * from Department"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CbStDep.DataSource = Tbl
        CbStDep.DisplayMember = "Dep_name"
        CbStDep.ValueMember = "Dep_name"
        Con.Close()
    End Sub
    Private Sub DisplayStudentInfo()
        Con.Open()
        Dim query = "select * from Student"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StudentDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub ClearStudent()
        tbStFees.Text = ""
        tbStPhone.Text = ""
        tbStname.Text = ""
        CbStDep.SelectedIndex = -1
        CbStGender.SelectedIndex = -1
    End Sub

    Private Sub btnStAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStAdd.Click
        If tbStname.Text = "" Or tbStFees.Text = "" Or tbStPhone.Text = "" Or CbStDep.SelectedIndex = -1 Or CbStGender.SelectedIndex = -1 Then
            MsgBox("Missing information!")
        Else
            Try
                Con.Open()
                Dim query = "insert into Student values('" & tbStname.Text & "','" & CbStGender.SelectedItem.ToString() & "','" & StDOB.Value.Date & "','" & tbStPhone.Text & "','" & CbStDep.SelectedValue.ToString() & "'," & tbStFees.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Added!")
                Con.Close()
                DisplayStudentInfo()
                ClearStudent()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Dim key = 0
    Private Sub StudentDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles StudentDGV.CellMouseClick
        Dim row As DataGridViewRow = StudentDGV.Rows(e.RowIndex)
        tbStname.Text = row.Cells(1).Value.ToString
        CbStGender.SelectedItem = row.Cells(2).Value.ToString
        StDOB.Text = row.Cells(3).Value.ToString
        tbStPhone.Text = row.Cells(4).Value.ToString
        CbStDep.Text = row.Cells(5).Value.ToString
        tbStFees.Text = row.Cells(6).Value.ToString

        If tbStname.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub btnStReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStReset.Click
        ClearStudent()
    End Sub

    Private Sub btnStRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStRemove.Click
        If key = 0 Then
            MsgBox("Select the Student!")
        Else
            Try
                Con.Open()
                Dim query = "delete from Student where St_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Deleted!")
                Con.Close()
                DisplayStudentInfo()
                ClearStudent()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnStEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStEdit.Click
        If tbStname.Text = "" Or tbStFees.Text = "" Or tbStPhone.Text = "" Or CbStDep.SelectedIndex = -1 Or CbStGender.SelectedIndex = -1 Then
            MsgBox("Missing information!")
        Else
            Try
                Con.Open()
                Dim query = "update Student set St_Name='" & tbStname.Text & "',St_Gender='" & CbStGender.SelectedItem.ToString() & "',St_DOB='" & StDOB.Text & "',St_Phone='" & tbStPhone.Text & "',St_Deb='" & CbStDep.SelectedValue.ToString() & "',St_Fees='" & tbStFees.Text & "' where St_id=" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Updated!")
                Con.Close()
                DisplayStudentInfo()
                ClearStudent()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    '///////////////////////////////////  End of Student Panel      ///////////////////////////////////

    ' /////////////////////
    ' // Lecturer Panel // 
    ' ////////////////////

    Private Sub btnLecturer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLecturer.Click
        PanelOnBtn.Height = btnLecturer.Height
        PanelOnBtn.Top = btnLecturer.Top
        PanelLecturer.Visible = True
        PanelStudent.Visible = False
        PanelDepartment.Visible = False
        PanelFees.Visible = False
        PanelDashboard.Visible = False
        DisplayLecInfo()

    End Sub
    Private Sub fillLecDepartment()
        Con.Open()
        Dim query = "select * from Department"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CbLDep.DataSource = Tbl
        CbLDep.DisplayMember = "Dep_name"
        CbLDep.ValueMember = "Dep_name"
        Con.Close()


    End Sub

    Private Sub DisplayLecInfo()
        Con.Open()
        Dim query = "select * from Lecturer"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        LecDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub ClearLec()
        tbLname.Text = ""
        tbLaddress.Text = ""
        tbLphone.Text = ""
        CbLDep.SelectedIndex = -1
        CbLgender.SelectedIndex = -1

    End Sub

    Private Sub btnLAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLAdd.Click
        If tbLname.Text = "" Or tbLaddress.Text = "" Or tbLphone.Text = "" Or CbLDep.SelectedIndex = -1 Or CbLgender.SelectedIndex = -1 Then
            MsgBox("Missing information!")
        Else
            Try
                Con.Open()
                Dim query = "insert into Lecturer values('" & tbLname.Text & "','" & CbLgender.SelectedItem.ToString() & "','" & LDOB.Value.Date & "','" & tbLphone.Text & "','" & CbLDep.SelectedValue.ToString() & "','" & tbLaddress.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Lecturer Added!")
                Con.Close()
                DisplayLecInfo()
                ClearLec()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLReset.Click
        ClearLec()
    End Sub

    Dim key2 = 0
    Private Sub LecDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles LecDGV.CellMouseClick
        Dim row As DataGridViewRow = LecDGV.Rows(e.RowIndex)
        tbLname.Text = row.Cells(1).Value.ToString
        CbLgender.SelectedItem = row.Cells(2).Value.ToString
        LDOB.Text = row.Cells(3).Value.ToString
        tbLphone.Text = row.Cells(4).Value.ToString
        CbLDep.Text = row.Cells(5).Value.ToString
        tbLaddress.Text = row.Cells(6).Value.ToString

        If tbLname.Text = "" Then
            key2 = 0
        Else
            key2 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub btnLRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLRemove.Click
        If key2 = 0 Then
            MsgBox("Select the Lecturer!")
        Else
            Try
                Con.Open()
                Dim query = "delete from Lecturer where L_id=" & key2 & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Lecturer Deleted!")
                Con.Close()
                DisplayLecInfo()
                ClearLec()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Private Sub btnLEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLEdit.Click
        If tbLname.Text = "" Or tbLaddress.Text = "" Or tbLphone.Text = "" Or CbLDep.SelectedIndex = -1 Or CbLgender.SelectedIndex = -1 Then
            MsgBox("Missing information!")
        Else
            Try
                Con.Open()
                Dim query = "update Lecturer set L_name='" & tbLname.Text & "',L_Gender='" & CbLgender.SelectedItem.ToString() & "',L_DOB='" & LDOB.Text & "',L_Phone='" & tbLphone.Text & "',L_Dep='" & CbLDep.SelectedValue.ToString() & "',L_Address='" & tbLaddress.Text & "' where L_id=" & key2 & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Lecturer Updated!")
                Con.Close()
                DisplayLecInfo()
                ClearLec()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    '///////////////////////////////////  End of Lecturer Panel      ///////////////////////////////////

    ' /////////////////////
    ' // Department Panel // 
    ' ////////////////////
    Private Sub btnDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartment.Click
        PanelOnBtn.Height = btnDepartment.Height
        PanelOnBtn.Top = btnDepartment.Top
        PanelDepartment.Visible = True
        PanelLecturer.Visible = False
        PanelStudent.Visible = False
        PanelFees.Visible = False
        PanelDashboard.Visible = False
        DisplayDepInfo()

    End Sub

    Private Sub DisplayDepInfo()
        Con.Open()
        Dim query = "select * from Department"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DepartmentDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub ClearDep()
        tbDepName.Text = ""
        tbDesc.Text = ""
        tbDuration.Text = ""
    End Sub
    Private Sub btnDAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAdd.Click
        If tbDepName.Text = "" Or tbDesc.Text = "" Or tbDuration.Text = "" Then
            MsgBox("Missing information!")
        Else
            Try
                Con.Open()
                Dim query = "insert into Department values('" & tbDepName.Text & "','" & tbDesc.Text & "'," & tbDuration.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Added!")
                Con.Close()
                DisplayDepInfo()
                ClearDep()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnDReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDReset.Click
        ClearDep()

    End Sub

    Private Sub btnDRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDRemove.Click
        If key3 = 0 Then
            MsgBox("Select the Department!")
        Else
            Try
                Con.Open()
                Dim query = "delete from Department where Dep_Id=" & key3 & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Deleted!")
                Con.Close()
                DisplayDepInfo()
                ClearDep()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Dim key3 = 0
    Private Sub DepartmentDGV_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DepartmentDGV.CellMouseClick
        Dim row As DataGridViewRow = DepartmentDGV.Rows(e.RowIndex)
        tbDepName.Text = row.Cells(1).Value.ToString
        tbDesc.Text = row.Cells(2).Value.ToString
        tbDuration.Text = row.Cells(3).Value.ToString
        If tbDepName.Text = "" Then
            key3 = 0
        Else
            key3 = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnDEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDEdit.Click
        If tbDepName.Text = "" Or tbDesc.Text = "" Or tbDuration.Text = "" Then
            MsgBox("Missing information!")
        Else
            Try
                Con.Open()
                Dim query = "update Department set Dep_name='" & tbDepName.Text & "',Dep_desc='" & tbDesc.Text & "',Dep_dur=" & tbDuration.Text & " where Dep_Id=" & key3 & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Updated!")
                Con.Close()
                DisplayDepInfo()
                ClearDep()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    '///////////////////////////////////  End of Departments Panel      ///////////////////////////////////

    ' /////////////////////
    ' // Fees Panel // 
    ' ////////////////////
    Private Sub btnFees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFees.Click
        PanelOnBtn.Height = btnFees.Height
        PanelOnBtn.Top = btnFees.Top
        PanelFees.Visible = True
        PanelDepartment.Visible = False
        PanelLecturer.Visible = False
        PanelStudent.Visible = False
        PanelDashboard.Visible = False
        DisplayFeesInfo()
        fillStudentID()

        cbStID.SelectedIndex = -1

    End Sub

    Private Sub fillStudentID()
        Con.Open()
        Dim query = "select * from Student"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        cbStID.DataSource = Tbl
        cbStID.DisplayMember = "St_id"
        cbStID.ValueMember = "St_id"
        Con.Close()


    End Sub

    Private Sub DisplayFeesInfo()
        Con.Open()
        Dim query = "select * from Payment"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        AccDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub ClearFees()
        tbAmount.Text = ""
        tbName.Text = ""
        cbStID.SelectedIndex = -1
    End Sub

    Private Sub updateStudentFee()
        Try
            Con.Open()
            Dim query = "update Student set St_Fees=" & tbAmount.Text & " where St_id=" & cbStID.SelectedValue.ToString() & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Fee Updated!")
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        If tbName.Text = "" Or tbAmount.Text = "" Then
            MsgBox("Missing information!")
        ElseIf Convert.ToInt32(tbAmount.Text) > 1000000 Or Convert.ToInt32(tbAmount.Text) < 1 Then
            MsgBox("Invaild Amount!")

        Else
            Try
                Con.Open()
                Dim query = "insert into Payment values(" & cbStID.SelectedValue.ToString() & ",'" & tbName.Text & "','" & PeriodDate.Value.Date & "'," & tbAmount.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Successful Payment!")
                Con.Close()
                DisplayFeesInfo()
                updateStudentFee()
                ClearFees()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Private Sub getStudentName()
        Con.Open()
        Dim query = "select * from Student where St_id=" & cbStID.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataSet
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            tbName.Text = reader(1).ToString()
        End While
        Con.Close()
    End Sub

    Private Sub cbStID_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbStID.SelectionChangeCommitted
        getStudentName()
    End Sub



    '///////////////////////////////////  End of Fees Panel      ///////////////////////////////////

    ' /////////////////////
    ' // Dashboard Panel // 
    ' ////////////////////
    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        PanelOnBtn.Height = btnDashboard.Height
        PanelOnBtn.Top = btnDashboard.Top
        PanelDashboard.Visible = True
        PanelFees.Visible = False
        PanelDepartment.Visible = False
        PanelLecturer.Visible = False
        PanelStudent.Visible = False

        countStudents()
        countLectureres()
        countDepartments()
        countFees()
    End Sub
    Private Sub countStudents()
        Dim stNum As Integer
        Con.Open()
        Dim query = "select COUNT(*) from Student"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        stNum = cmd.ExecuteScalar
        LblSt.Text = stNum
        Con.Close()
    End Sub

    Private Sub countLectureres()
        Dim lecNum As Integer
        Con.Open()
        Dim query = "select COUNT(*) from Lecturer"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        lecNum = cmd.ExecuteScalar
        LblLec.Text = lecNum
        Con.Close()
    End Sub

    Private Sub countDepartments()
        Dim depNum As Integer
        Con.Open()
        Dim query = "select COUNT(*) from Department"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        depNum = cmd.ExecuteScalar
        LblDep.Text = depNum
        Con.Close()
    End Sub

    Private Sub countFees()
        Dim feesAmount As Integer
        Con.Open()
        Dim query = "select Sum(Amount) from Payment"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        feesAmount = cmd.ExecuteScalar
        Dim iq As String
        iq = Convert.ToString(feesAmount)
        LblFee.Text = iq + " IQD"
        Con.Close()
    End Sub


    Private Sub btnCloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseForm.Click
        Application.Exit()
    End Sub




    Private Sub btnLO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLO.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub


End Class