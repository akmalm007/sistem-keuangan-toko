Public Class FormUpdateJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtUpdateJenisBarang.Text = FormJenisBarang.jenisbarang.namaJenisBarangProperty

    End Sub

    Private Sub BtnUpdateJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateJenisBarang.Click

        FormJenisBarang.jenisbarang.namaJenisBarangProperty = TxtUpdateJenisBarang.Text.ToString()

        FormJenisBarang.jenisbarang.UpdateDataJenisBarangByIDDatabase(FormJenisBarang.selectedTableJenisBarang,
                                                                      FormJenisBarang.jenisbarang.namaJenisBarangProperty)

        MessageBox.Show(FormJenisBarang.jenisbarang.namaJenisBarangProperty)
    End Sub
End Class