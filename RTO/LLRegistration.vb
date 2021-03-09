Imports MySql.Data.MySqlClient
Imports System.IO
Public Class LLRegistration
    Dim conn As New MySqlConnection
    Private Sub LLRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=RTO_Management   "
        Dim comm As New MySqlCommand
        comm.Connection = conn
        conn.Open()
        Dim i As Integer
        comm.CommandText = "select Max(Application_no) from Registered"
        If IsDBNull(comm.ExecuteScalar) Then
            i = 201410001
            Appno.Text = i
        Else
            i = comm.ExecuteScalar + 1
            Appno.Text = i
        End If
        comm.Dispose()
        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim gender1, LT1 As String
        Dim fmlname, fname1, mname1, lname1, s As String
        Dim relation As String
        Dim rname, rfname, rmname, rlname As String
        Dim address, a, b, c, d, eg, f, g As String
        Dim z As String
        Try
            If LL.Checked = False And DL.Checked = False Then
                MsgBox("select one LL or DL", MsgBoxStyle.Critical, "Empty Fields")
                Exit Sub
            End If
            If state.SelectedItem = "" Then
                MsgBox("Select The State", MsgBoxStyle.Critical, "Empty Field")
                Exit Sub
            End If
            If Nameofrto.SelectedItem = "" Then
                MsgBox("Select The  Name of Rto", MsgBoxStyle.Critical, "Empty Field")
                Exit Sub
            End If
            If DOB.Value >= "12-12-1997" Then
                MsgBox("Check Your DOB", MsgBoxStyle.Information, "Error Date Of Birth")
                Exit Sub
            End If
            If male.Checked = False And female.Checked = False And others.Checked = False Then
                MsgBox("Select your Gender", MsgBoxStyle.Critical, "Empty Fields")
                Exit Sub
            End If
            If fname.Text = "" Or lname.Text = "" Then
                MsgBox("First Name and Last Name is Required", MsgBoxStyle.Critical, "Mandatory ")
                Exit Sub
            End If
            If ffname.Text = "" Or flname.Text = "" Then
                MsgBox("Relations First Name and Last Name is Required", MsgBoxStyle.Critical, "Mandatory ")
                Exit Sub
            End If
            If father.Checked = False And husband.Checked = False And guardian.Checked = False Then
                MsgBox("Check the relation fields", MsgBoxStyle.Critical, "check the flieds")
                Exit Sub
            End If

            If male.Checked Then
                gender1 = male.Text
            ElseIf female.Checked Then
                gender1 = female.Text
            End If

            z = ""

            If DL.Checked Then
                LT1 = DL.Text
            ElseIf LL.Checked Then
                LT1 = LL.Text
            End If

            If father.Checked Then
                relation = father.Text
            ElseIf husband.Checked Then
                relation = husband.Text
            ElseIf guardian.Checked Then
                relation = guardian.Text
            End If

            s = S1.Text

            rfname = ffname.Text
            rmname = fmname.Text
            rlname = flname.Text
            rname = rfname + s + rmname + s + rlname

            fname1 = fname.Text
            mname1 = mname.Text
            lname1 = lname.Text
            fmlname = fname1 + s + mname1 + s + lname1

            a = st.Text
            b = street.Text
            c = loc.Text
            d = vill.Text
            eg = dist.Text
            f = staten.Text
            g = pin.Text
            address = a + s + b + s + c + s + d + s + eg + s + f + s + g


            If Len(mob.Text) < 10 Then
                MsgBox("Check Contact number", MsgBoxStyle.Critical, "WARNING")
                Exit Sub
            End If

            conn.Open()
            Query = " insert into Registered(application_no,type_of_licence, name_of_applicant,gender,dob,pob,relation,rname,address,mobile,qualification,identification_mark,blood,state,rto_name,vehicle_type_mcwog,vehicle_type_mcwg,vehicle_type_lmv,id_proof,address_proof,Age_proof,status) values('" & Appno.Text & "','" & LT1 & "','" & fmlname & "','" & gender1 & "','" & DOB.Text & "','" & POB.Text & "','" & relation & "','" & rname & "','" & address & "','" & mob.Text & "','" & qualification.Text & "','" & identificationmarks.Text & "','" & Bloodgroup.Text & "','" & state.Text & "','" & Nameofrto.Text & "','" & z & "','" & z & "','" & z & "','" & z & "','" & z & "','" & z & "','" & z & "') "
            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("Successfully Saved Your Information", MsgBoxStyle.Information, "Successfull")
            If vbOK Then
                Button1.Hide()
                NXT.Show()
            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub NXT_Click(sender As Object, e As EventArgs) Handles NXT.Click
        Registration2.Show()
        Dim comm As New MySqlCommand
        Dim Query As String

        Dim reader As MySqlDataReader
        conn.Open()
        Query = "select Application_no from registered where application_no='" & Appno.Text & "'"
        comm = New MySqlCommand(Query, conn)
        reader = comm.ExecuteReader()
        While reader.Read
            Registration2.Appno.Text = reader.GetString("application_no")
        End While
        Me.Close()
        comm.Dispose()
        conn.Close()
        conn.Dispose()
        Me.Hide()
    End Sub

    Private Sub pin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub mob_TextChanged(sender As Object, e As EventArgs) Handles mob.TextChanged
        mob.MaxLength = 10
    End Sub

    Private Sub fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            fname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub mname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            mname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            lname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub POB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles POB.KeyPress
        If Char.IsLower(e.KeyChar) Then
            POB.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub flname_keypress(sender As Object, e As KeyPressEventArgs) Handles flname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            flname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ffname_keypress(sender As Object, e As KeyPressEventArgs) Handles ffname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ffname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub fmname_keypress(sender As Object, e As KeyPressEventArgs) Handles fmname.KeyPress
        If Char.IsLower(e.KeyChar) Then
            fmname.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub vill_keypress(sender As Object, e As KeyPressEventArgs) Handles vill.KeyPress
        If Char.IsLower(e.KeyChar) Then
            vill.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub street_keypress(sender As Object, e As KeyPressEventArgs) Handles street.KeyPress
        If Char.IsLower(e.KeyChar) Then
            street.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub loc_Keypress(sender As Object, e As KeyPressEventArgs) Handles loc.KeyPress
        If Char.IsLower(e.KeyChar) Then
            loc.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub st_keypress(sender As Object, e As KeyPressEventArgs) Handles st.KeyPress
        If Char.IsLower(e.KeyChar) Then
            st.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub dist_keypress(sender As Object, e As KeyPressEventArgs) Handles dist.KeyPress
        If Char.IsLower(e.KeyChar) Then
            dist.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub identificationmarks_keypress(sender As Object, e As KeyPressEventArgs) Handles identificationmarks.KeyPress
        If Char.IsLower(e.KeyChar) Then
            identificationmarks.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
End Class