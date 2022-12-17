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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WriterInfo = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.IslemButon = New System.Windows.Forms.Button()
        Me.KitapListesi = New System.Windows.Forms.Label()
        Me.AnaListe = New System.Windows.Forms.ListBox()
        Me.KitapBilgiPanel = New System.Windows.Forms.Panel()
        Me.KitapBilgiButon = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KitapAdıBilgi = New System.Windows.Forms.RichTextBox()
        Me.CikisYiliBilgi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.YazarBilgi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.KitapEkleButon.Location = New System.Drawing.Point(52, 383)
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
        Me.KitapEklePanel.Controls.Add(Me.Label5)
        Me.KitapEklePanel.Controls.Add(Me.Label4)
        Me.KitapEklePanel.Controls.Add(Me.Label3)
        Me.KitapEklePanel.Controls.Add(Me.WriterInfo)
        Me.KitapEklePanel.Controls.Add(Me.DateTextBox)
        Me.KitapEklePanel.Controls.Add(Me.Label2)
        Me.KitapEklePanel.Controls.Add(Me.KitapEkleArea)
        Me.KitapEklePanel.Controls.Add(Me.KitapEkleButon)
        Me.KitapEklePanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.KitapEklePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.KitapEklePanel.Location = New System.Drawing.Point(0, 0)
        Me.KitapEklePanel.Name = "KitapEklePanel"
        Me.KitapEklePanel.Size = New System.Drawing.Size(250, 512)
        Me.KitapEklePanel.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label5.Location = New System.Drawing.Point(28, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Kitap Adı"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label4.Location = New System.Drawing.Point(28, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Yazar Bilgisi"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label3.Location = New System.Drawing.Point(28, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Çıkış Tarihi"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WriterInfo
        '
        Me.WriterInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.WriterInfo.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.WriterInfo.Location = New System.Drawing.Point(28, 227)
        Me.WriterInfo.Name = "WriterInfo"
        Me.WriterInfo.Size = New System.Drawing.Size(183, 26)
        Me.WriterInfo.TabIndex = 26
        '
        'DateTextBox
        '
        Me.DateTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DateTextBox.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.DateTextBox.Location = New System.Drawing.Point(28, 171)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(183, 26)
        Me.DateTextBox.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(61, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Kitap Bilgisi "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KitapEkleArea
        '
        Me.KitapEkleArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KitapEkleArea.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.KitapEkleArea.Location = New System.Drawing.Point(28, 84)
        Me.KitapEkleArea.Name = "KitapEkleArea"
        Me.KitapEkleArea.Size = New System.Drawing.Size(183, 49)
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
        Me.KitapListesiPanel.Controls.Add(Me.IslemButon)
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
        'IslemButon
        '
        Me.IslemButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IslemButon.FlatAppearance.BorderSize = 6
        Me.IslemButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IslemButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.IslemButon.ForeColor = System.Drawing.Color.Indigo
        Me.IslemButon.Location = New System.Drawing.Point(149, 235)
        Me.IslemButon.Name = "IslemButon"
        Me.IslemButon.Size = New System.Drawing.Size(133, 44)
        Me.IslemButon.TabIndex = 13
        Me.IslemButon.Text = "İşlem Yap"
        Me.IslemButon.UseVisualStyleBackColor = False
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
        Me.AnaListe.Location = New System.Drawing.Point(27, 59)
        Me.AnaListe.Name = "AnaListe"
        Me.AnaListe.Size = New System.Drawing.Size(405, 109)
        Me.AnaListe.TabIndex = 10
        '
        'KitapBilgiPanel
        '
        Me.KitapBilgiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.KitapBilgiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KitapBilgiPanel.Controls.Add(Me.Label8)
        Me.KitapBilgiPanel.Controls.Add(Me.YazarBilgi)
        Me.KitapBilgiPanel.Controls.Add(Me.Label7)
        Me.KitapBilgiPanel.Controls.Add(Me.CikisYiliBilgi)
        Me.KitapBilgiPanel.Controls.Add(Me.KitapAdıBilgi)
        Me.KitapBilgiPanel.Controls.Add(Me.Label6)
        Me.KitapBilgiPanel.Controls.Add(Me.Label1)
        Me.KitapBilgiPanel.Controls.Add(Me.KitapBilgiButon)
        Me.KitapBilgiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.KitapBilgiPanel.Location = New System.Drawing.Point(700, 0)
        Me.KitapBilgiPanel.Name = "KitapBilgiPanel"
        Me.KitapBilgiPanel.Size = New System.Drawing.Size(485, 512)
        Me.KitapBilgiPanel.TabIndex = 11
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
        Me.KitapBilgiButon.Text = "Göster :)"
        Me.KitapBilgiButon.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label6.Location = New System.Drawing.Point(210, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Kitap Adı"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KitapAdıBilgi
        '
        Me.KitapAdıBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.KitapAdıBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.KitapAdıBilgi.Location = New System.Drawing.Point(151, 111)
        Me.KitapAdıBilgi.Name = "KitapAdıBilgi"
        Me.KitapAdıBilgi.Size = New System.Drawing.Size(183, 49)
        Me.KitapAdıBilgi.TabIndex = 31
        Me.KitapAdıBilgi.Text = ""
        '
        'CikisYiliBilgi
        '
        Me.CikisYiliBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.CikisYiliBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.CikisYiliBilgi.Location = New System.Drawing.Point(151, 205)
        Me.CikisYiliBilgi.Name = "CikisYiliBilgi"
        Me.CikisYiliBilgi.Size = New System.Drawing.Size(183, 26)
        Me.CikisYiliBilgi.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label7.Location = New System.Drawing.Point(178, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Kitabın Çıkış Tarihi"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YazarBilgi
        '
        Me.YazarBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.YazarBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.YazarBilgi.Location = New System.Drawing.Point(151, 282)
        Me.YazarBilgi.Name = "YazarBilgi"
        Me.YazarBilgi.Size = New System.Drawing.Size(183, 26)
        Me.YazarBilgi.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label8.Location = New System.Drawing.Point(203, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Yazar İsmi"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.Label1.Location = New System.Drawing.Point(14, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Seçilen Kitabın Bilgisini Göster --->"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.KitapEklePanel.PerformLayout()
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
    Friend WithEvents IslemButon As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Okuyacağım As ListBox
    Friend WithEvents Okuyorum As ListBox
    Friend WithEvents Okudum As ListBox
    Friend WithEvents Sil3 As Button
    Friend WithEvents Sil2 As Button
    Friend WithEvents Sil1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents WriterInfo As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents YazarBilgi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CikisYiliBilgi As TextBox
    Friend WithEvents KitapAdıBilgi As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
