<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSignIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Username = New System.Windows.Forms.TextBox()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Btn_SignIn = New System.Windows.Forms.Button()
        Me.Btn_SignUp = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(10, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Txt_Username
        '
        Me.Txt_Username.Location = New System.Drawing.Point(111, 40)
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(332, 27)
        Me.Txt_Username.TabIndex = 3
        '
        'Txt_Password
        '
        Me.Txt_Password.Location = New System.Drawing.Point(111, 84)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.Size = New System.Drawing.Size(332, 27)
        Me.Txt_Password.TabIndex = 4
        '
        'Txt_Email
        '
        Me.Txt_Email.Location = New System.Drawing.Point(111, 135)
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(332, 27)
        Me.Txt_Email.TabIndex = 5
        '
        'Btn_SignIn
        '
        Me.Btn_SignIn.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Btn_SignIn.Location = New System.Drawing.Point(210, 318)
        Me.Btn_SignIn.Name = "Btn_SignIn"
        Me.Btn_SignIn.Size = New System.Drawing.Size(94, 29)
        Me.Btn_SignIn.TabIndex = 6
        Me.Btn_SignIn.Text = "Sign In!"
        Me.Btn_SignIn.UseVisualStyleBackColor = False
        '
        'Btn_SignUp
        '
        Me.Btn_SignUp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Btn_SignUp.Location = New System.Drawing.Point(415, 318)
        Me.Btn_SignUp.Name = "Btn_SignUp"
        Me.Btn_SignUp.Size = New System.Drawing.Size(94, 29)
        Me.Btn_SignUp.TabIndex = 8
        Me.Btn_SignUp.Text = "Sign Up!"
        Me.Btn_SignUp.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(139, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "INDOFINANCE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txt_Email)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_Password)
        Me.Panel1.Controls.Add(Me.Txt_Username)
        Me.Panel1.Location = New System.Drawing.Point(34, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 190)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(133, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 28)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Selamat Datang Kembali"
        '
        'FormSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(531, 371)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btn_SignUp)
        Me.Controls.Add(Me.Btn_SignIn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormSignIn"
        Me.Text = "SignIn"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Btn_SignIn As Button
    Friend WithEvents Btn_SignUp As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
