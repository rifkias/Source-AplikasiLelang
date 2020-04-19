Imports System.Data.Odbc
Public Class menuutama
    Private Sub menuutama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tanggal.Text = Format(Now, "dddd, dd-MM-yyyy")
    End Sub
    Sub datalelang()
        dgvlelang.ReadOnly = True
        dgvlelang.Rows.Clear()
        Dim no As Integer = 1
        Call koneksi()
        Dim max As Integer
        cmd = New OdbcCommand("SELECT barang.id_barang, barang.nama_barang , barang.harga_awal , lelang.id_lelang , MAX(history_lelang.penawaran_harga),COUNT(history_lelang.penawaran_harga) FROM barang JOIN lelang on lelang.id_barang = barang.id_barang and lelang.status = 'dibuka' LEFT JOIN history_lelang on lelang.id_lelang = history_lelang.id_lelang GROUP BY lelang.id_lelang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            If IsDBNull(dr(4)) Then
                max = 0
            Else
                max = dr(4)
            End If
            dgvlelang.Rows.Add(New String() {dr(3), dr(0), no, dr(1), dr(2), max, dr(5), "Lelang"})
            no = no + 1
        Loop
    End Sub
    Private Sub dgvlelang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlelang.CellContentClick
        If dgvlelang.Rows(e.RowIndex).Cells(0).Value = "" Then
            Exit Sub
        End If
        If e.ColumnIndex = 7 Then
            lelang.Show()
            lelang.id_barang.Text = dgvlelang.Rows(e.RowIndex).Cells(1).Value
            lelang.id_lelang.Text = dgvlelang.Rows(e.RowIndex).Cells(0).Value
            Call lelang.caridata()
            Call lelang.histori()
        End If
    End Sub
    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        If GunaPanel2.Width = 200 Then
            GunaPanel2.Width = 60
        Else
            GunaPanel2.Width = 200
        End If
    End Sub
    Private Sub GunaAdvenceButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton7.Click
        End
    End Sub

    Private Sub GunaAdvenceButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton8.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub GunaLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel2.Click
        GunaAdvenceButton1.Checked = False
        GunaAdvenceButton2.Checked = False
        GunaAdvenceButton3.Checked = False
        GunaAdvenceButton4.Checked = False
        panelhome.BringToFront()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jam.Text = Format(Now, "h:mm:ss")
    End Sub
    '=======================Masyarakat
    Private Sub GunaAdvenceButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton2.Click
        If panelmasyarakat.Dock = DockStyle.Fill Then
            panelmasyarakat.BringToFront()
            Call tampilmasyarakat()
        Else
            panelmasyarakat.Dock = DockStyle.Fill
            panelmasyarakat.BringToFront()
            Call tampilmasyarakat()
        End If
    End Sub
    Sub tampilmasyarakat()
        dgvmasyarakat.ReadOnly = True
        dgvmasyarakat.Rows.Clear()
        Call koneksi()
        cmd = New OdbcCommand("select * from masyarakat", conn)
        dr = cmd.ExecuteReader
        Dim no As Integer = 1
        Do While dr.Read
            dgvmasyarakat.Rows.Add(New String() {dr(0), no, dr(1), dr(2), dr(3), dr(4), "Edit", "Hapus"})
            no = no + 1
        Loop
    End Sub

    Private Sub GunaAdvenceButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton5.Click, GunaAdvenceButton10.Click
        masyarakat.Show()
    End Sub

    Private Sub dgvmasyarakat_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvmasyarakat.CellContentClick, GunaDataGridView1.CellContentClick
        If dgvmasyarakat.Rows(e.RowIndex).Cells(0).Value = "" Then
            Exit Sub
        End If

        If e.ColumnIndex = 7 Then
            If MessageBox.Show("Yakin mau dihapus akunnya ..?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("delete from masyarakat where id_user = '" & dgvmasyarakat.Rows(e.RowIndex).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data sudah dihapus")
                Call tampilmasyarakat()
            Else
                Exit Sub
            End If

        End If
    End Sub


    '=======================Petugas
    Sub datapetugas()
        dgvpetugas.ReadOnly = True
        dgvpetugas.Rows.Clear()
        Dim no As Integer = 1
        Call koneksi()
        cmd = New OdbcCommand("select petugas.* , level.level from level,petugas where level.id_level = petugas.id_level", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            dgvpetugas.Rows.Add(New String() {dr(0), no, dr(1), dr(2), dr(3), dr(4), dr(7), "Edit", "Hapus"})
            no = no + 1
        Loop
    End Sub
    Private Sub GunaAdvenceButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton4.Click
        panelpetugas.BringToFront()
        panelpetugas.Dock = DockStyle.Fill
        Call datapetugas()
    End Sub

    Private Sub dgvpetugas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvpetugas.CellContentClick
        If dgvpetugas.Rows(e.RowIndex).Cells(0).Value = "" Then
            Exit Sub
        End If
        If e.ColumnIndex = 7 Then
            petugas.Show()
            petugas.GunaLineTextBox2.Enabled = False
            petugas.iduser.Text = dgvpetugas.Rows(e.RowIndex).Cells(0).Value
            Call petugas.caridata()
        End If

        If e.ColumnIndex = 8 Then
            Call koneksi()
            If MessageBox.Show("Yakin ingin menghapus data ini ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("delete * from petugas where id_petugas = '" & dgvpetugas.Rows(e.RowIndex).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Exit Sub

            End If
        End If
    End Sub

    Private Sub GunaAdvenceButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton6.Click
        petugas.Show()
    End Sub
    '=======================Barang

    Sub databarang()
        dgvbarang.ReadOnly = True
        dgvbarang.Rows.Clear()
        Call koneksi()
        Dim no As Integer = 1
        cmd = New OdbcCommand("select * from barang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            dgvbarang.Rows.Add(New String() {dr(0), no, dr(1), dr(2), dr(3), dr(4), "Buka", "Hapus"})
            no = no + 1
        Loop
    End Sub
    Private Sub GunaAdvenceButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton3.Click
        panelbarang.BringToFront()
        panelbarang.Dock = DockStyle.Fill
        Call databarang()
    End Sub

    Private Sub GunaAdvenceButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton9.Click
        barang.Show()
    End Sub
    Private Sub dgvbarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbarang.CellContentClick
        If dgvbarang.Rows(e.RowIndex).Cells(0).Value = "" Then
            Exit Sub
        End If
        If e.ColumnIndex = 7 Then
            If MessageBox.Show("Yakin ingin menghapus data ini ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("delete * from barang where id_barang = '" & dgvbarang.Rows(e.RowIndex).Cells(0).Value & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If e.ColumnIndex = 6 Then
            Dim idlelang As String
            Call koneksi()
            cmd = New OdbcCommand("select * from lelang order by id_lelang DESC", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                idlelang = "LLG-" + "1"
            Else
                Dim kanan As String = Len(dr(0)) - 4
                Dim isi As String = Microsoft.VisualBasic.Right(dr(0), kanan) + 1
                idlelang = "LLG-" + isi.ToString
            End If
            Call koneksi()
            cmd = New OdbcCommand("insert into lelang values('" & idlelang & "','" & dgvbarang.Rows(e.RowIndex).Cells(0).Value & "','" & Format(Now, "yyyy-MM-dd") & "','0','-','" & labelidpetugas.Text & "','Dibuka')", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Barang sudah didaftarkan")
        End If
    End Sub
    ' Form Pelelangan
    Private Sub GunaAdvenceButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton11.Click
       
        panelhome.BringToFront()
    End Sub
    ' data lelang
    Sub datalelangs()
        dgvdatalelang.ReadOnly = True
        dgvdatalelang.Rows.Clear()
        Dim no As Integer = 1
        Call koneksi()
        Dim nama As String
        Dim iduser As String
        Dim hargatinggi As String
        If GunaComboBox1.Text = "dibuka" Then
            dgvdatalelang.Columns(8).Visible = True
            dgvdatalelang.Columns(6).HeaderText = "Pelelang"
            cmd = New OdbcCommand("SELECT barang.nama_barang , barang.harga_awal , masyarakat.nama_lengkap, lelang.id_lelang , lelang.tgl_lelang, MAX(history_lelang.penawaran_harga),COUNT(history_lelang.penawaran_harga),history_lelang.id_user FROM barang JOIN lelang on lelang.id_barang = barang.id_barang and lelang.status = 'dibuka' LEFT JOIN history_lelang on lelang.id_lelang = history_lelang.id_lelang left JOIN masyarakat on masyarakat.id_user = history_lelang.id_user GROUP BY lelang.id_lelang", conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                If IsDBNull(dr(2)) Then
                    nama = "-"
                Else
                    nama = dr(2)
                End If
                If IsDBNull(dr(5)) Then
                    hargatinggi = "0"
                Else
                    hargatinggi = dr(5)
                End If
                If IsDBNull(dr(7)) Then
                    iduser = "-"
                Else
                    iduser = dr(7)
                End If
                dgvdatalelang.Rows.Add(New String() {dr(3), iduser, no, dr(0), Format(dr(4), "dd-MM-yyyy"), hargatinggi, nama, dr(6), "Tutup Lelang"})
                no = no + 1
            Loop
        Else
            dgvdatalelang.Columns(8).Visible = False
            dgvdatalelang.Columns(6).HeaderText = "Pemenang"
            cmd = New OdbcCommand("SELECT barang.nama_barang , barang.harga_awal , masyarakat.nama_lengkap, lelang.id_lelang , lelang.tgl_lelang, MAX(history_lelang.penawaran_harga),COUNT(history_lelang.penawaran_harga),history_lelang.id_user FROM barang JOIN lelang on lelang.id_barang = barang.id_barang and lelang.status = 'ditutup' LEFT JOIN history_lelang on lelang.id_lelang = history_lelang.id_lelang left JOIN masyarakat on masyarakat.id_user = history_lelang.id_user GROUP BY lelang.id_lelang", conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                If IsDBNull(dr(2)) Then
                    nama = "-"
                Else
                    nama = dr(2)
                End If
                If IsDBNull(dr(5)) Then
                    hargatinggi = "0"
                Else
                    hargatinggi = dr(5)
                End If
                If IsDBNull(dr(7)) Then
                    iduser = "-"
                Else
                    iduser = dr(7)
                End If
                dgvdatalelang.Rows.Add(New String() {dr(3), iduser, no, dr(0), Format(dr(4), "dd-MM-yyyy"), hargatinggi, nama, dr(6), "Tutup Lelang"})
                no = no + 1
            Loop
        End If
        

    End Sub
    Private Sub GunaAdvenceButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton1.Click
        If GunaComboBox1.Text = "" Then
            GunaComboBox1.Text = "dibuka"
        End If
        paneldatalelang.Dock = DockStyle.Fill
        paneldatalelang.BringToFront()
        Call datalelangs()
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        Call datalelangs()
    End Sub

    Private Sub dgvdatalelang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdatalelang.CellContentClick
        If dgvdatalelang.Rows(e.RowIndex).Cells(0).Value = "" Then
            Exit Sub
        End If

        If e.ColumnIndex = 8 Then
            If MessageBox.Show("Yakin akan menutup sesi lelang ini ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                cmd = New OdbcCommand("update lelang set harga_akhir = '" & dgvdatalelang.Rows(e.RowIndex).Cells(5).Value & "',id_user = '" & dgvdatalelang.Rows(e.RowIndex).Cells(1).Value & "', id_petugas='" & labelidpetugas.Text & "',status='ditutup' where id_lelang = '" & dgvdatalelang.Rows(e.RowIndex).Cells(0).Value & "' ", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Lelang sudah ditutup", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call datalelangs()
            End If
        End If
    End Sub

 

    'History Lelang user
    Private Sub GunaTextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaTextBox1.GotFocus
        If GunaTextBox1.Text = "Cari Data" Then
            GunaTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GunaTextBox1.LostFocus
        If Trim(GunaTextBox1.Text) = "" Then
            GunaTextBox1.Text = "Cari Data"
        End If
    End Sub
    Sub datahistoryuser()
        dgvhistoryuser.Rows.Clear()
        Dim no As Integer = 1
        Call koneksi()
        cmd = New OdbcCommand("select barang.nama_barang,barang.harga_awal,history_lelang.penawaran_harga from barang,history_lelang where history_lelang.id_user='" & idmasyarakat.Text & "' and barang.id_barang = history_lelang.id_barang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            dgvhistoryuser.Rows.Add(New String() {no, dr(0), dr(1), dr(2)})
            no = no + 1
        Loop
    End Sub

    Private Sub GunaCircleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaCircleButton1.Click
        If GunaTextBox1.Text = "Cari Data" Then
            Call datahistoryuser()
        End If
        Call koneksi()
        Dim no As Integer = 1
        cmd = New OdbcCommand("select barang.nama_barang,barang.harga_awal,history_lelang.penawaran_harga from barang,history_lelang where history_lelang.id_user='" & idmasyarakat.Text & "' and barang.id_barang = history_lelang.id_barang and barang.nama_barang LIKE '%" & GunaTextBox1.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MessageBox.Show("Data tidak ditemukan", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call datahistoryuser()
            GunaTextBox1.Text = "Cari Data"
        Else
            dgvhistoryuser.Rows.Clear()
            Do While dr.Read
                dgvhistoryuser.Rows.Add(New String() {no, dr(0), dr(1), dr(2)})
                no = no + 1
            Loop
            GunaTextBox1.Text = "Cari Data"
        End If
    End Sub

    Private Sub GunaAdvenceButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaAdvenceButton15.Click
        panelhistoryuser.Dock = DockStyle.Fill
        panelhistoryuser.BringToFront()
        Call datahistoryuser()
    End Sub
End Class