Imports System.Data.Odbc
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub
    Sub bersihkan()
        username.Text = "Username"
        password.Text = "Password"
        password.PasswordChar = ""
    End Sub
    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        If username.Text = "Username" Or password.Text = "Password" Then
            MessageBox.Show("Masukan Username dan password terlebih dahulu")
            Exit Sub
        End If
        Call koneksi()
        cmd = New OdbcCommand("select * from masyarakat where username = '" & username.Text & "' and password = '" & password.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            menuutama.Show()
            menuutama.sidepaneladmin.BringToFront()
            menuutama.GunaAdvenceButton11.Checked = True
            menuutama.sidepaneladmin.Visible = False
            menuutama.panelhome.Dock = DockStyle.Fill
            menuutama.panelhome.BringToFront()
            menuutama.panelhomemasyarakat.Dock = DockStyle.Fill
            menuutama.panelhomemasyarakat.BringToFront()
            menuutama.namamasyarakat.Text = dr.Item("nama_lengkap")
            menuutama.idmasyarakat.Text = dr.Item("id_user")
            Call menuutama.datalelang()
            Call bersihkan()
            Me.Hide()
        Else
            Call koneksi()
            cmd = New OdbcCommand("select * from petugas where username= '" & username.Text & "' and password = '" & password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                menuutama.Show()
                Call bersihkan()
                menuutama.sidepaneluser.Visible = False
                menuutama.panelhome.Dock = DockStyle.Fill
                menuutama.panelhome.BringToFront()
                menuutama.panelhomeadmin.Dock = DockStyle.Fill
                menuutama.panelhomeadmin.BringToFront()
                menuutama.labelidpetugas.Text = dr!id_petugas
                menuutama.labelidlevel.Text = dr!id_level
                menuutama.GunaLabel8.Text = dr!nama_petugas
                menuutama.GunaPictureBox1.Load(dr!foto)
                Call koneksi()
                cmd = New OdbcCommand("select * from level where id_level = '" & dr!id_level & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                menuutama.GunaLabel9.Text = dr!level
                Me.Hide()
                If dr!level = "administrator" Then
                    menuutama.GunaAdvenceButton1.Visible = False
                    menuutama.shadow5.Visible = False
                    menuutama.shadow4.Visible = False
                    menuutama.dgvbarang.Columns(6).Visible = False
                Else
                    menuutama.GunaAdvenceButton4.Visible = False
                    menuutama.shadow4.Visible = False
                    menuutama.shadow2.Visible = False
                End If
            Else
                MsgBox("Username atau password tidak cocok")
                Call bersihkan()
                Exit Sub

            End If
        End If
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        masyarakat.Show()
    End Sub

    Private Sub username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles username.GotFocus
        If username.Text = "Username" Then
            username.Text = ""
        End If
    End Sub

    Private Sub username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = Chr(13) Then
            password.Focus()
        End If
    End Sub

    Private Sub username_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles username.LostFocus
        If Trim(username.Text) = "" Then
            username.Text = "Username"
        End If
    End Sub

    Private Sub password_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles password.GotFocus
        If password.Text = "Password" Then
            password.PasswordChar = "*"
            password.Text = ""
        End If
    End Sub

    Private Sub password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Chr(13) Then
            GunaButton1.PerformClick()
        End If
    End Sub

    Private Sub password_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles password.LostFocus
        If Trim(password.Text) = "" Then
            password.PasswordChar = ""
            password.Text = "Password"
        End If
    End Sub

End Class
