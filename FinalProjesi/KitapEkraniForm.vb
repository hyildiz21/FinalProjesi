
Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class KitapEkraniForm
    Private Sub KitapEkraniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Kitapların Ana Listeye çekilmesi
        Dim connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"
        Dim conn As New SqlConnection(connectionString)
        conn.Open()

        Dim cmd As New SqlCommand("SELECT * FROM Books", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            AnaListe.Items.Add(reader("name"))
        End While
        reader.Close()
        conn.Close()


    End Sub


    Private Sub KitapEkleButon_Click(sender As Object, e As EventArgs) Handles KitapEkleButon.Click

        'Kitapların Book table a kaydolması
        Dim kitap = KitapEkleArea.Text
        AnaListe.Items.Add(kitap)

        Dim conn As New SqlConnection("Server=.;Database=FINALPROJE;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("INSERT INTO Books (name) VALUES (@name)", conn)
        conn.Open()
        cmd.Parameters.AddWithValue("@name", kitap)
        cmd.ExecuteNonQuery()
        conn.Close()

        KitapEkleArea.Clear()

        MsgBox("Kitap Başarılı Şekilde Eklendi")




    End Sub

    Private Sub OkudumButon_Click(sender As Object, e As EventArgs) Handles OkudumButon.Click

        If RadioButton1.Checked Then
            Dim value = Okudum.Items.Add(AnaListe.SelectedItem)
            Okudum.ForeColor = Color.DeepSkyBlue
        End If

    End Sub

    Private Sub OkuyorumButon_Click(sender As Object, e As EventArgs) Handles OkuyorumButon.Click

        If RadioButton2.Checked Then
            Dim value2 = Okuyorum.Items.Add(AnaListe.SelectedItem)
            Okuyorum.ForeColor = Color.IndianRed
        End If

    End Sub

    Private Sub OkuyacagimButon_Click(sender As Object, e As EventArgs) Handles OkuyacagimButon.Click

        If RadioButton3.Checked Then
            Dim value3 = Okuyacağım.Items.Add(AnaListe.SelectedItem)
            Okuyacağım.ForeColor = Color.DarkSeaGreen
        End If

    End Sub

    Private Sub Sil1_Click(sender As Object, e As EventArgs) Handles Sil1.Click
        Dim x = Okudum.SelectedItem
        MsgBox("Silinecek kitap: " & x)
        Okudum.Items.Remove(x)
    End Sub

    Private Sub Sil2_Click(sender As Object, e As EventArgs) Handles Sil2.Click
        Dim x = Okuyorum.SelectedItem
        MsgBox("Silinecek kitap: " & x)
        Okuyorum.Items.Remove(x)
    End Sub

    Private Sub Sil3_Click(sender As Object, e As EventArgs) Handles Sil3.Click
        Dim x = Okuyacağım.SelectedItem
        MsgBox("Silinecek kitap: " & x)
        Okuyacağım.Items.Remove(x)
    End Sub

    Private Sub KitapBilgiButon_Click(sender As Object, e As EventArgs) Handles KitapBilgiButon.Click
        MsgBox(AnaListe.SelectedItem)

    End Sub
End Class