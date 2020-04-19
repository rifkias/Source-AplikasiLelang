Imports System.Data.Odbc
Public Class petugas
    Private Sub petugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call idauto()
        Call level()
    End Sub
    Sub caridata()
        Call koneksi()
        cmd = New OdbcCommand("select * from petugas where id_petugas = '" & iduser.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        GunaLineTextBox1.Text = dr(1)
        GunaLineTextBox2.Text = dr(2)
        GunaLineTextBox4.Text = dr(3)
        GunaLineTextBox3.Text = dr(4)
        GunaLabel6.Text = dr(6)
        GunaPictureBox1.Load(dr(6))
        id_level.Text = dr(5)
        Call koneksi()
        cmd = New OdbcCommand("select * from level where id_level = '" & id_level.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        GunaComboBox1.Text = dr(1)
    End Sub
    Sub level()
        Call koneksi()
        cmd = New OdbcCommand("select * from level", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            GunaComboBox1.Items.Add(dr(1))
        Loop
    End Sub
    Sub idauto()
        Call koneksi()
        cmd = New OdbcCommand(" select id_petugas from petugas order by id_petugas DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            iduser.Text = "PTG-" + "1"
        Else
            Dim kanan As String = Len(dr(0)) - 4
            Dim isi As String = Microsoft.VisualBasic.Right(dr(0), kanan) + 1
            iduser.Text = "PTG-" + isi.ToString
        End If
    End Sub
    Sub gambar()
        GunaPictureBox1.Load(GunaLabel6.Text)
        GunaPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Reset()
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "(*.jpg) | *.jpg | (*.png) | *.png"
        GunaPictureBox1.Text = GunaPictureBox1.Text + "<img>" + OpenFileDialog1.FileName + "</img>"
        GunaLabel6.Text = OpenFileDialog1.FileName
        Call gambar()
    End Sub

    Private Sub GunaLineTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.GotFocus
        If GunaLineTextBox1.Text = "Nama Lengkap" Then
            GunaLineTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.LostFocus
        If Trim(GunaLineTextBox1.Text) = "" Then
            GunaLineTextBox1.Text = "Nama Lengkap"
        End If
    End Sub
    Private Sub GunaLineTextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox2.GotFocus
        If GunaLineTextBox2.Text = "Username" Then
            GunaLineTextBox2.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox2.LostFocus
        If Trim(GunaLineTextBox2.Text) = "" Then
            GunaLineTextBox2.Text = "Username"
        End If
    End Sub

    Private Sub GunaLineTextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox3.GotFocus
        If GunaLineTextBox3.Text = "Telpon" Then
            GunaLineTextBox3.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox3.LostFocus
        If Trim(GunaLineTextBox3.Text) = "" Then
            GunaLineTextBox3.Text = "Telpon"
        End If
    End Sub

    Private Sub GunaLineTextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox4.GotFocus
        If GunaLineTextBox4.Text = "Password" Then
            GunaLineTextBox4.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox4.LostFocus
        If Trim(GunaLineTextBox4.Text) = "" Then
            GunaLineTextBox4.Text = "Password"
        End If
    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        If GunaLineTextBox1.Text = "Nama Lengkap" Or GunaLineTextBox2.Text = "Username" Or GunaLineTextBox4.Text = "Password" Or GunaLineTextBox3.Text = "Telpon" Or GunaComboBox1.Text = "" Or GunaLabel6.Text = "" Then
            MessageBox.Show("Data harap diisi terlebih dahulu")
            Exit Sub
        Else
            Call koneksi()
            cmd = New OdbcCommand("select * from petugas where id_petugas = '" & iduser.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Call koneksi()
                cmd = New OdbcCommand("select * from petugas where username = '" & GunaLineTextBox2.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MessageBox.Show("Username Sudah digunakan silakan ganti")
                    GunaLineTextBox2.Text = ""
                    Exit Sub
                Else
                    Call koneksi()
                    cmd = New OdbcCommand("select * from masyarakat where username = '" & GunaLineTextBox2.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        MessageBox.Show("Username Sudah digunakan silakan ganti")
                        GunaLineTextBox2.Text = ""
                        Exit Sub
                    Else
                        Dim oldtext As String = GunaLabel6.Text
                        Dim newtext As String
                        newtext = oldtext.Replace("\", "\\")
                        Call koneksi()
                        cmd = New OdbcCommand("update petugas set nama_petugas='" & GunaLineTextBox1.Text & "',username='" & GunaLineTextBox2.Text & "',password='" & GunaLineTextBox4.Text & "',telpon='" & GunaLineTextBox3.Text & "',id_level='" & id_level.Text & "',foto='" & newtext & "'", conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Akun berhasil diubah")
                        Call menuutama.datapetugas()
                        Me.Close()
                    End If
                End If
            Else
                Call koneksi()
                cmd = New OdbcCommand("select * from petugas where username = '" & GunaLineTextBox2.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MessageBox.Show("Username Sudah digunakan silakan ganti")
                    GunaLineTextBox2.Text = ""
                    Exit Sub
                Else
                    Call koneksi()
                    cmd = New OdbcCommand("select * from masyarakat where username = '" & GunaLineTextBox2.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        MessageBox.Show("Username Sudah digunakan silakan ganti")
                        GunaLineTextBox2.Text = ""
                        Exit Sub
                    Else
                        Dim oldtext As String = GunaLabel6.Text
                        Dim newtext As String
                        newtext = oldtext.Replace("\", "\\")
                        Call koneksi()
                        cmd = New OdbcCommand("insert into petugas values('" & iduser.Text & "','" & GunaLineTextBox1.Text & "','" & GunaLineTextBox2.Text & "','" & GunaLineTextBox4.Text & "','" & GunaLineTextBox3.Text & "','" & id_level.Text & "','" & newtext & "')", conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Akun berhasil didaftarkan")
                        Call menuutama.datapetugas()
                        Me.Close()

                    End If
                End If
            End If
            End If
    End Sub
    Private Sub GunaComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from level where level = '" & GunaComboBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        id_level.Text = dr(0)
    End Sub

End Class