Imports System.Data.Odbc

Public Class User
    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
    Sub carikode()
        cmd = New OdbcCommand("select * from users where id_user='" & TextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader

    End Sub
    Sub ketemu()
        TextBox1.Text = dr(0)
        TextBox2.Text = dr(1)
        TextBox3.Text = dr(2)
        TextBox4.Text = dr(3)
        TextBox5.Text = dr(4)
    End Sub
    Sub tampilgrid()
        da = New OdbcDataAdapter("select * from users", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True

    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilgrid()
        Me.CenterToScreen()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call kosongkan()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data belum lengkap")
        Else
            Call carikode()
            If dr.HasRows Then
                'update
                Dim update As String = "update users set level_user='" & TextBox2.Text & "',nama='" & TextBox2.Text & "',username='" & TextBox3.Text & "',password='" & TextBox4.Text & "' where id_user='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(update, conn)
                dr = cmd.ExecuteReader
                Call tampilgrid()
                MsgBox("data berhasil diupdate")


            End If
            'simpan
            Dim simpan As String = "insert into users values('','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            cmd = New OdbcCommand(simpan, conn)
            dr = cmd.ExecuteReader
            Call tampilgrid()
            MsgBox("data berhasil dimasukan")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call carikode()
        If dr.HasRows Then
            If MessageBox.Show("Apakah anda yakin ingin menghapus?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("delete from users where id_user='" & TextBox1.Text & "'", conn)
                dr = cmd.ExecuteReader
                Call tampilgrid()
                MsgBox("data berhasil didihapus")
            End If
        End If
        

    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class
