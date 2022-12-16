<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OyunEkraniForm
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
        Me.OyunEklePanel = New System.Windows.Forms.Panel()
        Me.OyunEkleArea = New System.Windows.Forms.RichTextBox()
        Me.OyunEkleButon = New System.Windows.Forms.Button()
        Me.OyunListesiPanel = New System.Windows.Forms.Panel()
        Me.Sil3 = New System.Windows.Forms.Button()
        Me.Sil2 = New System.Windows.Forms.Button()
        Me.Sil1 = New System.Windows.Forms.Button()
        Me.Oynayacagim = New System.Windows.Forms.ListBox()
        Me.Oynuyorum = New System.Windows.Forms.ListBox()
        Me.Oynadım = New System.Windows.Forms.ListBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.OynayacagimButon = New System.Windows.Forms.Button()
        Me.OynuyorumButon = New System.Windows.Forms.Button()
        Me.OynadımButon = New System.Windows.Forms.Button()
        Me.OyunListesi = New System.Windows.Forms.Label()
        Me.AnaListe = New System.Windows.Forms.ListBox()
        Me.OyunBilgiPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OyunBilgiButon = New System.Windows.Forms.Button()
        Me.OyunEklePanel.SuspendLayout()
        Me.OyunListesiPanel.SuspendLayout()
        Me.OyunBilgiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OyunEklePanel
        '
        Me.OyunEklePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.OyunEklePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OyunEklePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OyunEklePanel.Controls.Add(Me.OyunEkleArea)
        Me.OyunEklePanel.Controls.Add(Me.OyunEkleButon)
        Me.OyunEklePanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.OyunEklePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.OyunEklePanel.Location = New System.Drawing.Point(0, 0)
        Me.OyunEklePanel.Name = "OyunEklePanel"
        Me.OyunEklePanel.Size = New System.Drawing.Size(250, 516)
        Me.OyunEklePanel.TabIndex = 10
        '
        'OyunEkleArea
        '
        Me.OyunEkleArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.OyunEkleArea.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OyunEkleArea.Location = New System.Drawing.Point(30, 100)
        Me.OyunEkleArea.Name = "OyunEkleArea"
        Me.OyunEkleArea.Size = New System.Drawing.Size(183, 179)
        Me.OyunEkleArea.TabIndex = 9
        Me.OyunEkleArea.Text = ""
        '
        'OyunEkleButon
        '
        Me.OyunEkleButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OyunEkleButon.FlatAppearance.BorderSize = 6
        Me.OyunEkleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OyunEkleButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OyunEkleButon.ForeColor = System.Drawing.Color.Indigo
        Me.OyunEkleButon.Location = New System.Drawing.Point(54, 14)
        Me.OyunEkleButon.Name = "OyunEkleButon"
        Me.OyunEkleButon.Size = New System.Drawing.Size(133, 44)
        Me.OyunEkleButon.TabIndex = 8
        Me.OyunEkleButon.Text = "Oyun Ekle"
        Me.OyunEkleButon.UseVisualStyleBackColor = False
        '
        'OyunListesiPanel
        '
        Me.OyunListesiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.OyunListesiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OyunListesiPanel.Controls.Add(Me.Sil3)
        Me.OyunListesiPanel.Controls.Add(Me.Sil2)
        Me.OyunListesiPanel.Controls.Add(Me.Sil1)
        Me.OyunListesiPanel.Controls.Add(Me.Oynayacagim)
        Me.OyunListesiPanel.Controls.Add(Me.Oynuyorum)
        Me.OyunListesiPanel.Controls.Add(Me.Oynadım)
        Me.OyunListesiPanel.Controls.Add(Me.RadioButton3)
        Me.OyunListesiPanel.Controls.Add(Me.RadioButton2)
        Me.OyunListesiPanel.Controls.Add(Me.RadioButton1)
        Me.OyunListesiPanel.Controls.Add(Me.OynayacagimButon)
        Me.OyunListesiPanel.Controls.Add(Me.OynuyorumButon)
        Me.OyunListesiPanel.Controls.Add(Me.OynadımButon)
        Me.OyunListesiPanel.Controls.Add(Me.OyunListesi)
        Me.OyunListesiPanel.Controls.Add(Me.AnaListe)
        Me.OyunListesiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.OyunListesiPanel.Location = New System.Drawing.Point(250, 0)
        Me.OyunListesiPanel.Name = "OyunListesiPanel"
        Me.OyunListesiPanel.Size = New System.Drawing.Size(450, 516)
        Me.OyunListesiPanel.TabIndex = 11
        '
        'Sil3
        '
        Me.Sil3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sil3.FlatAppearance.BorderSize = 6
        Me.Sil3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sil3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Sil3.ForeColor = System.Drawing.Color.Indigo
        Me.Sil3.Location = New System.Drawing.Point(317, 386)
        Me.Sil3.Name = "Sil3"
        Me.Sil3.Size = New System.Drawing.Size(83, 38)
        Me.Sil3.TabIndex = 23
        Me.Sil3.Text = "Sil"
        Me.Sil3.UseVisualStyleBackColor = False
        '
        'Sil2
        '
        Me.Sil2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sil2.FlatAppearance.BorderSize = 6
        Me.Sil2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sil2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Sil2.ForeColor = System.Drawing.Color.Indigo
        Me.Sil2.Location = New System.Drawing.Point(164, 386)
        Me.Sil2.Name = "Sil2"
        Me.Sil2.Size = New System.Drawing.Size(83, 38)
        Me.Sil2.TabIndex = 22
        Me.Sil2.Text = "Sil"
        Me.Sil2.UseVisualStyleBackColor = False
        '
        'Sil1
        '
        Me.Sil1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Sil1.FlatAppearance.BorderSize = 6
        Me.Sil1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sil1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Sil1.ForeColor = System.Drawing.Color.Indigo
        Me.Sil1.Location = New System.Drawing.Point(14, 386)
        Me.Sil1.Name = "Sil1"
        Me.Sil1.Size = New System.Drawing.Size(83, 38)
        Me.Sil1.TabIndex = 21
        Me.Sil1.Text = "Sil"
        Me.Sil1.UseVisualStyleBackColor = False
        '
        'Oynayacagim
        '
        Me.Oynayacagim.BackColor = System.Drawing.Color.PapayaWhip
        Me.Oynayacagim.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Oynayacagim.FormattingEnabled = True
        Me.Oynayacagim.ItemHeight = 15
        Me.Oynayacagim.Location = New System.Drawing.Point(299, 285)
        Me.Oynayacagim.Name = "Oynayacagim"
        Me.Oynayacagim.Size = New System.Drawing.Size(120, 94)
        Me.Oynayacagim.TabIndex = 20
        '
        'Oynuyorum
        '
        Me.Oynuyorum.BackColor = System.Drawing.Color.PapayaWhip
        Me.Oynuyorum.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Oynuyorum.FormattingEnabled = True
        Me.Oynuyorum.ItemHeight = 15
        Me.Oynuyorum.Location = New System.Drawing.Point(149, 285)
        Me.Oynuyorum.Name = "Oynuyorum"
        Me.Oynuyorum.Size = New System.Drawing.Size(120, 94)
        Me.Oynuyorum.TabIndex = 19
        '
        'Oynadım
        '
        Me.Oynadım.BackColor = System.Drawing.Color.PapayaWhip
        Me.Oynadım.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Oynadım.FormattingEnabled = True
        Me.Oynadım.ItemHeight = 15
        Me.Oynadım.Location = New System.Drawing.Point(4, 285)
        Me.Oynadım.Name = "Oynadım"
        Me.Oynadım.Size = New System.Drawing.Size(120, 94)
        Me.Oynadım.TabIndex = 18
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton3.Location = New System.Drawing.Point(309, 191)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(98, 19)
        Me.RadioButton3.TabIndex = 17
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Oynayacağım"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton2.Location = New System.Drawing.Point(164, 191)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 19)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Oynuyorum"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton1.Location = New System.Drawing.Point(27, 191)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 19)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Oynadım"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'OynayacagimButon
        '
        Me.OynayacagimButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OynayacagimButon.FlatAppearance.BorderSize = 6
        Me.OynayacagimButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OynayacagimButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OynayacagimButon.ForeColor = System.Drawing.Color.Indigo
        Me.OynayacagimButon.Location = New System.Drawing.Point(299, 235)
        Me.OynayacagimButon.Name = "OynayacagimButon"
        Me.OynayacagimButon.Size = New System.Drawing.Size(133, 44)
        Me.OynayacagimButon.TabIndex = 14
        Me.OynayacagimButon.Text = "Oynayacağım"
        Me.OynayacagimButon.UseVisualStyleBackColor = False
        '
        'OynuyorumButon
        '
        Me.OynuyorumButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OynuyorumButon.FlatAppearance.BorderSize = 6
        Me.OynuyorumButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OynuyorumButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OynuyorumButon.ForeColor = System.Drawing.Color.Indigo
        Me.OynuyorumButon.Location = New System.Drawing.Point(149, 235)
        Me.OynuyorumButon.Name = "OynuyorumButon"
        Me.OynuyorumButon.Size = New System.Drawing.Size(133, 44)
        Me.OynuyorumButon.TabIndex = 13
        Me.OynuyorumButon.Text = "Oynuyorum"
        Me.OynuyorumButon.UseVisualStyleBackColor = False
        '
        'OynadımButon
        '
        Me.OynadımButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OynadımButon.FlatAppearance.BorderSize = 6
        Me.OynadımButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OynadımButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OynadımButon.ForeColor = System.Drawing.Color.Indigo
        Me.OynadımButon.Location = New System.Drawing.Point(3, 235)
        Me.OynadımButon.Name = "OynadımButon"
        Me.OynadımButon.Size = New System.Drawing.Size(133, 44)
        Me.OynadımButon.TabIndex = 10
        Me.OynadımButon.Text = "Oynadım"
        Me.OynadımButon.UseVisualStyleBackColor = False
        '
        'OyunListesi
        '
        Me.OyunListesi.AutoSize = True
        Me.OyunListesi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OyunListesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OyunListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OyunListesi.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.OyunListesi.Location = New System.Drawing.Point(164, 22)
        Me.OyunListesi.Name = "OyunListesi"
        Me.OyunListesi.Size = New System.Drawing.Size(117, 25)
        Me.OyunListesi.TabIndex = 11
        Me.OyunListesi.Text = "Oyun Listesi"
        Me.OyunListesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnaListe
        '
        Me.AnaListe.BackColor = System.Drawing.SystemColors.MenuBar
        Me.AnaListe.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.AnaListe.FormattingEnabled = True
        Me.AnaListe.ItemHeight = 15
        Me.AnaListe.Location = New System.Drawing.Point(27, 59)
        Me.AnaListe.Name = "AnaListe"
        Me.AnaListe.Size = New System.Drawing.Size(405, 109)
        Me.AnaListe.TabIndex = 10
        '
        'OyunBilgiPanel
        '
        Me.OyunBilgiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.OyunBilgiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OyunBilgiPanel.Controls.Add(Me.Label1)
        Me.OyunBilgiPanel.Controls.Add(Me.RichTextBox1)
        Me.OyunBilgiPanel.Controls.Add(Me.OyunBilgiButon)
        Me.OyunBilgiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.OyunBilgiPanel.Location = New System.Drawing.Point(700, 0)
        Me.OyunBilgiPanel.Name = "OyunBilgiPanel"
        Me.OyunBilgiPanel.Size = New System.Drawing.Size(504, 516)
        Me.OyunBilgiPanel.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(40, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Oyun Bilgi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RichTextBox1.Location = New System.Drawing.Point(22, 63)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(448, 423)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'OyunBilgiButon
        '
        Me.OyunBilgiButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OyunBilgiButon.FlatAppearance.BorderSize = 6
        Me.OyunBilgiButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OyunBilgiButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OyunBilgiButon.ForeColor = System.Drawing.Color.Indigo
        Me.OyunBilgiButon.Location = New System.Drawing.Point(298, 13)
        Me.OyunBilgiButon.Name = "OyunBilgiButon"
        Me.OyunBilgiButon.Size = New System.Drawing.Size(156, 44)
        Me.OyunBilgiButon.TabIndex = 10
        Me.OyunBilgiButon.Text = "Oyun Bilgi"
        Me.OyunBilgiButon.UseVisualStyleBackColor = False
        '
        'OyunEkraniForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 516)
        Me.Controls.Add(Me.OyunBilgiPanel)
        Me.Controls.Add(Me.OyunListesiPanel)
        Me.Controls.Add(Me.OyunEklePanel)
        Me.MaximizeBox = False
        Me.Name = "OyunEkraniForm"
        Me.Text = "Oyun Ekranı"
        Me.OyunEklePanel.ResumeLayout(False)
        Me.OyunListesiPanel.ResumeLayout(False)
        Me.OyunListesiPanel.PerformLayout()
        Me.OyunBilgiPanel.ResumeLayout(False)
        Me.OyunBilgiPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OyunEklePanel As Panel
    Friend WithEvents OyunEkleArea As RichTextBox
    Friend WithEvents OyunEkleButon As Button
    Friend WithEvents OyunListesiPanel As Panel
    Friend WithEvents Sil3 As Button
    Friend WithEvents Sil2 As Button
    Friend WithEvents Sil1 As Button
    Friend WithEvents Oynayacagim As ListBox
    Friend WithEvents Oynuyorum As ListBox
    Friend WithEvents Oynadım As ListBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents OynayacagimButon As Button
    Friend WithEvents OynuyorumButon As Button
    Friend WithEvents OynadımButon As Button
    Friend WithEvents OyunListesi As Label
    Friend WithEvents AnaListe As ListBox
    Friend WithEvents OyunBilgiPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents OyunBilgiButon As Button
End Class
