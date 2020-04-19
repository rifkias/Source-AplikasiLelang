Imports System.Data.Odbc
Public Class lelang
    Sub caridata()
        Call koneksi()
        cmd = New OdbcCommand("select barang.nama_barang,harga_awal,max(history_lelang.penawaran_harga),count(history_lelang.penawaran_harga) from barang,history_lelang where barang.id_barang = '" & id_barang.Text & "' and history_lelang.id_lelang ='" & id_lelang.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If IsDBNull(dr(2)) Then
                GunaLabel8.Text = "0"
            Else
                GunaLabel8.Text = dr(2)
            End If
            GunaLabel7.Text = dr(3)
            GunaLabel10.Text = dr(0)
            GunaLabel9.Text = dr(1)
        End If
    End Sub
    Sub histori()
        Call koneksi()
        cmd = New OdbcCommand("select * from history_lelang order by id_history DESC", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            id_histori.Text = "HST-" + "1"
        Else
            Dim kanan As String = Len(dr(0)) - 4
            Dim isi As String = Microsoft.VisualBasic.Right(dr(0), kanan) + 1
            id_histori.Text = "HST-" + isi.ToString
        End If
    End Sub
    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
       
        If GunaLabel8.Text = "0" Then
            If Val(GunaLineTextBox4.Text) < Val(GunaLabel9.Text) Then
                MessageBox.Show("Harga yang anda tawarkan dibawah harga awal / harga tertinggi", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                Call koneksi()
                cmd = New OdbcCommand("insert into history_lelang values('" & id_histori.Text & "','" & id_lelang.Text & "','" & id_barang.Text & "','" & menuutama.idmasyarakat.Text & "','" & GunaLineTextBox4.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Harga selamat harga sudah didaftarkan", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call menuutama.datalelang()
                Me.Close()
            End If
        Else
            If Val(GunaLineTextBox4.Text) < Val(GunaLabel8.Text) Then
                MessageBox.Show("Harga yang anda tawarkan dibawah harga awal / harga tertinggi", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf Val(GunaLineTextBox4.Text) = Val(GunaLabel8.Text) Then
                MessageBox.Show("Harga yang anda tawarkan dibawah harga awal / harga tertinggi", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                Call koneksi()
                cmd = New OdbcCommand("insert into history_lelang values('" & id_histori.Text & "','" & id_lelang.Text & "','" & id_barang.Text & "','" & menuutama.idmasyarakat.Text & "','" & GunaLineTextBox4.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Harga selamat harga sudah didaftarkan", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call menuutama.datalelang()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub GunaLineTextBox4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox4.GotFocus
        If GunaLineTextBox4.Text = "Harga Yang Ditawarkan" Then
            GunaLineTextBox4.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GunaLineTextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub GunaLineTextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaLineTextBox4.LostFocus
        If Trim(GunaLineTextBox4.Text) = "" Then
            GunaLineTextBox4.Text = "Harga Yang Ditawarkan"
        End If
    End Sub


End Class