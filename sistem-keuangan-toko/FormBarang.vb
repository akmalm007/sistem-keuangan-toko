Imports MySql.Data.MySqlClient
Public Class FormBarang

    Public Shared selectedItem As String
    Public Shared selectedTableBarang
    Public Shared selectedTableBarang_Nama As String

    Public Shared Barang As ClassBarang
    Public id_barang As Integer

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarang
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Barang = New ClassBarang()
        ResultDGV()
        Txt_NamaBarang.Text = Barang.GSNamaBarangProperty
        Txt_stock.Text = Barang.GSStockProperty
        Txt_harga.Text = Barang.GShargaBarangProperty
        'Date_Masuk.Format = DateTimePickerFormat.Custom
        'Date_Masuk.CustomFormat = "yyyy/mm/dd"
        'Date_Masuk.Value = Barang.GStanggalMasukBarangProperty
        'Date_Kadaluarsa.Value = Barang.GStanggalkadaluarsaBarangProperty


    End Sub

    Sub ResultDGV()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM barang ORDER BY id_barang"
        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)
        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_Barang.DataSource = dTabel
        End If
        With DGV_Barang
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Barang"
            .Columns(2).HeaderText = "Stock"
            .Columns(3).HeaderText = "Harga"
            .Columns(4).HeaderText = "Tanggal Masuk"
            .Columns(5).HeaderText = "Tanggal Kadaluarsa"
        End With
        myconnection.close()
    End Sub

    Private Sub Btn_TambahBarang_Click(sender As Object, e As EventArgs) Handles Btn_TambahBarang.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "INSERT INTO barang(nama_barang, stock,harga,
                                tanggal_masuk, tanggal_kadaluarsa)
                                VALUES('" _
                                & Txt_NamaBarang.Text & "', '" _
                                & Txt_stock.Text & "', '" _
                                & Txt_harga.Text & "', '" _
                                & Date_Masuk.Value.ToString("yyyy/MM/dd") & "', '" _
                                & Date_Kadaluarsa.Value.ToString("yyyy/MM/dd") & "')"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        ResultDGV()
        MsgBox("Data tersimpan !", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub

    Private Sub Btn_UpdateBarang_Click(sender As Object, e As EventArgs) Handles Btn_UpdateBarang.Click
        'Dim selectedBarang As List(Of String) = Barang.GetDataKoleksiByIDDatabase(selectedTableBarang)

        ''Dim ID As Integer = selectedBarang(0)
        'Barang.GSNamaBarangProperty = selectedBarang(1)
        'Barang.GSStockProperty = selectedBarang(2)
        'Barang.GShargaBarangProperty = selectedBarang(3)
        'Barang.GStanggalMasukBarangProperty = selectedBarang(4)
        'Barang.GStanggalkadaluarsaBarangProperty = selectedBarang(5)

        mycmd.Connection = myconnection.open
        mycmd.CommandText = "UPDATE barang SET " &
                        “nama_barang='" & Txt_NamaBarang.Text & "', " &
                        “stock='" & Txt_stock.Text & "', " &
                        “harga='" & Txt_harga.Text & "', " &
                        “tanggal_masuk='" & Date_Masuk.Value.ToString("yyyy/MM/dd") & "', " &
                        “tanggal_kadaluarsa='" & Date_Kadaluarsa.Value.ToString("yyyy/MM/dd") & "' " &
                        "WHERE id_barang='" & id_barang & "' "
        mycmd.ExecuteNonQuery()
        myconnection.close()

        'Barang.UpdateDataBarangByIODatabase(id_barang, Txt_NamaBarang.Text, Txt_stock.Text, Txt_harga.Text, Date_Masuk.Value.ToString("yyyy/MM/dd"), Date_Kadaluarsa.Value.ToString("yyyy/MM/dd"))
        ResultDGV()
        MsgBox("Data terupdate !", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub

    Private Sub Btn_HapusBarang_Click(sender As Object, e As EventArgs) Handles Btn_HapusBarang.Click
        'Dim ID As Integer
        mycmd.Connection = myconnection.open
        mycmd.CommandText = “DELETE FROM barang “ &
                       “WHERE id_barang='" & id_barang & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        ResultDGV()
        MsgBox("Data terhapus !", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub

    Private Sub DGV_Barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Barang.CellClick
        Dim DGVIndex As Integer
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DGV_Barang.Rows(DGVIndex)

        With DGV_Barang
            If e.RowIndex >= 0 Then
                DGVIndex = .CurrentRow.Index
                id_barang = .Rows(DGVIndex).Cells(0).Value.ToString
                Txt_NamaBarang.Text = .Rows(DGVIndex).Cells(1).Value.ToString
                Txt_stock.Text = .Rows(DGVIndex).Cells(2).Value.ToString
                Txt_harga.Text = .Rows(DGVIndex).Cells(3).Value.ToString
                Date_Masuk.Value = .Rows(DGVIndex).Cells(4).Value.ToString
                Date_Kadaluarsa.Value = .Rows(DGVIndex).Cells(5).Value.ToString
            End If
        End With
    End Sub

    Private Sub TSMenu_FormJenisBarang_Click(sender As Object, e As EventArgs) Handles TSMenu_FormJenisBarang.Click
        'Dim formJenis = New FormJenisBarang()
        'formJenis.Show()
    End Sub

    Private Sub TSMenu_FormPenjualan_Click(sender As Object, e As EventArgs) Handles TSMenu_FormPenjualan.Click
        'Dim formPenjualan = New FormPenjualan()
        'formPenjualan.Show()
    End Sub

    '    Public Sub updatedatatable()
    '        DGV_Barang.Rows.Clear()
    '        For Each rowkoleksi In Barang.getBarangDataTable()
    '            Dim datatable As String() = {rowkoleksi(1),
    '                                        rowkoleksi(2),
    '                                        rowkoleksi(3),
    '                                        rowkoleksi(4),
    '                                        rowkoleksi(5),
    '                                        rowkoleksi(6),
    '                                        rowkoleksi(7),
    '                                        rowkoleksi(8),
    '                                        rowkoleksi(9)}
    '            DGV_Barang.Rows.Add(datatable)
    '        Next
    '    End Sub

    '    Private Sub dgv_barang_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Barang.CellClick
    '        Dim index As Integer = e.RowIndex
    '        Dim selectedrow As DataGridViewRow
    '        selectedrow = DGV_Barang.Rows(index)

    '        selectedTableBarang = selectedrow.Cells(0).Value
    '        selectedTableBarang_Nama = selectedrow.Cells(1).Value
    '    End Sub


End Class
