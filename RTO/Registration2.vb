Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Registration2
    Dim conn As New MySqlConnection

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label10.Click, Label12.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TermsCondition.Show()

    End Sub

    Private Sub Registration2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader
        Dim vmcwog, vmcwg, vlmv As String


        Try
            If CheckBox5.Checked = False Then
                MsgBox("Accept Terms and Conditions Before Contineuing", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If

            If mcwog.Checked = True Then
                vmcwog = "YES"
            ElseIf mcwog.Checked = False Then
                vmcwog = "NO"
            End If

            If mcwg.Checked = True Then
                vmcwg = "YES"
            ElseIf mcwg.Checked = False Then
                vmcwg = "NO"
            End If

            If lmv.Checked = True Then
                vlmv = "YES"
            ElseIf lmv.Checked = False Then
                vlmv = "NO"
            End If

            conn.Open()
            Query = " update Registered set vehicle_type_mcwog='" & vmcwog & "',vehicle_type_mcwg='" & vmcwg & "',vehicle_type_lmv='" & vlmv & "',id_proof='" & id.Text & "',address_proof='" & address.Text & "',Age_proof='" & age.Text & "' where application_no='" & Appno.Text & "'"

            comm = New MySqlCommand(Query, conn)
            comm.ExecuteNonQuery()
            conn.Dispose()
            MsgBox("You have successfully Submitted Your Application
                        Press Ok to Make the Payment", MsgBoxStyle.Information, "Successfull")
            If vbOK Then
                Application_View.Show()
                conn.Open()
                Query = "select application_no,Type_of_Licence, Name_Of_Applicant, Gender, dob,pob, address,relation ,rname,mobile,qualification,identification_mark,blood,state,rto_name,vehicle_type_mcwog,vehicle_type_mcwg,vehicle_type_lmv,id_proof,address_proof,age_proof from Registered where Application_no='" & Appno.Text & "'"
                comm = New MySqlCommand(Query, conn)
                reader = comm.ExecuteReader()
                While reader.Read
                    Application_View.AN.Text = reader.GetString("application_no")
                    Application_View.TOL.Text = reader.GetString("Type_of_Licence")
                    Application_View.NOA.Text = reader.GetString("Name_Of_Applicant")
                    Application_View.Gender.Text = reader.GetString("Gender")
                    Application_View.Dob.Text = reader.GetString("dob")
                    Application_View.Pob.Text = reader.GetString("pob")
                    Application_View.Add.Text = reader.GetString("address")
                    Application_View.rel.Text = reader.GetString("relation")
                    Application_View.Reln.Text = reader.GetString("rname")
                    Application_View.mob.Text = reader.GetString("mobile")
                    Application_View.ql.Text = reader.GetString("qualification")
                    Application_View.IM.Text = reader.GetString("identification_mark")
                    Application_View.bg.Text = reader.GetString("blood")
                    Application_View.st.Text = reader.GetString("state")
                    Application_View.rn.Text = reader.GetString("RTO_Name")
                    Application_View.tov.Text = reader.GetString("vehicle_type_mcwog")
                    Application_View.mcwg.Text = reader.GetString("vehicle_type_mcwg")
                    Application_View.lmv.Text = reader.GetString("vehicle_type_lmv")
                    Application_View.ID.Text = reader.GetString("Id_proof")
                    Application_View.AP.Text = reader.GetString("Address_Proof")
                    Application_View.AG.Text = reader.GetString("Age_Proof")
                    ' Dim data As Byte() = DirectCast(reader("Image"), Byte())
                    'Dim ms As New MemoryStream(CType(reader.Item("Image"), Byte()))
                    ' Application_View.PictureBox1.Image = Image.FromStream(ms)
                End While
                Application_View.mp.Visible = True
                Me.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

End Class