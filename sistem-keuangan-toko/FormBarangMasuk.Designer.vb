<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarangMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_Penjualan = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PilihFormLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormJenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Cari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_ID_Barang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Date_BarangMasuk = New System.Windows.Forms.DateTimePicker()
        Me.Txt_JumlahBarang_Masuk = New System.Windows.Forms.TextBox()
        Me.Btn_TambahBarangMasuk = New System.Windows.Forms.Button()
        Me.Btn_UpdateBarangMasuk = New System.Windows.Forms.Button()
        Me.Btn_HapusBarangMasuk = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGV_Penjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Penjualan
        '
        Me.DGV_Penjualan.BackgroundColor = System.Drawing.Color.SaddleBrown
        Me.DGV_Penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Penjualan.Location = New System.Drawing.Point(19, 288)
        Me.DGV_Penjualan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_Penjualan.Name = "DGV_Penjualan"
        Me.DGV_Penjualan.RowHeadersWidth = 51
        Me.DGV_Penjualan.RowTemplate.Height = 29
        Me.DGV_Penjualan.Size = New System.Drawing.Size(678, 202)
        Me.DGV_Penjualan.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihFormLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 25)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PilihFormLainnyaToolStripMenuItem
        '
        Me.PilihFormLainnyaToolStripMenuItem.BackColor = System.Drawing.Color.PapayaWhip
        Me.PilihFormLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_FormJenisBarang, Me.TSMenu_FormPenjualan, Me.FormPenjualanToolStripMenuItem})
        Me.PilihFormLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihFormLainnyaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PilihFormLainnyaToolStripMenuItem.Name = "PilihFormLainnyaToolStripMenuItem"
        Me.PilihFormLainnyaToolStripMenuItem.Size = New System.Drawing.Size(154, 21)
        Me.PilihFormLainnyaToolStripMenuItem.Text = "Pilih Form Lainnya"
        '
        'TSMenu_FormJenisBarang
        '
        Me.TSMenu_FormJenisBarang.Name = "TSMenu_FormJenisBarang"
        Me.TSMenu_FormJenisBarang.Size = New System.Drawing.Size(212, 22)
        Me.TSMenu_FormJenisBarang.Text = "Form Jenis Barang"
        '
        'TSMenu_FormPenjualan
        '
        Me.TSMenu_FormPenjualan.Name = "TSMenu_FormPenjualan"
        Me.TSMenu_FormPenjualan.Size = New System.Drawing.Size(212, 22)
        Me.TSMenu_FormPenjualan.Text = "Form Barang"
        '
        'FormPenjualanToolStripMenuItem
        '
        Me.FormPenjualanToolStripMenuItem.Name = "FormPenjualanToolStripMenuItem"
        Me.FormPenjualanToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FormPenjualanToolStripMenuItem.Text = "Form Penjualan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.Btn_Cari)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_ID_Barang)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Date_BarangMasuk)
        Me.Panel1.Controls.Add(Me.Txt_JumlahBarang_Masuk)
        Me.Panel1.Location = New System.Drawing.Point(19, 50)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 134)
        Me.Panel1.TabIndex = 26
        '
        'Btn_Cari
        '
        Me.Btn_Cari.BackColor = System.Drawing.Color.Orange
        Me.Btn_Cari.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Btn_Cari.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Cari.Location = New System.Drawing.Point(348, 22)
        Me.Btn_Cari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(66, 22)
        Me.Btn_Cari.TabIndex = 21
        Me.Btn_Cari.Text = "Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(17, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ID Barang"
        '
        'Txt_ID_Barang
        '
        Me.Txt_ID_Barang.Location = New System.Drawing.Point(196, 24)
        Me.Txt_ID_Barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_ID_Barang.Name = "Txt_ID_Barang"
        Me.Txt_ID_Barang.Size = New System.Drawing.Size(148, 23)
        Me.Txt_ID_Barang.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Jumlah Barang Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(17, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Barang Masuk"
        '
        'Date_BarangMasuk
        '
        Me.Date_BarangMasuk.Location = New System.Drawing.Point(196, 92)
        Me.Date_BarangMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Date_BarangMasuk.Name = "Date_BarangMasuk"
        Me.Date_BarangMasuk.Size = New System.Drawing.Size(219, 23)
        Me.Date_BarangMasuk.TabIndex = 14
        '
        'Txt_JumlahBarang_Masuk
        '
        Me.Txt_JumlahBarang_Masuk.Location = New System.Drawing.Point(196, 58)
        Me.Txt_JumlahBarang_Masuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_JumlahBarang_Masuk.Name = "Txt_JumlahBarang_Masuk"
        Me.Txt_JumlahBarang_Masuk.Size = New System.Drawing.Size(219, 23)
        Me.Txt_JumlahBarang_Masuk.TabIndex = 7
        '
        'Btn_TambahBarangMasuk
        '
        Me.Btn_TambahBarangMasuk.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_TambahBarangMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TambahBarangMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_TambahBarangMasuk.Location = New System.Drawing.Point(500, 69)
        Me.Btn_TambahBarangMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_TambahBarangMasuk.Name = "Btn_TambahBarangMasuk"
        Me.Btn_TambahBarangMasuk.Size = New System.Drawing.Size(197, 22)
        Me.Btn_TambahBarangMasuk.TabIndex = 27
        Me.Btn_TambahBarangMasuk.Text = "Tambah Barang Masuk"
        Me.Btn_TambahBarangMasuk.UseVisualStyleBackColor = False
        '
        'Btn_UpdateBarangMasuk
        '
        Me.Btn_UpdateBarangMasuk.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_UpdateBarangMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_UpdateBarangMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_UpdateBarangMasuk.Location = New System.Drawing.Point(500, 103)
        Me.Btn_UpdateBarangMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_UpdateBarangMasuk.Name = "Btn_UpdateBarangMasuk"
        Me.Btn_UpdateBarangMasuk.Size = New System.Drawing.Size(197, 22)
        Me.Btn_UpdateBarangMasuk.TabIndex = 28
        Me.Btn_UpdateBarangMasuk.Text = "Update Barang Masuk"
        Me.Btn_UpdateBarangMasuk.UseVisualStyleBackColor = False
        '
        'Btn_HapusBarangMasuk
        '
        Me.Btn_HapusBarangMasuk.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_HapusBarangMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_HapusBarangMasuk.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_HapusBarangMasuk.Location = New System.Drawing.Point(500, 137)
        Me.Btn_HapusBarangMasuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_HapusBarangMasuk.Name = "Btn_HapusBarangMasuk"
        Me.Btn_HapusBarangMasuk.Size = New System.Drawing.Size(197, 22)
        Me.Btn_HapusBarangMasuk.TabIndex = 29
        Me.Btn_HapusBarangMasuk.Text = "Hapus Barang Masuk"
        Me.Btn_HapusBarangMasuk.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(36, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Form Barang Masuk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(286, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Database Penjualan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(477, 191)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 82)
        Me.Panel2.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(4, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 45)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(33, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 57)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pastikan Inputan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID Barang sesuai dengan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yang ada di database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Label1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 15)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "ID Barang yang terpilih :"
        '
        'FormBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(721, 499)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_HapusBarangMasuk)
        Me.Controls.Add(Me.Btn_UpdateBarangMasuk)
        Me.Controls.Add(Me.Btn_TambahBarangMasuk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DGV_Penjualan)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormBarangMasuk"
        Me.Text = "Form Barang Masuk"
        CType(Me.DGV_Penjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Penjualan As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PilihFormLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMenu_FormJenisBarang As ToolStripMenuItem
    Friend WithEvents TSMenu_FormPenjualan As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Date_BarangMasuk As DateTimePicker
    Friend WithEvents Txt_JumlahBarang_Masuk As TextBox
    Friend WithEvents Btn_TambahBarangMasuk As Button
    Friend WithEvents Btn_UpdateBarangMasuk As Button
    Friend WithEvents Btn_HapusBarangMasuk As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_ID_Barang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FormPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Cari As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
