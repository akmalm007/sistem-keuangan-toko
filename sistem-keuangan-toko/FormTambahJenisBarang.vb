Public Class FormTambahJenisBarang
    Private Sub BtnTambahJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnTambahJenisBarang.Click

        FormJenisBarang.jenisbarang.namaJenisBarangProperty = TxtTambahJenisBarang.Text.ToString()

        FormJenisBarang.jenisbarang.AddDataJenisBarangDatabase(FormJenisBarang.jenisbarang.namaJenisBarangProperty)

        Me.Close()
    End Sub

End Class