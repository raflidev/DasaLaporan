Imports System.Data.Odbc


Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Call koneksi()
        cmd = New OdbcCommand("select * from users where username ='" & UsernameTextBox.Text & "' and password='" & PasswordTextBox.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Me.Visible = False
            
            MenuUtama.Show()
            MenuUtama.panelkode.Text = UCase(dr(0))
            MenuUtama.panelnama.Text = UCase(dr(1))
            MenuUtama.paneluser.Text = UCase(dr(2))
            If MenuUtama.panelnama.Text = 0 Then
                MenuUtama.Button1.Visible = False
            End If

        Else
            MsgBox("Password Salah")
            PasswordTextBox.Focus()
            Exit Sub
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
