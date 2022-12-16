<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KitapEkraniForm
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
        Me.KitapEkleButon = New System.Windows.Forms.Button()
        Me.KitapEklePanel = New System.Windows.Forms.Panel()
        Me.KitapEkleArea = New System.Windows.Forms.RichTextBox()
        Me.KitapListesiPanel = New System.Windows.Forms.Panel()
        Me.Sil3 = New System.Windows.Forms.Button()
        Me.Sil2 = New System.Windows.Forms.Button()
        Me.Sil1 = New System.Windows.Forms.Button()
        Me.Okuyacağım = New System.Windows.Forms.ListBox()
        Me.Okuyorum = New System.Windows.Forms.ListBox()
        Me.Okudum = New System.Windows.Forms.ListBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.OkuyacagimButon = New System.Windows.Forms.Button()
        Me.OkuyorumButon = New System.Windows.Forms.Button()
        Me.OkudumButon = New System.Windows.Forms.Button()
        Me.KitapListesi = New System.Windows.Forms.Label()
        Me.AnaListe = New System.Windows.Forms.ListBox()
        Me.KitapBilgiPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.KitapBilgiButon = New System.Windows.Forms.Button()
        Me.KitapEklePanel.SuspendLayout()
        Me.KitapListesiPanel.SuspendLayout()
        Me.KitapBilgiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KitapEkleButon
        '
        Me.KitapEkleButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KitapEkleButon.FlatAppearance.BorderSize = 6
        Me.KitapEkleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KitapEkleButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.KitapEkleButon.ForeColor = System.Drawing.Color.Indigo
        Me.KitapEkleButon.Location = New System.Drawing.Point(54, 14)
        Me.KitapEkleButon.Name = "KitapEkleButon"
        Me.KitapEkleButon.Size = New System.Drawing.Size(133, 44)
        Me.KitapEkleButon.TabIndex = 8
        Me.KitapEkleButon.Text = "Kitap Ekle"
        Me.KitapEkleButon.UseVisualStyleBackColor = False
        '
        'KitapEklePanel
        '
        Me.KitapEklePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.KitapEklePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.KitapEklePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KitapEklePanel.Controls.Add(Me.KitapEkleArea)
        Me.KitapEklePanel.Controls.Add(Me.KitapEkleButon)
        Me.KitapEklePanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.KitapEklePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.KitapEklePanel.Location = New System.Drawing.Point(0, 0)
        Me.KitapEklePanel.Name = "KitapEklePanel"
        Me.KitapEklePanel.Size = New System.Drawing.Size(250, 512)
        Me.KitapEklePanel.TabIndex = 9
        '
        'KitapEkleArea
        '
        Me.KitapEkleArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KitapEkleArea.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.KitapEkleArea.Location = New System.Drawing.Point(30, 100)
        Me.KitapEkleArea.Name = "KitapEkleArea"
        Me.KitapEkleArea.Size = New System.Drawing.Size(183, 179)
        Me.KitapEkleArea.TabIndex = 9
        Me.KitapEkleArea.Text = ""
        '
        'KitapListesiPanel
        '
        Me.KitapListesiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.KitapListesiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KitapListesiPanel.Controls.Add(Me.Sil3)
        Me.KitapListesiPanel.Controls.Add(Me.Sil2)
        Me.KitapListesiPanel.Controls.Add(Me.Sil1)
        Me.KitapListesiPanel.Controls.Add(Me.Okuyacağım)
        Me.KitapListesiPanel.Controls.Add(Me.Okuyorum)
        Me.KitapListesiPanel.Controls.Add(Me.Okudum)
        Me.KitapListesiPanel.Controls.Add(Me.RadioButton3)
        Me.KitapListesiPanel.Controls.Add(Me.RadioButton2)
        Me.KitapListesiPanel.Controls.Add(Me.RadioButton1)
        Me.KitapListesiPanel.Controls.Add(Me.OkuyacagimButon)
        Me.KitapListesiPanel.Controls.Add(Me.OkuyorumButon)
        Me.KitapListesiPanel.Controls.Add(Me.OkudumButon)
        Me.KitapListesiPanel.Controls.Add(Me.KitapListesi)
        Me.KitapListesiPanel.Controls.Add(Me.AnaListe)
        Me.KitapListesiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.KitapListesiPanel.Location = New System.Drawing.Point(250, 0)
        Me.KitapListesiPanel.Name = "KitapListesiPanel"
        Me.KitapListesiPanel.Size = New System.Drawing.Size(450, 512)
        Me.KitapListesiPanel.TabIndex = 10
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
        'Okuyacağım
        '
        Me.Okuyacağım.BackColor = System.Drawing.Color.PapayaWhip
        Me.Okuyacağım.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Okuyacağım.FormattingEnabled = True
        Me.Okuyacağım.ItemHeight = 15
        Me.Okuyacağım.Location = New System.Drawing.Point(299, 285)
        Me.Okuyacağım.Name = "Okuyacağım"
        Me.Okuyacağım.Size = New System.Drawing.Size(120, 94)
        Me.Okuyacağım.TabIndex = 20
        '
        'Okuyorum
        '
        Me.Okuyorum.BackColor = System.Drawing.Color.PapayaWhip
        Me.Okuyorum.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Okuyorum.FormattingEnabled = True
        Me.Okuyorum.ItemHeight = 15
        Me.Okuyorum.Location = New System.Drawing.Point(149, 285)
        Me.Okuyorum.Name = "Okuyorum"
        Me.Okuyorum.Size = New System.Drawing.Size(120, 94)
        Me.Okuyorum.TabIndex = 19
        '
        'Okudum
        '
        Me.Okudum.BackColor = System.Drawing.Color.PapayaWhip
        Me.Okudum.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Okudum.FormattingEnabled = True
        Me.Okudum.ItemHeight = 15
        Me.Okudum.Location = New System.Drawing.Point(4, 285)
        Me.Okudum.Name = "Okudum"
        Me.Okudum.Size = New System.Drawing.Size(120, 94)
        Me.Okudum.TabIndex = 18
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton3.Location = New System.Drawing.Point(309, 191)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(91, 19)
        Me.RadioButton3.TabIndex = 17
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Okuyacağım"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton2.Location = New System.Drawing.Point(164, 191)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 19)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Okuyorum"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton1.Location = New System.Drawing.Point(27, 191)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 19)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Okudum"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'OkuyacagimButon
        '
        Me.OkuyacagimButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OkuyacagimButon.FlatAppearance.BorderSize = 6
        Me.OkuyacagimButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkuyacagimButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OkuyacagimButon.ForeColor = System.Drawing.Color.Indigo
        Me.OkuyacagimButon.Location = New System.Drawing.Point(299, 235)
        Me.OkuyacagimButon.Name = "OkuyacagimButon"
        Me.OkuyacagimButon.Size = New System.Drawing.Size(133, 44)
        Me.OkuyacagimButon.TabIndex = 14
        Me.OkuyacagimButon.Text = "Okuyacağım"
        Me.OkuyacagimButon.UseVisualStyleBackColor = False
        '
        'OkuyorumButon
        '
        Me.OkuyorumButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OkuyorumButon.FlatAppearance.BorderSize = 6
        Me.OkuyorumButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkuyorumButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OkuyorumButon.ForeColor = System.Drawing.Color.Indigo
        Me.OkuyorumButon.Location = New System.Drawing.Point(149, 235)
        Me.OkuyorumButon.Name = "OkuyorumButon"
        Me.OkuyorumButon.Size = New System.Drawing.Size(133, 44)
        Me.OkuyorumButon.TabIndex = 13
        Me.OkuyorumButon.Text = "Okuyorum"
        Me.OkuyorumButon.UseVisualStyleBackColor = False
        '
        'OkudumButon
        '
        Me.OkudumButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OkudumButon.FlatAppearance.BorderSize = 6
        Me.OkudumButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkudumButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.OkudumButon.ForeColor = System.Drawing.Color.Indigo
        Me.OkudumButon.Location = New System.Drawing.Point(3, 235)
        Me.OkudumButon.Name = "OkudumButon"
        Me.OkudumButon.Size = New System.Drawing.Size(133, 44)
        Me.OkudumButon.TabIndex = 10
        Me.OkudumButon.Text = "Okudum"
        Me.OkudumButon.UseVisualStyleBackColor = False
        '
        'KitapListesi
        '
        Me.KitapListesi.AutoSize = True
        Me.KitapListesi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KitapListesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KitapListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KitapListesi.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.KitapListesi.Location = New System.Drawing.Point(164, 22)
        Me.KitapListesi.Name = "KitapListesi"
        Me.KitapListesi.Size = New System.Drawing.Size(118, 25)
        Me.KitapListesi.TabIndex = 11
        Me.KitapListesi.Text = "Kitap Listesi"
        Me.KitapListesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AnaListe
        '
        Me.AnaListe.BackColor = System.Drawing.SystemColors.MenuBar
        Me.AnaListe.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.AnaListe.FormattingEnabled = True
        Me.AnaListe.ItemHeight = 15
        Me.AnaListe.Items.AddRange(New Object() {"Kızıl Yükseliş"})
        Me.AnaListe.Location = New System.Drawing.Point(27, 59)
        Me.AnaListe.Name = "AnaListe"
        Me.AnaListe.Size = New System.Drawing.Size(405, 109)
        Me.AnaListe.TabIndex = 10
        '
        'KitapBilgiPanel
        '
        Me.KitapBilgiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.KitapBilgiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KitapBilgiPanel.Controls.Add(Me.Label1)
        Me.KitapBilgiPanel.Controls.Add(Me.RichTextBox1)
        Me.KitapBilgiPanel.Controls.Add(Me.KitapBilgiButon)
        Me.KitapBilgiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.KitapBilgiPanel.Location = New System.Drawing.Point(700, 0)
        Me.KitapBilgiPanel.Name = "KitapBilgiPanel"
        Me.KitapBilgiPanel.Size = New System.Drawing.Size(485, 512)
        Me.KitapBilgiPanel.TabIndex = 11
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
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Kitap Oku / Bilgi"
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
        'KitapBilgiButon
        '
        Me.KitapBilgiButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KitapBilgiButon.FlatAppearance.BorderSize = 6
        Me.KitapBilgiButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KitapBilgiButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.KitapBilgiButon.ForeColor = System.Drawing.Color.Indigo
        Me.KitapBilgiButon.Location = New System.Drawing.Point(298, 13)
        Me.KitapBilgiButon.Name = "KitapBilgiButon"
        Me.KitapBilgiButon.Size = New System.Drawing.Size(156, 44)
        Me.KitapBilgiButon.TabIndex = 10
        Me.KitapBilgiButon.Text = "Kitap Oku / Kitap Bilgi"
        Me.KitapBilgiButon.UseVisualStyleBackColor = False
        '
        'KitapEkraniForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 512)
        Me.Controls.Add(Me.KitapBilgiPanel)
        Me.Controls.Add(Me.KitapListesiPanel)
        Me.Controls.Add(Me.KitapEklePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "KitapEkraniForm"
        Me.Text = "Kitap Ekranı"
        Me.KitapEklePanel.ResumeLayout(False)
        Me.KitapListesiPanel.ResumeLayout(False)
        Me.KitapListesiPanel.PerformLayout()
        Me.KitapBilgiPanel.ResumeLayout(False)
        Me.KitapBilgiPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KitapEkleButon As Button
    Friend WithEvents KitapEklePanel As Panel
    Friend WithEvents KitapListesiPanel As Panel
    Friend WithEvents KitapBilgiPanel As Panel
    Friend WithEvents KitapBilgiButon As Button
    Friend WithEvents KitapEkleArea As RichTextBox
    Friend WithEvents AnaListe As ListBox
    Friend WithEvents KitapListesi As Label
    Friend WithEvents OkuyacagimButon As Button
    Friend WithEvents OkuyorumButon As Button
    Friend WithEvents OkudumButon As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Okuyacağım As ListBox
    Friend WithEvents Okuyorum As ListBox
    Friend WithEvents Okudum As ListBox
    Friend WithEvents Sil3 As Button
    Friend WithEvents Sil2 As Button
    Friend WithEvents Sil1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
