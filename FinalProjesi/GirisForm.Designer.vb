<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GirisForm
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
        Me.girisbutton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KayitButon = New System.Windows.Forms.Button()
        Me.CikisButon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'girisbutton
        '
        Me.girisbutton.FlatAppearance.BorderSize = 6
        Me.girisbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.girisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.girisbutton.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.girisbutton.ForeColor = System.Drawing.Color.OliveDrab
        Me.girisbutton.Location = New System.Drawing.Point(397, 412)
        Me.girisbutton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.girisbutton.Name = "girisbutton"
        Me.girisbutton.Size = New System.Drawing.Size(189, 72)
        Me.girisbutton.TabIndex = 0
        Me.girisbutton.Text = "Giriş"
        Me.girisbutton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.25!)
        Me.TextBox1.Location = New System.Drawing.Point(434, 193)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 26)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.25!)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(434, 264)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 26)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kullanıcı Adı"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(468, 240)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Şifre"
        '
        'KayitButon
        '
        Me.KayitButon.BackColor = System.Drawing.Color.Brown
        Me.KayitButon.FlatAppearance.BorderSize = 6
        Me.KayitButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.KayitButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KayitButon.Font = New System.Drawing.Font("Times New Roman", 12.25!)
        Me.KayitButon.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.KayitButon.Location = New System.Drawing.Point(374, 311)
        Me.KayitButon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.KayitButon.Name = "KayitButon"
        Me.KayitButon.Size = New System.Drawing.Size(235, 60)
        Me.KayitButon.TabIndex = 5
        Me.KayitButon.Text = "Kayıt Ekle"
        Me.KayitButon.UseVisualStyleBackColor = False
        '
        'CikisButon
        '
        Me.CikisButon.BackColor = System.Drawing.Color.SkyBlue
        Me.CikisButon.FlatAppearance.BorderSize = 6
        Me.CikisButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.CikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CikisButon.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.CikisButon.ForeColor = System.Drawing.Color.DodgerBlue
        Me.CikisButon.Location = New System.Drawing.Point(13, 12)
        Me.CikisButon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CikisButon.Name = "CikisButon"
        Me.CikisButon.Size = New System.Drawing.Size(97, 44)
        Me.CikisButon.TabIndex = 6
        Me.CikisButon.Text = "Çıkış"
        Me.CikisButon.UseVisualStyleBackColor = False
        '
        'GirisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 511)
        Me.Controls.Add(Me.CikisButon)
        Me.Controls.Add(Me.KayitButon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.girisbutton)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "GirisForm"
        Me.Text = "Giriş Ekranı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents girisbutton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KayitButon As Button
    Friend WithEvents CikisButon As Button
End Class
