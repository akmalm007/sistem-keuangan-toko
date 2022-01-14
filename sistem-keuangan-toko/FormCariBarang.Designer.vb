<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCariBarang
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
        Me.DGV_CariBarang = New System.Windows.Forms.DataGridView()
        Me.Txt_IDBarang = New System.Windows.Forms.TextBox()
        Me.Btn_pilih = New System.Windows.Forms.Button()
        Me.Btn_Cari = New System.Windows.Forms.Button()
        Me.Txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGV_CariBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_CariBarang
        '
        Me.DGV_CariBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CariBarang.Location = New System.Drawing.Point(31, 182)
        Me.DGV_CariBarang.Name = "DGV_CariBarang"
        Me.DGV_CariBarang.RowHeadersWidth = 51
        Me.DGV_CariBarang.RowTemplate.Height = 29
        Me.DGV_CariBarang.Size = New System.Drawing.Size(724, 211)
        Me.DGV_CariBarang.TabIndex = 0
        '
        'Txt_IDBarang
        '
        Me.Txt_IDBarang.Location = New System.Drawing.Point(277, 67)
        Me.Txt_IDBarang.Name = "Txt_IDBarang"
        Me.Txt_IDBarang.Size = New System.Drawing.Size(322, 27)
        Me.Txt_IDBarang.TabIndex = 1
        '
        'Btn_pilih
        '
        Me.Btn_pilih.Location = New System.Drawing.Point(661, 409)
        Me.Btn_pilih.Name = "Btn_pilih"
        Me.Btn_pilih.Size = New System.Drawing.Size(94, 29)
        Me.Btn_pilih.TabIndex = 2
        Me.Btn_pilih.Text = "Pilih"
        Me.Btn_pilih.UseVisualStyleBackColor = True
        '
        'Btn_Cari
        '
        Me.Btn_Cari.Location = New System.Drawing.Point(645, 110)
        Me.Btn_Cari.Name = "Btn_Cari"
        Me.Btn_Cari.Size = New System.Drawing.Size(94, 29)
        Me.Btn_Cari.TabIndex = 3
        Me.Btn_Cari.Text = "Cari"
        Me.Btn_Cari.UseVisualStyleBackColor = True
        '
        'Txt_NamaBarang
        '
        Me.Txt_NamaBarang.Location = New System.Drawing.Point(277, 112)
        Me.Txt_NamaBarang.Name = "Txt_NamaBarang"
        Me.Txt_NamaBarang.Size = New System.Drawing.Size(322, 27)
        Me.Txt_NamaBarang.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cari berdasarkan Nama atau ID barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Database Barang"
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_NamaBarang)
        Me.Controls.Add(Me.Btn_Cari)
        Me.Controls.Add(Me.Btn_pilih)
        Me.Controls.Add(Me.Txt_IDBarang)
        Me.Controls.Add(Me.DGV_CariBarang)
        Me.Name = "FormCariBarang"
        Me.Text = "Form CariBarang"
        CType(Me.DGV_CariBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_CariBarang As DataGridView
    Friend WithEvents Txt_IDBarang As TextBox
    Friend WithEvents Btn_pilih As Button
    Friend WithEvents Btn_Cari As Button
    Friend WithEvents Txt_NamaBarang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
