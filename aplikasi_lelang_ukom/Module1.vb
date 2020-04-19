Imports System.Data.Odbc
Module Module1
    Public cmd As OdbcCommand
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public dr As OdbcDataReader

    Public Sub koneksi()
        conn = New OdbcConnection("dsn=aplikasi_lelang")
        conn.Open()
    End Sub
    Public username As String
    Public Sub validasiusername()
        Call koneksi()
        cmd = New OdbcCommand("select * from masyarakat where username = '" & username & "'", conn)
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            Call koneksi()
            cmd = New OdbcCommand("select * from petugas where username = '" & username & "'", conn)
            If dr.HasRows Then
                MessageBox.Show("Username Sudah digunakan")
                Exit Sub
            End If
        Else
            MessageBox.Show("Username Sudah digunakan")
            Exit Sub
        End If
    End Sub
End Module
'select barang.nama_barang, barang.harga_awal , lelang.id_lelang,lelang.id_barang , max(history_lelang.penawaran_harga), count(history_lelang.penawaran_harga) from barang join lelang on barang.id_barang = lelang.id_barang right join history_lelang on history_lelang.id_lelang = lelang.id_lelang group by lelang.id_lelang
'sesudah
'select barang.nama_barang, barang.harga_awal , lelang.id_lelang,lelang.id_barang , max(history_lelang.penawaran_harga), count(history_lelang.penawaran_harga) from barang left join lelang on barang.id_barang = lelang.id_barang left join history_lelang on history_lelang.id_lelang = lelang.id_lelang group by history_lelang.id_lelang

'menuutama sebelum
'select barang.nama_barang, barang.harga_awal , lelang.id_lelang,lelang.id_barang , max(history_lelang.penawaran_harga), count(history_lelang.penawaran_harga) from barang join lelang on barang.id_barang = lelang.id_barang join history_lelang on history_lelang.id_lelang = lelang.id_lelang group by lelang.id_lelang

'select barang.nama_barang, barang.harga_awal , lelang.id_lelang,lelang.id_barang , max(history_lelang.penawaran_harga), count(history_lelang.penawaran_harga) from barang left join lelang on barang.id_barang = lelang.id_barang left join history_lelang on history_lelang.id_lelang = lelang.id_lelang group by history_lelang.id_lelang