Imports System.Data.SqlClient

Public Class OyunEkraniForm
    Private Sub OyunEkraniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Oyunların Ana Listeye çekilmesi
        Dim connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"
        Dim conn As New SqlConnection(connectionString)
        conn.Open()

        Dim cmd As New SqlCommand("SELECT * FROM Games", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            AnaListe.Items.Add(reader("name"))
        End While
        reader.Close()
        conn.Close()


    End Sub



    Private Sub OynadımButon_Click(sender As Object, e As EventArgs) Handles OynadımButon.Click
        If RadioButton1.Checked Then
            Dim value = Oynadım.Items.Add(AnaListe.SelectedItem)
            Oynadım.ForeColor = Color.DeepSkyBlue
        End If
    End Sub

    Private Sub OynuyorumButon_Click(sender As Object, e As EventArgs) Handles OynuyorumButon.Click
        If RadioButton2.Checked Then
            Dim value2 = Oynuyorum.Items.Add(AnaListe.SelectedItem)
            Oynuyorum.ForeColor = Color.IndianRed
        End If
    End Sub

    Private Sub OynayacagimButon_Click(sender As Object, e As EventArgs) Handles OynayacagimButon.Click
        If RadioButton3.Checked Then
            Dim value3 = Oynayacagim.Items.Add(AnaListe.SelectedItem)
            Oynayacagim.ForeColor = Color.DarkSeaGreen
        End If
    End Sub

    Private Sub Sil1_Click(sender As Object, e As EventArgs) Handles Sil1.Click
        Dim x = Oynadım.SelectedItem
        MsgBox("Silinecek oyun: " & x)
        Oynadım.Items.Remove(x)
    End Sub

    Private Sub Sil2_Click(sender As Object, e As EventArgs) Handles Sil2.Click
        Dim x = Oynuyorum.SelectedItem
        MsgBox("Silinecek oyun: " & x)
        Oynuyorum.Items.Remove(x)
    End Sub

    Private Sub Sil3_Click(sender As Object, e As EventArgs) Handles Sil3.Click
        Dim x = Oynayacagim.SelectedItem
        MsgBox("Silinecek oyun: " & x)
        Oynayacagim.Items.Remove(x)
    End Sub

    Private Sub OyunBilgiButon_Click(sender As Object, e As EventArgs) Handles OyunBilgiButon.Click
        MsgBox(AnaListe.SelectedItem)
    End Sub

    Private Sub OyunEkleButon_Click(sender As Object, e As EventArgs) Handles OyunEkleButon.Click
        Dim oyun = OyunEkleArea.Text
        AnaListe.Items.Add(oyun)

        Dim conn As New SqlConnection("Server=.;Database=FINALPROJE;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("INSERT INTO Games (name) VALUES (@name)", conn)
        conn.Open()
        cmd.Parameters.AddWithValue("@name", oyun)
        cmd.ExecuteNonQuery()
        conn.Close()

        OyunEkleArea.Clear()
    End Sub
End Class