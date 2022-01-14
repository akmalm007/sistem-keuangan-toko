Public Class FormHapusJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Label2.Text = FormJenisBarang.selectedTableJenisBarangNama

    End Sub

    Private Sub BtnHapusJenisBarang_Click(sender As Object, e As EventArgs) Handles BtnHapusJenisBarang.Click
        FormJenisBarang.jenisbarang.DeleteDataJenisBarangByIDDatabase(FormJenisBarang.selectedTableJenisBarang)
        Me.Close()
    End Sub

End Class