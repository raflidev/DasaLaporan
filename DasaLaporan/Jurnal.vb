Imports System.Data.Odbc


Public Class Jurnal
    Sub kosongkan()
        Lkode.Text = ""
        Tnamart.Clear()
        labelkode.Text = ""
        DTP1.Value = Today
        DTP2.Value = Today
        ldebet.Text = 0
        Call tampilkode()


    End Sub

    Sub ketemu()
        Lkode.Text = dr(0)
        labelkode.Text = dr(0)
        DTP1.Value = dr(1)
        DTP2.Value = dr(2)
        Tnamart.Text = dr(3)
        ldebet.Text = DGV.Rows(0).Cells(4).Value
    End Sub

   

    Sub tampilgrid()
        Call koneksi()
        da = New OdbcDataAdapter("select * from jurnal", conn)
        ds = New DataSet
        da.Fill(ds)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub tampilkode()
        cmd = New OdbcCommand("select count(id_jurnal) from jurnal ", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Lkode.Text = dr(0) + 1
    End Sub

    Sub carikode()
        cmd = New OdbcCommand("select * from jurnal where id_jurnal='" & Lkode.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub caridebet()
        Call koneksi()
        cmd = New OdbcCommand("select sum(lembarseratus),sum(lembarlimapuluh),sum(lembarduapuluh),sum(lembarsepuluh),sum(lembarlima),sum(lembardua),sum(lembarsatu),sum(logamseribu),sum(logamlimaratus),sum(logamduaratus),sum(logamseratus),sum(logamlimapuluh),sum(logamdualima) from uangdasa,lembar,logam where uangdasa.tanggal between '" & Format(DateValue(DTP1.Value), "yyyy-MM-dd") & "' AND '" & Format(DateValue(DTP2.Value), "yyyy-MM-dd") & "' and uangdasa.id_lembar=lembar.id_lembar and uangdasa.id_logam=logam.id_logam ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Try
                Dim lembar As Integer = (dr(0) * 100000) + (dr(1) * 50000) + (dr(2) * 20000) + (dr(3) * 10000) + (dr(4) * 5000) + (dr(5) * 2000) + (dr(6) * 1000)
                Dim logam As Integer = (dr(7) * 1000) + (dr(8) * 500) + (dr(9) * 200) + (dr(10) * 100) + (dr(11) * 50) + (dr(12) * 25)
                ldebet.Text = lembar + logam
            Catch ex As Exception
                MsgBox("terjadi kesalahan " & ex.Message)
            End Try

        Else
            MsgBox("data tidak ada")
        End If

    End Sub
    Private Sub Jurnal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call tampilkode()
        ldebet.Text = 0
        labelkode.Text = ""
        Call tampilgrid()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call kosongkan()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Tnamart.Text = "" Then
            MsgBox("Tolong Lengkapi data!")
        Else

            Call carikode()
            If dr.HasRows Then
                If MessageBox.Show("Data Jurnal dengan kode lama akan di input. Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim update As String = "update jurnal set bulan_awal = '" & Format(DTP1.Value, "yyyy-MM-dd") & "',bulan_akhir='" & Format(DTP2.Value, "yyyy-MM-dd") & "',ketuart='" & Tnamart.Text & "',debet='" & ldebet.Text & "' where id_jurnal='" & Lkode.Text & "'"
                    cmd = New OdbcCommand(update, conn)
                    dr = cmd.ExecuteReader
                    MsgBox("Data berhasil diupdate!")
                    Call tampilgrid()

                End If
            Else
                If MessageBox.Show("Data Jurnal dengan kode baru akan di input. Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim insert As String = "insert into jurnal values('" & Lkode.Text & "','" & Format(DTP1.Value, "yyyy-MM-dd") & "','" & Format(DTP2.Value, "yyyy-MM-dd") & "','" & Tnamart.Text & "','" & ldebet.Text & "')"

                    cmd = New OdbcCommand(insert, conn)
                    dr = cmd.ExecuteReader
                    Call tampilgrid()
                    MsgBox("Data berhasil diinput!")
                End If
            End If
        End If



    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call kosongkan()

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub DGV_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        Lkode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call carikode()
        If dr.HasRows Then
            If MessageBox.Show("Data jurnal yang anda klik akan dihapus, Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("delete from jurnal where id_jurnal='" & Lkode.Text & "'", conn)
                dr = cmd.ExecuteReader
                MsgBox("Data berhasil dihapus!")
                Call tampilgrid()

            End If
        Else
            MsgBox("Jika ingin menghapus, klik dahulu data ditable")
        End If

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosongkan()
    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGV.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call carikode()
            If dr.HasRows Then
                If MessageBox.Show("Data jurnal yang anda klik akan dihapus, Apakah anda yakin?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmd = New OdbcCommand("delete from jurnal where id_jurnal='" & Lkode.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    MsgBox("Data berhasil dihapus!")
                    Call tampilgrid()

                End If
            Else
                MsgBox("Jika ingin menghapus, klik dahulu data ditable")
            End If
        End If
    End Sub

  
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call caridebet()

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If labelkode.Text = "" Then

            MsgBox("Jika ingin memambahkan keterangan, silakan klik kode di table terlebih dahulu")
        Else

            keteranganjurnal.Show()

        End If
    End Sub
End Class