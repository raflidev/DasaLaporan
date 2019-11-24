Imports System.Data.Odbc

Public Class Input
    Sub bersihkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        Kode.Text = ""
    End Sub
    Sub Carikode()
        cmd = New OdbcCommand("select * from uangdasa,lembar,logam where uangdasa.id_lembar=lembar.id_lembar and uangdasa.id_logam=logam.id_logam and uangdasa.kode ='" & Kode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub
    Sub ketemu()
        DTP.Value = dr(1)
        'lembar
        TextBox1.Text = dr(5)
        TextBox2.Text = dr(6)
        TextBox3.Text = dr(7)
        TextBox4.Text = dr(8)
        TextBox5.Text = dr(9)
        TextBox6.Text = dr(10)
        TextBox7.Text = dr(11)
        'logam
        TextBox8.Text = dr(13)
        TextBox9.Text = dr(14)
        TextBox10.Text = dr(15)
        TextBox11.Text = dr(16)
        TextBox12.Text = dr(17)
        TextBox13.Text = dr(18)

    End Sub

    Sub tampilgrid()
        da = New OdbcDataAdapter("select * from uangdasa,lembar,logam where uangdasa.id_lembar=lembar.id_lembar and uangdasa.id_logam=logam.id_logam", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub

    

    Private Sub Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Call tampilgrid()

        TextBox1.Focus()

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        User.Show()

        Me.Close()

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call bersihkan()

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call bersihkan()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        User.Show()

    End Sub

    Private Sub DGV_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        Kode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Carikode()
        If dr.HasRows Then
            Call ketemu()

        End If
    End Sub


    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call bersihkan()

    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'validasi

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox13.Text = "" Then
            MsgBox("Data belum lengkap")



        Else
            Call Carikode()
            If dr.HasRows Then
                If MessageBox.Show("Apakah anda yakin data ini akan di update..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim update As String = "update lembar,logam,uangdasa set tanggal='" & Format(DTP.Value, "yyyy-MM-dd") & "', lembarseratus='" & TextBox1.Text & "',lembarlimapuluh='" & TextBox2.Text & "',lembarduapuluh='" & TextBox3.Text & "',lembarsepuluh='" & TextBox4.Text & "',lembarlima='" & TextBox5.Text & "',lembardua='" & TextBox6.Text & "',lembarsatu='" & TextBox7.Text & "',logamseribu='" & TextBox8.Text & "',logamlimaratus='" & TextBox9.Text & "',logamduaratus='" & TextBox10.Text & "',logamseratus='" & TextBox11.Text & "',logamlimapuluh='" & TextBox12.Text & "',logamdualima='" & TextBox13.Text & "' where uangdasa.id_logam=logam.id_logam and uangdasa.id_lembar = lembar.id_lembar and uangdasa.kode = '" & Kode.Text & "'"

                    cmd = New OdbcCommand(update, conn)
                    cmd.ExecuteNonQuery()
                    Call tampilgrid()

                    MsgBox("Data berhasil diupdate!")
                End If


            Else
                If MessageBox.Show("Data baru akan di input.. ingin melanjutkan?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim lembar As String = "insert into lembar values('','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"

                    Dim logam As String = "insert into logam values('','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "')"

                    cmd = New OdbcCommand(lembar, conn)
                    cmd.ExecuteNonQuery()

                    cmd = New OdbcCommand(logam, conn)
                    cmd.ExecuteNonQuery()


                    cmd = New OdbcCommand("select * from logam order by id_logam DESC", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()

                    Dim kode_logam As Integer
                    kode_logam = dr(0)

                    cmd = New OdbcCommand("select * from lembar order by id_lembar DESC", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()

                    Dim kode_lembar As Integer
                    kode_lembar = dr(0)

                    Dim simpan As String = "insert into uangdasa values('','" & Format(DTP.Value, "yyyy-MM-dd") & "','" & kode_logam & "','" & kode_lembar & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    cmd.ExecuteNonQuery()
                    Call tampilgrid()

                    MsgBox("Data berhasil di input!")
                End If

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Carikode()
        If dr.HasRows Then
            If MessageBox.Show("Data jurnal yang anda klik akan dihapus, Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("delete from uangdasa where kode='" & Kode.Text & "'", conn)
                dr = cmd.ExecuteReader
                MsgBox("Data berhasil dihapus!")
                Call tampilgrid()

            End If
        Else
            MsgBox("Jika ingin menghapus, klik dahulu data ditable")
        End If
    End Sub

    Private Sub Button4_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class