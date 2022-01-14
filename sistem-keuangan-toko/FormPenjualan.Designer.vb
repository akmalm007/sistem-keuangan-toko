<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjualan
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
        Me.FormBarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Cari = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_ID_Barang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Date_Jual = New System.Windows.Forms.DateTimePicker()
        Me.Txt_JumlahBarang = New System.Windows.Forms.TextBox()
        Me.Btn_TambahPenjualan = New System.Windows.Forms.Button()
        Me.Btn_UpdatePenjualan = New System.Windows.Forms.Button()
        Me.Btn_HapusPenjualan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.DGV_Penjualan.Location = New System.Drawing.Point(22, 384)
        Me.DGV_Penjualan.Name = "DGV_Penjualan"
        Me.DGV_Penjualan.RowHeadersWidth = 51
        Me.DGV_Penjualan.RowTemplate.Height = 29
        Me.DGV_Penjualan.Size = New System.Drawing.Size(775, 269)
        Me.DGV_Penjualan.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihFormLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 29)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PilihFormLainnyaToolStripMenuItem
        '
        Me.PilihFormLainnyaToolStripMenuItem.BackColor = System.Drawing.Color.PapayaWhip
        Me.PilihFormLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMenu_FormJenisBarang, Me.TSMenu_FormPenjualan, Me.FormBarangMasukToolStripMenuItem})
        Me.PilihFormLainnyaToolStripMenuItem.Font = New System.Drawing.Font("Myriad Pro Light", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PilihFormLainnyaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PilihFormLainnyaToolStripMenuItem.Name = "PilihFormLainnyaToolStripMenuItem"
        Me.PilihFormLainnyaToolStripMenuItem.Size = New System.Drawing.Size(162, 25)
        Me.PilihFormLainnyaToolStripMenuItem.Text = "Pilih Form Lainnya"
        '
        'TSMenu_FormJenisBarang
        '
        Me.TSMenu_FormJenisBarang.Name = "TSMenu_FormJenisBarang"
        Me.TSMenu_FormJenisBarang.Size = New System.Drawing.Size(244, 26)
        Me.TSMenu_FormJenisBarang.Text = "Form Jenis Barang"
        '
        'TSMenu_FormPenjualan
        '
        Me.TSMenu_FormPenjualan.Name = "TSMenu_FormPenjualan"
        Me.TSMenu_FormPenjualan.Size = New System.Drawing.Size(244, 26)
        Me.TSMenu_FormPenjualan.Text = "Form Barang"
        '
        'FormBarangMasukToolStripMenuItem
        '
        Me.FormBarangMasukToolStripMenuItem.Name = "FormBarangMasukToolStripMenuItem"
        Me.FormBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.FormBarangMasukToolStripMenuItem.Text = "Form Barang Masuk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.Btn_Cari)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_ID_Barang)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Date_Jual)
        Me.Panel1.Controls.Add(Me.Txt_JumlahBarang)
        Me.Panel1.Location = New System.Drawing.Point(22, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 178)
        Me.Panel1.TabIndex = 26
        '
        'Btn_Cari
        '
        Me.Btn_Cari.BackColor = System.Drawing.Color.Orange
        Me.Btn_Cari.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Btn_Cari.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Cari.Location = New System.Drawing.Point(347, 30)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(76, 29)
        Me.Btn_Cari.TabIndex = 21
        Me.Btn_Cari.Text = "Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(19, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ID Barang"
        '
        'Txt_ID_Barang
        '
        Me.Txt_ID_Barang.Location = New System.Drawing.Point(173, 32)
        Me.Txt_ID_Barang.Name = "Txt_ID_Barang"
        Me.Txt_ID_Barang.Size = New System.Drawing.Size(168, 27)
        Me.Txt_ID_Barang.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(19, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Jumlah Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(19, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tanggal Jual"
        '
        'Date_Jual
        '
        Me.Date_Jual.Location = New System.Drawing.Point(173, 123)
        Me.Date_Jual.Name = "Date_Jual"
        Me.Date_Jual.Size = New System.Drawing.Size(250, 27)
        Me.Date_Jual.TabIndex = 14
        '
        'Txt_JumlahBarang
        '
        Me.Txt_JumlahBarang.Location = New System.Drawing.Point(173, 77)
        Me.Txt_JumlahBarang.Name = "Txt_JumlahBarang"
        Me.Txt_JumlahBarang.Size = New System.Drawing.Size(250, 27)
        Me.Txt_JumlahBarang.TabIndex = 7
        '
        'Btn_TambahPenjualan
        '
        Me.Btn_TambahPenjualan.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_TambahPenjualan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_TambahPenjualan.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_TambahPenjualan.Location = New System.Drawing.Point(498, 92)
        Me.Btn_TambahPenjualan.Name = "Btn_TambahPenjualan"
        Me.Btn_TambahPenjualan.Size = New System.Drawing.Size(299, 29)
        Me.Btn_TambahPenjualan.TabIndex = 27
        Me.Btn_TambahPenjualan.Text = "Tambah Penjualan"
        Me.Btn_TambahPenjualan.UseVisualStyleBackColor = False
        '
        'Btn_UpdatePenjualan
        '
        Me.Btn_UpdatePenjualan.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_UpdatePenjualan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_UpdatePenjualan.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_UpdatePenjualan.Location = New System.Drawing.Point(498, 137)
        Me.Btn_UpdatePenjualan.Name = "Btn_UpdatePenjualan"
        Me.Btn_UpdatePenjualan.Size = New System.Drawing.Size(299, 29)
        Me.Btn_UpdatePenjualan.TabIndex = 28
        Me.Btn_UpdatePenjualan.Text = "Update Penjualan"
        Me.Btn_UpdatePenjualan.UseVisualStyleBackColor = False
        '
        'Btn_HapusPenjualan
        '
        Me.Btn_HapusPenjualan.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_HapusPenjualan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_HapusPenjualan.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_HapusPenjualan.Location = New System.Drawing.Point(498, 183)
        Me.Btn_HapusPenjualan.Name = "Btn_HapusPenjualan"
        Me.Btn_HapusPenjualan.Size = New System.Drawing.Size(299, 29)
        Me.Btn_HapusPenjualan.TabIndex = 29
        Me.Btn_HapusPenjualan.Text = "Hapus Penjualan"
        Me.Btn_HapusPenjualan.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(41, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 31)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Form Penjualan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(327, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 28)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Database Penjualan"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(548, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 109)
        Me.Panel2.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(3, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 54)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(38, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 69)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pastikan Inputan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID Barang sesuai dengan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yang ada di database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Label1"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(824, 665)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_HapusPenjualan)
        Me.Controls.Add(Me.Btn_UpdatePenjualan)
        Me.Controls.Add(Me.Btn_TambahPenjualan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DGV_Penjualan)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
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
    Friend WithEvents Date_Jual As DateTimePicker
    Friend WithEvents Txt_JumlahBarang As TextBox
    Friend WithEvents Btn_TambahPenjualan As Button
    Friend WithEvents Btn_UpdatePenjualan As Button
    Friend WithEvents Btn_HapusPenjualan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_ID_Barang As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FormBarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Cari As Button
    Friend WithEvents Label1 As Label
End Class
