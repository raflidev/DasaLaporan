Imports System.Data.Odbc
Public Class Laporan
    Sub tampilkode()
        cmd = New OdbcCommand("select id_jurnal from jurnal", conn)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr(0))
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "month({uangdasa.tanggal}) = (" & Month(DTP1.Text) & ") and year({uangdasa.tanggal}) = (" & Year(DTP1.Text) & ")"
        CRV.ReportSource = "LaporanBulanan.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call tampilkode()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.SelectionFormula = "{uangdasa.tanggal} in date ('" & DTP2.Text & "') to date ('" & DTP3.Text & "')"
        CRV.ReportSource = "LaporanPeriodik.rpt"
        CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.SelectionFormula = "{jurnal.id_jurnal} = " & ComboBox1.Text & ""
        CRV.ReportSource = "LaporanJurnal.rpt"
        CRV.RefreshReport()
    End Sub





End Class