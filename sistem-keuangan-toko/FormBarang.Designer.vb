<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DGV_Barang = New System.Windows.Forms.DataGridView()
        Me.Txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Txt_stock = New System.Windows.Forms.TextBox()
        Me.Txt_harga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Date_Masuk = New System.Windows.Forms.DateTimePicker()
        Me.Date_Kadaluarsa = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_TambahBarang = New System.Windows.Forms.Button()
        Me.Btn_UpdateBarang = New System.Windows.Forms.Button()
        Me.Btn_HapusBarang = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PilihFormLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormJenisBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMenu_FormBarangMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DGV_Barang
        '
        Me.DGV_Barang.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DGV_Barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Barang.Location = New System.Drawing.Point(14, 396)
        Me.DGV_Barang.Name = "DGV_Barang"
        Me.DGV_Barang.RowHeadersWidth = 51
        Me.DGV_Barang.RowTemplate.Height = 29
        Me.DGV_Barang.Size = New System.Drawing.Size(933, 325)
        Me.DGV_Barang.TabIndex = 5
        '
        'Txt_NamaBarang
        '
        Me.Txt_NamaBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_NamaBarang.Location = New System.Drawing.Point(189, 30)
        Me.Txt_NamaBarang.Name = "Txt_NamaBarang"
        Me.Txt_NamaBarang.Size = New System.Drawing.Size(281, 23)
        Me.Txt_NamaBarang.TabIndex = 7
        '
        'Txt_stock
        '
        Me.Txt_stock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_stock.Location = New System.Drawing.Point(189, 75)
        Me.Txt_stock.Name = "Txt_stock"
        Me.Txt_stock.Size = New System.Drawing.Size(281, 23)
        Me.Txt_stock.TabIndex = 8
        '
        'Txt_harga
        '
        Me.Txt_harga.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_harga.Location = New System.Drawing.Point(189, 118)
        Me.Txt_harga.Name = "Txt_harga"
        Me.Txt_harga.Size = New System.Drawing.Size(281, 23)
        Me.Txt_harga.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(16, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(16, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(16, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Harga"
        '
        'Date_Masuk
        '
        Me.Date_Masuk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Date_Masuk.Location = New System.Drawing.Point(189, 163)
        Me.Date_Masuk.Name = "Date_Masuk"
        Me.Date_Masuk.Size = New System.Drawing.Size(281, 23)
        Me.Date_Masuk.TabIndex = 14
        '
        'Date_Kadaluarsa
        '
        Me.Date_Kadaluarsa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Date_Kadaluarsa.Location = New System.Drawing.Point(189, 211)
        Me.Date_Kadaluarsa.Name = "Date_Kadaluarsa"
        Me.Date_Kadaluarsa.Size = New System.Drawing.Size(281, 23)
        Me.Date_Kadaluarsa.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(16, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Masuk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(16, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tanggal Kadaluarsa"
        '
        'Btn_TambahBarang
        '
        Me.Btn_TambahBarang.BackColor = System.Drawing.Color.Teal
        Me.Btn_TambahBarang.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_TambahBarang.Location = New System.Drawing.Point(572, 103)
        Me.Btn_TambahBarang.Name = "Btn_TambahBarang"
        Me.Btn_TambahBarang.Size = New System.Drawing.Size(336, 29)
        Me.Btn_TambahBarang.TabIndex = 18
        Me.Btn_TambahBarang.Text = "Tambah Barang"
        Me.Btn_TambahBarang.UseVisualStyleBackColor = False
        '
        'Btn_UpdateBarang
        '
        Me.Btn_UpdateBarang.BackColor = System.Drawing.Color.Teal
        Me.Btn_UpdateBarang.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_UpdateBarang.Location = New System.Drawing.Point(572, 145)
        Me.Btn_UpdateBarang.Name = "Btn_UpdateBarang"
        Me.Btn_UpdateBarang.Size = New System.Drawing.Size(336, 29)
        Me.Btn_UpdateBarang.TabIndex = 19
        Me.Btn_UpdateBarang.Text = "Update Barang"
        Me.Btn_UpdateBarang.UseVisualStyleBackColor = False
        '
        'Btn_HapusBarang
        '
        Me.Btn_HapusBarang.BackColor = System.Drawing.Color.Teal
        Me.Btn_HapusBarang.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_HapusBarang.Location = New System.Drawing.Point(572, 188)
        Me.Btn_HapusBarang.Name = "Btn_HapusBarang"
        Me.Btn_HapusBarang.Size = New System.Drawing.Size(336, 29)
        Me.Btn_HapusBarang.TabIndex = 20
        Me.Btn_HapusBarang.Text = "Hapus Barang"
        Me.Btn_HapusBarang.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkCyan
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(27, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Form Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(376, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 21)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Database Barang"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkCyan
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihFormLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 25)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PilihFormLainnyaToolStripMenuItem
        '
        Me.PilihFormLainnyaToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan
        Me.PilihFormLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_FormJenisBarang, Me.TSMenu_FormPenjualan, Me.TSMenu_FormBarangMasuk, Me.SignOutToolStripMenuItem})
        Me.PilihFormLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihFormLainnyaToolStripMenuItem.Name = "PilihFormLainnyaToolStripMenuItem"
        Me.PilihFormLainnyaToolStripMenuItem.Size = New System.Drawing.Size(154, 21)
        Me.PilihFormLainnyaToolStripMenuItem.Text = "Pilih Form Lainnya"
        '
        'TSMenu_FormJenisBarang
        '
        Me.TSMenu_FormJenisBarang.Name = "TSMenu_FormJenisBarang"
        Me.TSMenu_FormJenisBarang.Size = New System.Drawing.Size(220, 22)
        Me.TSMenu_FormJenisBarang.Text = "Form Jenis Barang"
        '
        'TSMenu_FormPenjualan
        '
        Me.TSMenu_FormPenjualan.Name = "TSMenu_FormPenjualan"
        Me.TSMenu_FormPenjualan.Size = New System.Drawing.Size(220, 22)
        Me.TSMenu_FormPenjualan.Text = "Form Penjualan"
        '
        'TSMenu_FormBarangMasuk
        '
        Me.TSMenu_FormBarangMasuk.Name = "TSMenu_FormBarangMasuk"
        Me.TSMenu_FormBarangMasuk.Size = New System.Drawing.Size(220, 22)
        Me.TSMenu_FormBarangMasuk.Text = "Form Barang Masuk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Txt_harga)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Date_Masuk)
        Me.Panel1.Controls.Add(Me.Date_Kadaluarsa)
        Me.Panel1.Controls.Add(Me.Txt_NamaBarang)
        Me.Panel1.Controls.Add(Me.Txt_stock)
        Me.Panel1.Location = New System.Drawing.Point(14, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 267)
        Me.Panel1.TabIndex = 25
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(960, 733)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_HapusBarang)
        Me.Controls.Add(Me.Btn_UpdateBarang)
        Me.Controls.Add(Me.Btn_TambahBarang)
        Me.Controls.Add(Me.DGV_Barang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormBarang"
        Me.Text = "Form Barang"
        CType(Me.DGV_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DGV_Barang As DataGridView
    Friend WithEvents Txt_NamaBarang As TextBox
    Friend WithEvents Txt_stock As TextBox
    Friend WithEvents Txt_harga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Date_Masuk As DateTimePicker
    Friend WithEvents Date_Kadaluarsa As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_TambahBarang As Button
    Friend WithEvents Btn_UpdateBarang As Button
    Friend WithEvents Btn_HapusBarang As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PilihFormLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMenu_FormJenisBarang As ToolStripMenuItem
    Friend WithEvents TSMenu_FormPenjualan As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TSMenu_FormBarangMasuk As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
End Class
