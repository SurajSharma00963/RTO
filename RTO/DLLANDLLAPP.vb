Imports MySql.Data.MySqlClient
Public Class DLLANDLLAPP
    Dim conn As New MySqlConnection
    Private Sub DLLANDLLAPPvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;username=root;password=root;database=rto_management"

        'TODO: This line of code loads data into the 'Rto_managementDataSet.registered' table. You can move, or remove it, as needed.
        Me.RegisteredTableAdapter.Fill(Me.Rto_managementDataSet.registered)
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet
        Try

            conn.Open()
            adapter = New MySqlDataAdapter("SELECT APPLICATION_NO,TYPE_OF_LICENCE,NAME_OF_APPLICANT,STATUS FROM registered  where status = 'Application Submitted And Receieved'", conn)
            adapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub


    Private Sub open_Click(sender As Object, e As EventArgs) Handles open.Click
        Dim comm As New MySqlCommand
        Dim Query As String
        Dim reader As MySqlDataReader

        Try
            Application_View.Show()
            conn.Open()
            Query = "select application_no,Type_of_Licence, Name_Of_Applicant, Gender, dob,pob, address,relation ,rname,mobile,qualification,identification_mark,blood,state,rto_name,vehicle_type_mcwog,vehicle_type_mcwg,vehicle_type_lmv,id_proof,address_proof,age_proof from Registered where Application_no='" & Applicationno.Text & "'"
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

                '  Application_View.PictureBox1.Image = Image.FromStream(
            End While
            Application_View.approve.Visible = True
            Application_View.cancel.Visible = True
            Me.Close()



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Welcome_officer.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class