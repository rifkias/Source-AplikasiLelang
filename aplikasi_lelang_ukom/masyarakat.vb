Imports System.Data.Odbc
Public Class masyarakat

    Private Sub masyarakat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call idauto()
        GunaLineTextBox3.MaxLength = 13
        GunaLineTextBox2.MaxLength = 25
        GunaLineTextBox1.MaxLength = 25
        GunaLineTextBox4.MaxLength = 25

    End Sub

    Sub idauto()
        Call koneksi()
        cmd = New OdbcCommand(" select id_user from masyarakat order by id_user DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            iduser.Text = "USR-" + "1"
        Else
            Dim kanan As String = Len(dr(0)) - 4
            Dim isi As String = Microsoft.VisualBasic.Right(dr(0), kanan) + 1
            iduser.Text = "USR-" + isi.ToString
        End If
    End Sub

    Private Sub GunaLineTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.GotFocus
        If GunaLineTextBox1.Text = "Nama lengkap" Then
            GunaLineTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.LostFocus
        If Trim(GunaLineTextBox1.Text) = "" Then
            GunaLineTextBox1.Text = "Nama lengkap"
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
    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        Dim notelp As String = Len(GunaLineTextBox3.Text)
        Dim noindo As String = Microsoft.VisualBasic.Left(GunaLineTextBox3.Text, 2)
        If GunaLineTextBox1.Text = "Nama lengkap" Or GunaLineTextBox2.Text = "Username" Or GunaLineTextBox4.Text = "Password" Or GunaLineTextBox3.Text = "Telpon" Then
            MessageBox.Show("Isi Dulu datanya cuyy")
        ElseIf notelp < 12 Or noindo <> "08" Then
            MessageBox.Show("Masukan no telp yang valid")
            GunaLineTextBox3.Text = "Telpon"
        Else
            Call koneksi()
            cmd = New OdbcCommand("select * from masyarakat where username = '" & GunaLineTextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            If Not dr.HasRows Then
                Call koneksi()
                cmd = New OdbcCommand("select * from petugas where username = '" & GunaLineTextBox2.Text & "'", conn)
                If dr.HasRows Then
                    GunaLineTextBox2.Text = "Username"
                    MessageBox.Show("Username Sudah digunakan")
                    Exit Sub
                Else
                    Call koneksi()
                    cmd = New OdbcCommand("insert into masyarakat values('" & iduser.Text & "','" & GunaLineTextBox1.Text & "','" & GunaLineTextBox2.Text & "','" & GunaLineTextBox4.Text & "','" & GunaLineTextBox3.Text & "')", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Akun sudah berhasil didaftarkan")
                    Call menuutama.tampilmasyarakat()
                    Me.Close()

                End If
            Else
                GunaLineTextBox2.Text = "Username"
                MessageBox.Show("Username Sudah digunakan")
                Exit Sub
            End If

           
        End If
    End Sub

  
    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        Me.Close()
    End Sub
End Class