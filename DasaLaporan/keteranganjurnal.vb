Imports System.Data.Odbc

Public Class keteranganjurnal

    Sub bersihkan()
        TextBox1.Clear()
        TextBox2.Clear()
        kodejurnal.Text = ""
    End Sub

    Sub carikode()
        cmd = New OdbcCommand("select * from detailjurnal where id_detailjurnal='" & kodejurnal.Text & "'", conn)
        dr = cmd.ExecuteReader


    End Sub

    Sub ketemu()
        kodejurnal.Text = dr(0)
        TextBox1.Text = dr(2)
        TextBox2.Text = dr(3)
    End Sub

    Sub tampilgrid()
        da = New OdbcDataAdapter("select * from detailjurnal where id_jurnal=" & Jurnal.labelkode.Text & "", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True


    End Sub

    Private Sub keteranganjurnal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kodejurnal.Text = ""
        Me.CenterToScreen()
        Call tampilgrid()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call bersihkan()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("mohon lengkapi data")
        Else
            Call carikode()
            If dr.HasRows Then
                If MessageBox.Show("Data Jurnal dengan kode lama akan di input. Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    Dim update As String = "update detailjurnal set keterangan='" & TextBox1.Text & "',kredit='" & TextBox2.Text & "'where id_detailjurnal='" & kodejurnal.Text &"'"
                    cmd = New OdbcCommand(update, conn)
                    dr = cmd.ExecuteReader
                    Call tampilgrid()
                    Call bersihkan()

                    MsgBox("data berhasil diupdate")


                End If
                
            Else
                If MessageBox.Show("Data Jurnal dengan kode baru akan di input. Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    'simpan
                    Dim simpan As String = "insert into detailjurnal values('','" & Jurnal.labelkode.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    dr = cmd.ExecuteReader

                    Call tampilgrid()
                    Call bersihkan()

                    MsgBox("data berhasil ditambahkan")
                End If
                
            End If
            
        End If

        

    End Sub


    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        kodejurnal.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call carikode()
        If dr.HasRows Then
            If MessageBox.Show("Data keterangan yang anda klik akan dihapus, Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("delete from detailjurnal where id_detailjurnal='" & kodejurnal.Text & "'", conn)
                dr = cmd.ExecuteReader
                MsgBox("Data berhasil dihapus!")
                Call tampilgrid()

            End If
        Else
            MsgBox("Jika ingin menghapus, klik dahulu data ditable")
        End If
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class