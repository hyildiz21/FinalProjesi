Public Class AnasayfaForm
    Private Sub AnasayfaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mavi 1
        PanelAnasayfa.BackColor = Color.FromArgb(191, 215, 236)
        'mavi 2
        Me.BackColor = Color.FromArgb(207, 224, 241)


    End Sub

    Private Sub KitapEkrani_Click(sender As Object, e As EventArgs) Handles KitapEkrani.Click
        KitapEkraniForm.Show()

    End Sub

    Private Sub OyunEkrani_Click(sender As Object, e As EventArgs) Handles OyunEkrani.Click
        OyunEkraniForm.Show()

    End Sub

    Private Sub DiziEkrani_Click(sender As Object, e As EventArgs) Handles DiziEkrani.Click
        DiziEkraniForm.Show()

    End Sub

    Private Sub FilmEkrani_Click(sender As Object, e As EventArgs) Handles FilmEkrani.Click
        FilmEkraniForm.Show()

    End Sub

    Private Sub GeriDonButon_Click(sender As Object, e As EventArgs) Handles GeriDonButon.Click
        GirisForm.Show()

    End Sub

    Private Sub CikisButonu_Click(sender As Object, e As EventArgs) Handles CikisButonu.Click
        Application.Exit()
    End Sub

End Class