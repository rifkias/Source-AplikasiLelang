Imports System.Data.Odbc
Public Class barang

    Private Sub barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call idauto()
    End Sub
    Sub idauto()
        Call koneksi()
        cmd = New OdbcCommand("select * from barang order by id_barang DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            iduser.Text = "BRG-" + "1"
        Else
            Dim kanan As String = Len(dr(0)) - 4
            Dim isi As String = Microsoft.VisualBasic.Right(dr(0), kanan) + 1
            iduser.Text = "BRG-" + isi.ToString
        End If
    End Sub
    Private Sub GunaLineTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.GotFocus
        If GunaLineTextBox1.Text = "Nama Barang" Then
            GunaLineTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.LostFocus
        If Trim(GunaLineTextBox1.Text) = "" Then
            GunaLineTextBox1.Text = "Nama Barang"
        End If
    End Sub

    Private Sub GunaLineTextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox2.GotFocus
        If GunaLineTextBox2.Text = "Harga Awal" Then
            GunaLineTextBox2.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox2.LostFocus
        If Trim(GunaLineTextBox2.Text) = "" Then
            GunaLineTextBox2.Text = "Harga Awal"
        End If
    End Sub

    Private Sub RichTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.GotFocus
        If RichTextBox1.Text = "Deskripsi Barang" Then
            RichTextBox1.Text = ""
        End If
    End Sub

    Private Sub RichTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.LostFocus
        If Trim(RichTextBox1.Text) = "" Then
            RichTextBox1.Text = "Deskripsi Barang"
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        If GunaLineTextBox1.Text = "Nama Barang" Or GunaLineTextBox2.Text = "Harga Awal" Or RichTextBox1.Text = "Deskripsi Produk" Then
            MsgBox("Silakan lengkapi data terlebih dahulu")
            Exit Sub
        End If
        Call koneksi()
        cmd = New OdbcCommand("select * from barang where nama_barang = '" & GunaLineTextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Call koneksi()
            cmd = New OdbcCommand("insert into barang values('" & iduser.Text & "','" & GunaLineTextBox1.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & GunaLineTextBox2.Text & "','" & RichTextBox1.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan")
            Call menuutama.databarang()
            Me.Close()
        Else
            If MessageBox.Show("Barang sudah pernah dimasukan ingin memasukan barang yang sama ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("insert into barang values('" & iduser.Text & "','" & GunaLineTextBox1.Text & "','" & Format(Now, "yyyy-MM-dd") & "','" & GunaLineTextBox2.Text & "','" & RichTextBox1.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambahkan")
                Call menuutama.databarang()
                Me.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub
End Class