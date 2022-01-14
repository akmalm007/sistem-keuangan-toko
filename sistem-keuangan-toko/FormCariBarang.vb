Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class FormCariBarang
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;username=root;password='';database='sistem-keuangan-toko';Convert Zero Datetime=True")
    End Function
    Public strcon As MySqlConnection

    Dim mycmd As New MySqlCommand
    Dim myconnection As New ClassBarang
    Dim dadapter As MySqlDataAdapter
    Dim dTabel As New DataTable

    Public CheckIDBarang As Boolean
    Dim checkboxcol As New DataGridViewCheckBoxColumn

    Public Shared id_barang_pilih As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ResultDGV()
    End Sub

    Sub CheckID()
        'Mengecek Apabila ID Barang sudah benar formatnya
        If Not Regex.Match(Txt_IDBarang.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Isi ID_Barang dengan Angka Saja!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_IDBarang.Focus()
            Txt_IDBarang.Clear()
            CheckIDBarang = False
        Else
            CheckIDBarang = True
        End If
    End Sub

    Sub CheckNama()
        'Mengecek apabila Nama sudah benar formatnya
    End Sub

    Sub ResultDGV()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "SELECT * FROM barang ORDER BY id_barang"
        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)
        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_CariBarang.DataSource = dTabel
        End If
        With DGV_CariBarang
            .Columns(0).HeaderText = "ID_Barang"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Jumlah Barang"
            .Columns(3).HeaderText = "Tanggal Penjualan"

        End With
        myconnection.close()
    End Sub

    Public Sub FilterData(searchvalueID As String, searchvalueNama As String)
        'mycmd.Connection = myconnection.open

        'Debug.WriteLine(mycmd.CommandText)

        'mycmd.ExecuteNonQuery()
        'myconnection.close()

        'dadapter.Fill(dTabel)
        mycmd.Connection = myconnection.open
        'mycmd.CommandText = "SELECT * FROM barang ORDER BY id_barang"
        If searchvalueID IsNot Nothing Then
            If searchvalueID Is Nothing Then
                MessageBox.Show("ID tidak ditemukan")
            Else
                mycmd.CommandText = "SELECT * FROM barang " &
                           "WHERE id_barang='" & searchvalueID & "'"
            End If

        ElseIf searchvalueNama IsNot Nothing Then
            If searchvalueNama Is Nothing Then
                MessageBox.Show("Nama tidak ditemukan")
            Else
                mycmd.CommandText = "SELECT * FROM barang " &
                                    "WHERE nama_barang='" & searchvalueNama & "'"
            End If
        End If
        dadapter = New MySqlDataAdapter(mycmd)
        dTabel.Rows.Clear()
        dadapter.Fill(dTabel)
        If Not dTabel Is Nothing AndAlso dTabel.Rows.Count > 0 Then
            DGV_CariBarang.DataSource = dTabel
        End If
        With DGV_CariBarang
            .Columns(0).HeaderText = "ID_Barang"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Jumlah Barang"
            .Columns(3).HeaderText = "Tanggal Penjualan"

        End With
        myconnection.close()

        DGV_CariBarang.DataSource = dTabel
    End Sub

    'Private Sub Btn_Search_Click(sender As Object, e As EventArgs)
    '    'CheckID()
    '    'If Txt_IDBarang.Text = "" Then
    '    '    FilterData(Nothing, Txt_NamaBarang.Text)
    '    'ElseIf Txt_NamaBarang.Text = "" Then
    '    '    FilterData(Txt_IDBarang.Text, Nothing)
    '    'Else
    '    '    MessageBox.Show("Mohon isi nama atau id sesuai yang ada dalam database", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    'End If
    'End Sub

    Private Sub DGV_CariBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CariBarang.CellClick
        Dim DGVIndex As Integer
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DGV_CariBarang.Rows(DGVIndex)

        'FormPenjualan.Txt_ID_Barang.Text = SelectedRow.Value.ToString()

        With DGV_CariBarang
            If e.RowIndex >= 0 Then
                DGVIndex = .CurrentRow.Index
                id_barang_pilih = .Rows(DGVIndex).Cells(0).Value.ToString
                Txt_IDBarang.Text = .Rows(DGVIndex).Cells(0).Value.ToString
                Txt_NamaBarang.Text = .Rows(DGVIndex).Cells(1).Value.ToString
                'Txt_NamaBarang.Text = .Rows(DGVIndex).Cells(1).Value.ToString
                'Txt_stock.Text = .Rows(DGVIndex).Cells(2).Value.ToString
                'Txt_harga.Text = .Rows(DGVIndex).Cells(3).Value.ToString
                'Date_Masuk.Value = .Rows(DGVIndex).Cells(4).Value.ToString
                'Date_Kadaluarsa.Value = .Rows(DGVIndex).Cells(5).Value.ToString
            End If
        End With

    End Sub

    Private Sub Btn_Cari_Click(sender As Object, e As EventArgs) Handles Btn_Cari.Click
        CheckID()
        If Txt_IDBarang.Text = "" Then
            FilterData(Nothing, Txt_NamaBarang.Text)
        ElseIf Txt_NamaBarang.Text = "" Then
            FilterData(Txt_IDBarang.Text, Nothing)
        Else
            MessageBox.Show("Mohon isi nama atau id sesuai yang ada dalam database", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'TryCast(DGV_CariBarang.DataSource, DataTable).DefaultView.RowFilter =
        '    String.Format("Nama Barang like '%" & Txt_NamaBarang.Text & "%'")
    End Sub

    Private Sub Btn_pilih_Click(sender As Object, e As EventArgs) Handles Btn_pilih.Click
        Me.Close()
    End Sub

    Private Sub DGV_CariBarang_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DGV_CariBarang.RowPostPaint
        If e.RowIndex < DGV_CariBarang.RowCount - 1 Then
            Dim dgvRow As DataGridViewRow = DGV_CariBarang.Rows(e.RowIndex)

            '<== This is the header Name
            'If CInt(dgvRow.Cells("EmployeeStatus_Training_e26").Value) <> 2 Then  


            '<== But this is the name assigned to it in the properties of the control
            If CInt(dgvRow.Cells(0).Value.ToString) <> 100 Then

                dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(236, 236, 255)

            Else
                dgvRow.DefaultCellStyle.BackColor = Color.LightPink

            End If

        End If
    End Sub

End Class