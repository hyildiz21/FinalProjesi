<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilmEkraniForm
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
        Me.FilmEklePanel = New System.Windows.Forms.Panel()
        Me.FilmEkleArea = New System.Windows.Forms.RichTextBox()
        Me.FilmEkleButon = New System.Windows.Forms.Button()
        Me.DiziListesiPanel = New System.Windows.Forms.Panel()
        Me.Sil3 = New System.Windows.Forms.Button()
        Me.Sil2 = New System.Windows.Forms.Button()
        Me.Sil1 = New System.Windows.Forms.Button()
        Me.Izleyecegim = New System.Windows.Forms.ListBox()
        Me.Izlıyorum = New System.Windows.Forms.ListBox()
        Me.Izledim = New System.Windows.Forms.ListBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.IslemButon = New System.Windows.Forms.Button()
        Me.FilmListesiLabel = New System.Windows.Forms.Label()
        Me.AnaListe = New System.Windows.Forms.ListBox()
        Me.FilmBilgiPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FilmBilgiButon = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DirectorTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IMDbTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FilmAdıBilgi = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CikisYiliBilgi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DirectorBilgi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IMDbBilgi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FilmEklePanel.SuspendLayout()
        Me.DiziListesiPanel.SuspendLayout()
        Me.FilmBilgiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilmEklePanel
        '
        Me.FilmEklePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.FilmEklePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FilmEklePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilmEklePanel.Controls.Add(Me.IMDbTextBox)
        Me.FilmEklePanel.Controls.Add(Me.Label4)
        Me.FilmEklePanel.Controls.Add(Me.DirectorTextBox)
        Me.FilmEklePanel.Controls.Add(Me.Label3)
        Me.FilmEklePanel.Controls.Add(Me.DateTextBox)
        Me.FilmEklePanel.Controls.Add(Me.Label2)
        Me.FilmEklePanel.Controls.Add(Me.Label1)
        Me.FilmEklePanel.Controls.Add(Me.Label5)
        Me.FilmEklePanel.Controls.Add(Me.FilmEkleArea)
        Me.FilmEklePanel.Controls.Add(Me.FilmEkleButon)
        Me.FilmEklePanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FilmEklePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.FilmEklePanel.Location = New System.Drawing.Point(0, 0)
        Me.FilmEklePanel.Name = "FilmEklePanel"
        Me.FilmEklePanel.Size = New System.Drawing.Size(250, 511)
        Me.FilmEklePanel.TabIndex = 12
        '
        'FilmEkleArea
        '
        Me.FilmEkleArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FilmEkleArea.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.FilmEkleArea.Location = New System.Drawing.Point(30, 100)
        Me.FilmEkleArea.Name = "FilmEkleArea"
        Me.FilmEkleArea.Size = New System.Drawing.Size(183, 49)
        Me.FilmEkleArea.TabIndex = 9
        Me.FilmEkleArea.Text = ""
        '
        'FilmEkleButon
        '
        Me.FilmEkleButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FilmEkleButon.FlatAppearance.BorderSize = 6
        Me.FilmEkleButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilmEkleButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.FilmEkleButon.ForeColor = System.Drawing.Color.Indigo
        Me.FilmEkleButon.Location = New System.Drawing.Point(45, 422)
        Me.FilmEkleButon.Name = "FilmEkleButon"
        Me.FilmEkleButon.Size = New System.Drawing.Size(133, 44)
        Me.FilmEkleButon.TabIndex = 8
        Me.FilmEkleButon.Text = "Film Ekle"
        Me.FilmEkleButon.UseVisualStyleBackColor = False
        '
        'DiziListesiPanel
        '
        Me.DiziListesiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DiziListesiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DiziListesiPanel.Controls.Add(Me.Sil3)
        Me.DiziListesiPanel.Controls.Add(Me.Sil2)
        Me.DiziListesiPanel.Controls.Add(Me.Sil1)
        Me.DiziListesiPanel.Controls.Add(Me.Izleyecegim)
        Me.DiziListesiPanel.Controls.Add(Me.Izlıyorum)
        Me.DiziListesiPanel.Controls.Add(Me.Izledim)
        Me.DiziListesiPanel.Controls.Add(Me.RadioButton3)
        Me.DiziListesiPanel.Controls.Add(Me.RadioButton2)
        Me.DiziListesiPanel.Controls.Add(Me.RadioButton1)
        Me.DiziListesiPanel.Controls.Add(Me.IslemButon)
        Me.DiziListesiPanel.Controls.Add(Me.FilmListesiLabel)
        Me.DiziListesiPanel.Controls.Add(Me.AnaListe)
        Me.DiziListesiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DiziListesiPanel.Location = New System.Drawing.Point(250, 0)
        Me.DiziListesiPanel.Name = "DiziListesiPanel"
        Me.DiziListesiPanel.Size = New System.Drawing.Size(450, 511)
        Me.DiziListesiPanel.TabIndex = 13
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
        'Izleyecegim
        '
        Me.Izleyecegim.BackColor = System.Drawing.Color.PapayaWhip
        Me.Izleyecegim.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Izleyecegim.FormattingEnabled = True
        Me.Izleyecegim.ItemHeight = 15
        Me.Izleyecegim.Location = New System.Drawing.Point(299, 285)
        Me.Izleyecegim.Name = "Izleyecegim"
        Me.Izleyecegim.Size = New System.Drawing.Size(120, 94)
        Me.Izleyecegim.TabIndex = 20
        '
        'Izlıyorum
        '
        Me.Izlıyorum.BackColor = System.Drawing.Color.PapayaWhip
        Me.Izlıyorum.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Izlıyorum.FormattingEnabled = True
        Me.Izlıyorum.ItemHeight = 15
        Me.Izlıyorum.Location = New System.Drawing.Point(149, 285)
        Me.Izlıyorum.Name = "Izlıyorum"
        Me.Izlıyorum.Size = New System.Drawing.Size(120, 94)
        Me.Izlıyorum.TabIndex = 19
        '
        'Izledim
        '
        Me.Izledim.BackColor = System.Drawing.Color.PapayaWhip
        Me.Izledim.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Izledim.FormattingEnabled = True
        Me.Izledim.ItemHeight = 15
        Me.Izledim.Location = New System.Drawing.Point(4, 285)
        Me.Izledim.Name = "Izledim"
        Me.Izledim.Size = New System.Drawing.Size(120, 94)
        Me.Izledim.TabIndex = 18
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton3.Location = New System.Drawing.Point(309, 191)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(87, 19)
        Me.RadioButton3.TabIndex = 17
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "İzleyeceğim"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton2.Location = New System.Drawing.Point(164, 191)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 19)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "İzliyorum"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.RadioButton1.Location = New System.Drawing.Point(27, 191)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 19)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "İzledim"
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
        'FilmListesiLabel
        '
        Me.FilmListesiLabel.AutoSize = True
        Me.FilmListesiLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FilmListesiLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilmListesiLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilmListesiLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.FilmListesiLabel.Location = New System.Drawing.Point(164, 22)
        Me.FilmListesiLabel.Name = "FilmListesiLabel"
        Me.FilmListesiLabel.Size = New System.Drawing.Size(112, 25)
        Me.FilmListesiLabel.TabIndex = 11
        Me.FilmListesiLabel.Text = "Film Listesi"
        Me.FilmListesiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'FilmBilgiPanel
        '
        Me.FilmBilgiPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.FilmBilgiPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FilmBilgiPanel.Controls.Add(Me.Label10)
        Me.FilmBilgiPanel.Controls.Add(Me.IMDbBilgi)
        Me.FilmBilgiPanel.Controls.Add(Me.Label9)
        Me.FilmBilgiPanel.Controls.Add(Me.DirectorBilgi)
        Me.FilmBilgiPanel.Controls.Add(Me.Label8)
        Me.FilmBilgiPanel.Controls.Add(Me.CikisYiliBilgi)
        Me.FilmBilgiPanel.Controls.Add(Me.Label7)
        Me.FilmBilgiPanel.Controls.Add(Me.FilmAdıBilgi)
        Me.FilmBilgiPanel.Controls.Add(Me.Label6)
        Me.FilmBilgiPanel.Controls.Add(Me.FilmBilgiButon)
        Me.FilmBilgiPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.FilmBilgiPanel.Location = New System.Drawing.Point(700, 0)
        Me.FilmBilgiPanel.Name = "FilmBilgiPanel"
        Me.FilmBilgiPanel.Size = New System.Drawing.Size(504, 511)
        Me.FilmBilgiPanel.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Film Bilgi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilmBilgiButon
        '
        Me.FilmBilgiButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FilmBilgiButon.FlatAppearance.BorderSize = 6
        Me.FilmBilgiButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilmBilgiButon.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.FilmBilgiButon.ForeColor = System.Drawing.Color.Indigo
        Me.FilmBilgiButon.Location = New System.Drawing.Point(298, 13)
        Me.FilmBilgiButon.Name = "FilmBilgiButon"
        Me.FilmBilgiButon.Size = New System.Drawing.Size(156, 44)
        Me.FilmBilgiButon.TabIndex = 10
        Me.FilmBilgiButon.Text = "Film Bilgi"
        Me.FilmBilgiButon.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label5.Location = New System.Drawing.Point(30, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Film Adı"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label2.Location = New System.Drawing.Point(30, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Çıkış Tarihi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTextBox
        '
        Me.DateTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DateTextBox.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.DateTextBox.Location = New System.Drawing.Point(30, 191)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(183, 26)
        Me.DateTextBox.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label3.Location = New System.Drawing.Point(30, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Yönetmen"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DirectorTextBox
        '
        Me.DirectorTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DirectorTextBox.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.DirectorTextBox.Location = New System.Drawing.Point(30, 257)
        Me.DirectorTextBox.Name = "DirectorTextBox"
        Me.DirectorTextBox.Size = New System.Drawing.Size(183, 26)
        Me.DirectorTextBox.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label4.Location = New System.Drawing.Point(30, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "IMDb Puanı"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IMDbTextBox
        '
        Me.IMDbTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IMDbTextBox.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.IMDbTextBox.Location = New System.Drawing.Point(30, 318)
        Me.IMDbTextBox.Name = "IMDbTextBox"
        Me.IMDbTextBox.Size = New System.Drawing.Size(183, 26)
        Me.IMDbTextBox.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label6.Location = New System.Drawing.Point(214, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Filmin Adı"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilmAdıBilgi
        '
        Me.FilmAdıBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.FilmAdıBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.FilmAdıBilgi.Location = New System.Drawing.Point(158, 122)
        Me.FilmAdıBilgi.Name = "FilmAdıBilgi"
        Me.FilmAdıBilgi.Size = New System.Drawing.Size(183, 49)
        Me.FilmAdıBilgi.TabIndex = 38
        Me.FilmAdıBilgi.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label7.Location = New System.Drawing.Point(188, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Filmin Çıkış Tarihi"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CikisYiliBilgi
        '
        Me.CikisYiliBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.CikisYiliBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.CikisYiliBilgi.Location = New System.Drawing.Point(158, 213)
        Me.CikisYiliBilgi.Name = "CikisYiliBilgi"
        Me.CikisYiliBilgi.Size = New System.Drawing.Size(183, 26)
        Me.CikisYiliBilgi.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label8.Location = New System.Drawing.Point(188, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 19)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Yönetmen Adı"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DirectorBilgi
        '
        Me.DirectorBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.DirectorBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.DirectorBilgi.Location = New System.Drawing.Point(158, 296)
        Me.DirectorBilgi.Name = "DirectorBilgi"
        Me.DirectorBilgi.Size = New System.Drawing.Size(183, 26)
        Me.DirectorBilgi.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.75!)
        Me.Label9.Location = New System.Drawing.Point(201, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 19)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "IMDb Puanı"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IMDbBilgi
        '
        Me.IMDbBilgi.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.IMDbBilgi.Font = New System.Drawing.Font("Times New Roman", 11.75!)
        Me.IMDbBilgi.Location = New System.Drawing.Point(158, 368)
        Me.IMDbBilgi.Name = "IMDbBilgi"
        Me.IMDbBilgi.Size = New System.Drawing.Size(183, 26)
        Me.IMDbBilgi.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.75!)
        Me.Label10.Location = New System.Drawing.Point(21, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(257, 21)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Seçilen Filmin Bilgisini Göster --->"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilmEkraniForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 511)
        Me.Controls.Add(Me.FilmBilgiPanel)
        Me.Controls.Add(Me.DiziListesiPanel)
        Me.Controls.Add(Me.FilmEklePanel)
        Me.MaximizeBox = False
        Me.Name = "FilmEkraniForm"
        Me.Text = "Film Ekranı"
        Me.FilmEklePanel.ResumeLayout(False)
        Me.FilmEklePanel.PerformLayout()
        Me.DiziListesiPanel.ResumeLayout(False)
        Me.DiziListesiPanel.PerformLayout()
        Me.FilmBilgiPanel.ResumeLayout(False)
        Me.FilmBilgiPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FilmEklePanel As Panel
    Friend WithEvents FilmEkleArea As RichTextBox
    Friend WithEvents FilmEkleButon As Button
    Friend WithEvents DiziListesiPanel As Panel
    Friend WithEvents Sil3 As Button
    Friend WithEvents Sil2 As Button
    Friend WithEvents Sil1 As Button
    Friend WithEvents Izleyecegim As ListBox
    Friend WithEvents Izlıyorum As ListBox
    Friend WithEvents Izledim As ListBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents IslemButon As Button
    Friend WithEvents FilmListesiLabel As Label
    Friend WithEvents AnaListe As ListBox
    Friend WithEvents FilmBilgiPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FilmBilgiButon As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DirectorTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IMDbTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FilmAdıBilgi As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CikisYiliBilgi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DirectorBilgi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents IMDbBilgi As TextBox
    Friend WithEvents Label10 As Label
End Class
