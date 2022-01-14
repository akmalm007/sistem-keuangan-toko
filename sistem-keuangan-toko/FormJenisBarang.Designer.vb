<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PilihMenuLainnyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormBarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTambahJenisBarang = New System.Windows.Forms.Button()
        Me.BtnUpdateJenisBarang = New System.Windows.Forms.Button()
        Me.BtnHapusJenisBarang = New System.Windows.Forms.Button()
        Me.DataGridJenisBarang = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihMenuLainnyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PilihMenuLainnyaToolStripMenuItem
        '
        Me.PilihMenuLainnyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPenjualanToolStripMenuItem})
        Me.PilihMenuLainnyaToolStripMenuItem.Name = "PilihMenuLainnyaToolStripMenuItem"
        Me.PilihMenuLainnyaToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.PilihMenuLainnyaToolStripMenuItem.Text = "Pilih Menu Lainnya"
        '
        'FormPenjualanToolStripMenuItem
        '
        Me.FormPenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormBarangToolStripMenuItem})
        Me.FormPenjualanToolStripMenuItem.Name = "FormPenjualanToolStripMenuItem"
        Me.FormPenjualanToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.FormPenjualanToolStripMenuItem.Text = "Form Penjualan"
        '
        'FormBarangToolStripMenuItem
        '
        Me.FormBarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormBarangMasukToolStripMenuItem})
        Me.FormBarangToolStripMenuItem.Name = "FormBarangToolStripMenuItem"
        Me.FormBarangToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FormBarangToolStripMenuItem.Text = "Form Barang"
        '
        'FormBarangMasukToolStripMenuItem
        '
        Me.FormBarangMasukToolStripMenuItem.Name = "FormBarangMasukToolStripMenuItem"
        Me.FormBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormBarangMasukToolStripMenuItem.Text = "Form Barang Masuk"
        '
        'BtnTambahJenisBarang
        '
        Me.BtnTambahJenisBarang.Location = New System.Drawing.Point(12, 27)
        Me.BtnTambahJenisBarang.Name = "BtnTambahJenisBarang"
        Me.BtnTambahJenisBarang.Size = New System.Drawing.Size(132, 23)
        Me.BtnTambahJenisBarang.TabIndex = 1
        Me.BtnTambahJenisBarang.Text = "Tambah Jenis Barang"
        Me.BtnTambahJenisBarang.UseVisualStyleBackColor = True
        '
        'BtnUpdateJenisBarang
        '
        Me.BtnUpdateJenisBarang.Location = New System.Drawing.Point(150, 27)
        Me.BtnUpdateJenisBarang.Name = "BtnUpdateJenisBarang"
        Me.BtnUpdateJenisBarang.Size = New System.Drawing.Size(132, 23)
        Me.BtnUpdateJenisBarang.TabIndex = 2
        Me.BtnUpdateJenisBarang.Text = "Update Jenis Barang"
        Me.BtnUpdateJenisBarang.UseVisualStyleBackColor = True
        '
        'BtnHapusJenisBarang
        '
        Me.BtnHapusJenisBarang.Location = New System.Drawing.Point(288, 27)
        Me.BtnHapusJenisBarang.Name = "BtnHapusJenisBarang"
        Me.BtnHapusJenisBarang.Size = New System.Drawing.Size(132, 23)
        Me.BtnHapusJenisBarang.TabIndex = 3
        Me.BtnHapusJenisBarang.Text = "Hapus Jenis Barang"
        Me.BtnHapusJenisBarang.UseVisualStyleBackColor = True
        '
        'DataGridJenisBarang
        '
        Me.DataGridJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJenisBarang.Location = New System.Drawing.Point(12, 65)
        Me.DataGridJenisBarang.Name = "DataGridJenisBarang"
        Me.DataGridJenisBarang.RowTemplate.Height = 25
        Me.DataGridJenisBarang.Size = New System.Drawing.Size(408, 150)
        Me.DataGridJenisBarang.TabIndex = 4
        '
        'FormJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 230)
        Me.Controls.Add(Me.DataGridJenisBarang)
        Me.Controls.Add(Me.BtnHapusJenisBarang)
        Me.Controls.Add(Me.BtnUpdateJenisBarang)
        Me.Controls.Add(Me.BtnTambahJenisBarang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormJenisBarang"
        Me.Text = "FormJenisBarang"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PilihMenuLainnyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormBarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnTambahJenisBarang As Button
    Friend WithEvents BtnUpdateJenisBarang As Button
    Friend WithEvents BtnHapusJenisBarang As Button
    Friend WithEvents DataGridJenisBarang As DataGridView
End Class
