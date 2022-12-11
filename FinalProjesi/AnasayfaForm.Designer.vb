<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnasayfaForm
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
        Me.KitapEkrani = New System.Windows.Forms.Button()
        Me.OyunEkrani = New System.Windows.Forms.Button()
        Me.DiziEkrani = New System.Windows.Forms.Button()
        Me.FilmEkrani = New System.Windows.Forms.Button()
        Me.CikisButonu = New System.Windows.Forms.Button()
        Me.PanelAnasayfa = New System.Windows.Forms.Panel()
        Me.GeriDonButon = New System.Windows.Forms.Button()
        Me.PanelAnasayfa.SuspendLayout()
        Me.SuspendLayout()
        '
        'KitapEkrani
        '
        Me.KitapEkrani.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.KitapEkrani.FlatAppearance.BorderSize = 6
        Me.KitapEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KitapEkrani.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.KitapEkrani.Location = New System.Drawing.Point(0, 75)
        Me.KitapEkrani.Name = "KitapEkrani"
        Me.KitapEkrani.Size = New System.Drawing.Size(117, 63)
        Me.KitapEkrani.TabIndex = 0
        Me.KitapEkrani.Text = "Kitap Ekranı"
        Me.KitapEkrani.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.KitapEkrani.UseVisualStyleBackColor = False
        '
        'OyunEkrani
        '
        Me.OyunEkrani.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.OyunEkrani.FlatAppearance.BorderSize = 6
        Me.OyunEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OyunEkrani.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.OyunEkrani.Location = New System.Drawing.Point(195, 75)
        Me.OyunEkrani.Name = "OyunEkrani"
        Me.OyunEkrani.Size = New System.Drawing.Size(117, 63)
        Me.OyunEkrani.TabIndex = 1
        Me.OyunEkrani.Text = "Oyun Ekranı"
        Me.OyunEkrani.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.OyunEkrani.UseVisualStyleBackColor = False
        '
        'DiziEkrani
        '
        Me.DiziEkrani.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.DiziEkrani.FlatAppearance.BorderSize = 6
        Me.DiziEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DiziEkrani.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DiziEkrani.Location = New System.Drawing.Point(653, 75)
        Me.DiziEkrani.Name = "DiziEkrani"
        Me.DiziEkrani.Size = New System.Drawing.Size(117, 63)
        Me.DiziEkrani.TabIndex = 2
        Me.DiziEkrani.Text = "Dizi Ekranı"
        Me.DiziEkrani.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DiziEkrani.UseVisualStyleBackColor = False
        '
        'FilmEkrani
        '
        Me.FilmEkrani.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FilmEkrani.FlatAppearance.BorderSize = 6
        Me.FilmEkrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FilmEkrani.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FilmEkrani.Location = New System.Drawing.Point(863, 75)
        Me.FilmEkrani.Name = "FilmEkrani"
        Me.FilmEkrani.Size = New System.Drawing.Size(117, 63)
        Me.FilmEkrani.TabIndex = 3
        Me.FilmEkrani.Text = "Film Ekranı"
        Me.FilmEkrani.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FilmEkrani.UseVisualStyleBackColor = False
        '
        'CikisButonu
        '
        Me.CikisButonu.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.CikisButonu.FlatAppearance.BorderSize = 6
        Me.CikisButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CikisButonu.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CikisButonu.Location = New System.Drawing.Point(424, 75)
        Me.CikisButonu.Name = "CikisButonu"
        Me.CikisButonu.Size = New System.Drawing.Size(117, 63)
        Me.CikisButonu.TabIndex = 4
        Me.CikisButonu.Text = "Çıkış"
        Me.CikisButonu.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CikisButonu.UseVisualStyleBackColor = False
        '
        'PanelAnasayfa
        '
        Me.PanelAnasayfa.BackColor = System.Drawing.Color.Transparent
        Me.PanelAnasayfa.Controls.Add(Me.KitapEkrani)
        Me.PanelAnasayfa.Controls.Add(Me.OyunEkrani)
        Me.PanelAnasayfa.Controls.Add(Me.FilmEkrani)
        Me.PanelAnasayfa.Controls.Add(Me.CikisButonu)
        Me.PanelAnasayfa.Controls.Add(Me.DiziEkrani)
        Me.PanelAnasayfa.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAnasayfa.ForeColor = System.Drawing.Color.Transparent
        Me.PanelAnasayfa.Location = New System.Drawing.Point(0, 0)
        Me.PanelAnasayfa.Name = "PanelAnasayfa"
        Me.PanelAnasayfa.Size = New System.Drawing.Size(980, 187)
        Me.PanelAnasayfa.TabIndex = 6
        '
        'GeriDonButon
        '
        Me.GeriDonButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GeriDonButon.FlatAppearance.BorderSize = 6
        Me.GeriDonButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GeriDonButon.ForeColor = System.Drawing.Color.Chocolate
        Me.GeriDonButon.Location = New System.Drawing.Point(408, 393)
        Me.GeriDonButon.Name = "GeriDonButon"
        Me.GeriDonButon.Size = New System.Drawing.Size(121, 78)
        Me.GeriDonButon.TabIndex = 7
        Me.GeriDonButon.Text = "Geri Dön"
        Me.GeriDonButon.UseVisualStyleBackColor = False
        '
        'AnasayfaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 507)
        Me.Controls.Add(Me.GeriDonButon)
        Me.Controls.Add(Me.PanelAnasayfa)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.Chocolate
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AnasayfaForm"
        Me.Text = "Anasayfa Ekranı"
        Me.PanelAnasayfa.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KitapEkrani As Button
    Friend WithEvents OyunEkrani As Button
    Friend WithEvents DiziEkrani As Button
    Friend WithEvents FilmEkrani As Button
    Friend WithEvents CikisButonu As Button
    Friend WithEvents PanelAnasayfa As Panel
    Friend WithEvents GeriDonButon As Button
End Class
