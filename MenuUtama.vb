Imports System.Data.Odbc
Public Class MenuUtama

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        User.Show()

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Login.Show()
        Me.Visible = False


    End Sub



    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Close()

        Me.Close()

    End Sub


    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Laporan.Show()
    End Sub

    Private Sub DataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataToolStripMenuItem.Click
        Input.Show()

    End Sub


    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.UsernameTextBox.Clear()
        Login.PasswordTextBox.Clear()
        Me.Close()

        Login.Show()


    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Input.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        User.Show()

    End Sub

    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Laporan.Show()

    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Login.UsernameTextBox.Clear()
        Login.PasswordTextBox.Clear()
        Me.Close()

        Login.Show()
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Login.Close()

        Me.Close()

    End Sub

    Private Sub DetailHasilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailHasilToolStripMenuItem.Click
        User.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Jurnal.Show()

    End Sub

    Private Sub Button18_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Laporan.Show()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UbahPassword.Show()

    End Sub
End Class