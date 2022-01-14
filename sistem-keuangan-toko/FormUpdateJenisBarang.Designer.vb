<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateJenisBarang
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
        Me.TxtUpdateJenisBarang = New System.Windows.Forms.TextBox()
        Me.BtnUpdateJenisBarang = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtUpdateJenisBarang
        '
        Me.TxtUpdateJenisBarang.Location = New System.Drawing.Point(27, 113)
        Me.TxtUpdateJenisBarang.Name = "TxtUpdateJenisBarang"
        Me.TxtUpdateJenisBarang.Size = New System.Drawing.Size(354, 23)
        Me.TxtUpdateJenisBarang.TabIndex = 7
        '
        'BtnUpdateJenisBarang
        '
        Me.BtnUpdateJenisBarang.Location = New System.Drawing.Point(147, 154)
        Me.BtnUpdateJenisBarang.Name = "BtnUpdateJenisBarang"
        Me.BtnUpdateJenisBarang.Size = New System.Drawing.Size(70, 23)
        Me.BtnUpdateJenisBarang.TabIndex = 6
        Me.BtnUpdateJenisBarang.Text = "Confirm"
        Me.BtnUpdateJenisBarang.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(105, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Jenis Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 47)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Update Jenis Barang"
        '
        'FormUpdateJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 206)
        Me.Controls.Add(Me.TxtUpdateJenisBarang)
        Me.Controls.Add(Me.BtnUpdateJenisBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUpdateJenisBarang"
        Me.Text = "FormUpdateJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUpdateJenisBarang As TextBox
    Friend WithEvents BtnUpdateJenisBarang As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
