Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class FormBarangMasuk
    Public CheckIDKasir As Boolean 'Cek ID Kasir valid?
    Public CheckIDBarang As Boolean 'Cek ID Kasir valid?
    Public CheckJumlahBarang As Boolean 'Cek ID Kasir valid?
    Public CheckTanggalMasuk As Boolean 'Cek ID Kasir valid?

    Public id_barang_masuk As Integer
    Public id_barang As Integer

    'Entah kenapa gak konek dari class barang
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;username=root;password='';database='sistem-keuangan-toko';Convert Zero Datetime=True")
    End Function
    Public strcon As MySqlConnection

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarang
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ResultDGV()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub CheckID()

        'Mengecek Apabila ID Barang sudah benar formatnya
        If Not Regex.Match(Txt_ID_Barang.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only Numbers

            MessageBox.Show("Isi ID_Barang dengan Angka Saja!") 'Inform User

            Txt_ID_Barang.Focus() 'Return Focus
            Txt_ID_Barang.Clear() 'Clear TextBox

            CheckIDBarang = False 'Boolean = False
        Else

            CheckIDBarang = True 'Everything Fine

        End If


    End Sub

    'Public Sub reloadtext(ByVal sql As String)
    '    Try
    '        strcon.Open()
    '        With mycmd
    '            .Connection = strcon
    '            .CommandText = sql
    '        End With
    '        dTabel = New DataTable
    '        dadapter = New MySqlDataAdapter
    '        dadapter.Fill(dTabel)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message & "reloadText")
    '    Finally
    '        If strcon.State = ConnectionState.Open Then
    '            strcon.Close()
    '            dTabel.Dispose()
    '        End If
    '    End Try
    'End Sub

    Sub ResultDGV()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT barang_masuk.id_barang_masuk, barang_masuk.id_barang, barang.stock, barang_masuk.jumlah_barang_masuk, barang_masuk.tanggal_barang_masuk FROM barang_masuk INNER JOIN barang ON barang_masuk.id_barang = barang.id_barang ORDER BY tanggal_barang_masuk"

        '        Select Case Orders.OrderID, Customers.CustomerName, Orders.OrderDate
        'From Orders
        'INNER Join Customers ON Orders.CustomerID=Customers.CustomerID;

        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)
        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_Penjualan.DataSource = dTabel

            With DGV_Penjualan
                .Columns(0).HeaderText = "ID_Barang_Masuk"
                .Columns(1).HeaderText = "ID Barang"
                .Columns(2).HeaderText = "Stock"
                .Columns(3).HeaderText = "Jumlah Barang"
                .Columns(4).HeaderText = "Tanggal Barang Masuk"
            End With
        End If

        myconnection.close()
    End Sub

    Private Sub Btn_TambahPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_TambahBarangMasuk.Click
        'Mengecek Sudah keisi atau belum
        Try
            If Txt_ID_Barang.Text = "" Then
                MessageBox.Show("ID Kosong! Mohon diisi sesuai yang ada dalam database", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CheckID() 'Ngecek formatnya dulu
                'reloadtext("SELECT * FROM penjualan WHERE id_penjualan='" & Txt_ID_Barang.Text & "'")
                mycmd.Connection = myconnection.open
                mycmd.CommandText = "INSERT INTO barang_masuk(id_barang, jumlah_barang_masuk, tanggal_barang_masuk)
                                            VALUES('" _
                                        & Txt_ID_Barang.Text & "', '" _
                                        & Txt_JumlahBarang_Masuk.Text & "', '" _
                                        & Date_BarangMasuk.Value.ToString("yyyy/MM/dd") & "')"



                mycmd.ExecuteNonQuery()
                myconnection.close()
                ResultDGV()
                MsgBox("Data Penjualan tersimpan!", MsgBoxStyle.Information, "Pemberitahuan Tambah Penjualan")
                'Else
                '    MessageBox.Show("ID tidak tersedia dalam database", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Btn_UpdatePenjualan_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBarangMasuk.Click

        '    'Jangan dibuka
        '    'Dim selectedBarang As List(Of String) = Barang.GetDataKoleksiByIDDatabase(selectedTableBarang)

        '    ''Dim ID As Integer = selectedBarang(0)
        '    'Barang.GSNamaBarangProperty = selectedBarang(1)
        '    'Barang.GSStockProperty = selectedBarang(2)
        '    'Barang.GShargaBarangProperty = selectedBarang(3)
        '    'Barang.GStanggalMasukBarangProperty = selectedBarang(4)
        '    'Barang.GStanggalkadaluarsaBarangProperty = selectedBarang(5)

        CheckID()

        mycmd.Connection = myconnection.open
        mycmd.CommandText = "UPDATE barang_masuk SET " &
                        “barang.id_barang =='" & Txt_ID_Barang.Text & "', " &
                        “jumlah_barang_masuk='" & Txt_JumlahBarang_Masuk.Text & "', " &
                        “tanggal_barang_masuk='" & Date_BarangMasuk.Value.ToString("yyyy/MM/dd") & "' " &
                        "WHERE id_barang_masuk='" & id_barang_masuk & "' "

        '     Update barang_masuk
        'SET barang_masuk.jumlah_barang_masuk = Txt_ID_Barang.Text + barang.stock

        'From barang_masuk  INNER Join barang On barang_masuk.id_barang_masuk = barang.id_barang

        'Update barang_masuk, barang
        '            SET barang_masuk.jumlah_barang_masuk = barang.stock
        '                WHERE barang_masuk.id_barang = barang.id_barang;


        mycmd.ExecuteNonQuery()
        myconnection.close()

        'Barang.UpdateDataBarangByIODatabase(id_barang, Txt_NamaBarang.Text, Txt_stock.Text, Txt_harga.Text, Date_Masuk.Value.ToString("yyyy/MM/dd"), Date_Kadaluarsa.Value.ToString("yyyy/MM/dd"))
        ResultDGV()
        MsgBox("Data terupdate !", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub

    Private Sub Btn_HapusPenjualan_Click(sender As Object, e As EventArgs) Handles Btn_HapusBarangMasuk.Click
        'Dim ID As Integer
        CheckID()

        mycmd.Connection = myconnection.open
        mycmd.CommandText = “DELETE FROM barang_masuk “ &
                       “WHERE id_barang_masuk='" & id_barang_masuk & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        ResultDGV()
        MsgBox("Data terhapus !", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub

    Private Sub DGV_Penjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Penjualan.CellClick
        Dim DGVIndex As Integer
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DGV_Penjualan.Rows(DGVIndex)

        With DGV_Penjualan
            If e.RowIndex >= 0 Then
                DGVIndex = .CurrentRow.Index
                Label1.Text = .Rows(DGVIndex).Cells(0).Value.ToString
                id_barang_masuk = .Rows(DGVIndex).Cells(0).Value.ToString
                Txt_ID_Barang.Text = .Rows(DGVIndex).Cells(1).Value.ToString
                Txt_JumlahBarang_Masuk.Text = .Rows(DGVIndex).Cells(3).Value.ToString
                Date_BarangMasuk.Value = .Rows(DGVIndex).Cells(4).Value.ToString
            End If
        End With
    End Sub

    Private Sub TSMenu_FormJenisBarang_Click(sender As Object, e As EventArgs) Handles TSMenu_FormJenisBarang.Click
        'Dim formJenis = New FormJenisBarang()
        'formJenis.Show()
    End Sub

    Private Sub TSMenu_FormPenjualan_Click(sender As Object, e As EventArgs) Handles TSMenu_FormPenjualan.Click
        Dim formPenjualan = New FormPenjualan()
        formPenjualan.Show()
    End Sub

    Private Sub FormPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormPenjualanToolStripMenuItem.Click
        Dim formpenjualan = New FormPenjualan()
        formpenjualan.Show()
    End Sub

    Private Sub Btn_Cari_Click(sender As Object, e As EventArgs) Handles Btn_Cari.Click
        Dim caribarang = New FormCariBarang()
        caribarang.Show()
    End Sub

    Private Sub FormPenjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Txt_ID_Barang.Text = FormCariBarang.id_barang_pilih
    End Sub

End Class