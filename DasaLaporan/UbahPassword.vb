Imports System.Data.Odbc

Public Class UbahPassword

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub


    Private Sub UbahPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data belum lengkap")
        Else

            If TextBox2.Text = TextBox3.Text Then
                cmd = New OdbcCommand("select * from users where id_user='" & MenuUtama.panelkode.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If TextBox1.Text = dr(4) Then
                    cmd = New OdbcCommand("update users set password='" & TextBox2.Text & "' where id_user='" & MenuUtama.panelkode.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    MsgBox("Password berhasil diubah")
                    Call kosongkan()
                    Me.Close()


                Else
                    MsgBox("Password lama tidak sama")
                End If
            Else
                MsgBox("Password tidak sama")
            End If
        End If

    End Sub
End Class