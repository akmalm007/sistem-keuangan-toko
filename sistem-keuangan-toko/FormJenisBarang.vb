﻿Public Class FormJenisBarang

<<<<<<< HEAD
    Public Shared jenisbarang As JenisBarang
    Public Shared selectedTableJenisBarang
    Public Shared selectedTableJenisBarangNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        jenisbarang = New JenisBarang()
        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub


    ''untuk membaca data di database''
    Private Sub ReloadDataTableDatabase()
        DataGridJenisBarang.DataSource = jenisbarang.GetDataJenisBarangDatabase()
    End Sub

    Private Sub FormJenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ''membaca data di database''
        ReloadDataTableDatabase()
    End Sub

    Private Sub BtnTambahJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisBarang.Click

        Dim open_formtambah = New FormTambahJenisBarang()
        open_formtambah.Show()

    End Sub

    Private Sub BtnUpdateJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenisBarang.Click
        If selectedTableJenisBarang IsNot Nothing Then
            Dim selectedJenisBarang As List(Of String) = jenisbarang.GetdataJenisBarangByIDDatabase(selectedTableJenisBarang)

            jenisbarang.namaJenisBarangProperty = selectedJenisBarang(1)

            Dim open_formupdate = New FormUpdateJenisBarang()
            open_formupdate.Show()

        End If
    End Sub

    Private Sub BtnHapusJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnHapusJenisBarang.Click

        Dim open_formhapus = New FormHapusJenisBarang()
        open_formhapus.Show()

    End Sub

    Private Sub DataGridJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisBarang.CellClick

        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridJenisBarang.Rows(index)

        selectedTableJenisBarang = selectedRow.Cells(0).Value
        selectedTableJenisBarangNama = selectedRow.Cells(1).Value

    End Sub
=======
>>>>>>> a6c4cbed797e44405a8ef423532c147ceba618b9
End Class