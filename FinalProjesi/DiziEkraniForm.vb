Imports System.Data.SqlClient

Public Class DiziEkraniForm
    Dim connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"
    Dim conn As New SqlConnection(connectionString)

    Private Sub DiziEkraniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Open()

        Dim cmd As New SqlCommand("SELECT * FROM Series", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            AnaListe.Items.Add(reader("name"))
        End While
        reader.Close()
        conn.Close()

    End Sub

    Private Sub DiziEkleButon_Click(sender As Object, e As EventArgs) Handles DiziEkleButon.Click
        Dim oyun = DiziEkleArea.Text
        AnaListe.Items.Add(oyun)

        Dim releaseDate = DateTextBox.Text
        Dim sezonSayisi = SezonTextBox.Text
        Dim favBolum = FavbolumTextBox.Text

        Dim conn As New SqlConnection("Server=.;Database=FINALPROJE;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("INSERT INTO Series (name, releaseDate, seasons, episode) VALUES (@name, @releaseDate, @seasons, @episode)", conn)
        conn.Open()
        cmd.Parameters.AddWithValue("@name", oyun)
        cmd.Parameters.AddWithValue("@releaseDate", releaseDate)
        cmd.Parameters.AddWithValue("@seasons", sezonSayisi)
        cmd.Parameters.AddWithValue("@episode", favBolum)
        cmd.ExecuteNonQuery()
        conn.Close()

        DiziEkleArea.Clear()
        DateTextBox.Clear()
        SezonTextBox.Clear()
        FavbolumTextBox.Clear()
    End Sub

    Private Sub Sil1_Click(sender As Object, e As EventArgs) Handles Sil1.Click
        Dim x = Izledim.SelectedItem
        MsgBox("Silinecek oyun: " & x)
        Izledim.Items.Remove(x)
    End Sub

    Private Sub Sil2_Click(sender As Object, e As EventArgs) Handles Sil2.Click
        Dim x = Izlıyorum.SelectedItem
        MsgBox("Silinecek oyun: " & x)
        Izlıyorum.Items.Remove(x)
    End Sub

    Private Sub Sil3_Click(sender As Object, e As EventArgs) Handles Sil3.Click
        Dim x = Izleyecegim.SelectedItem
        MsgBox("Silinecek oyun: " & x)
        Izleyecegim.Items.Remove(x)
    End Sub

    Private Sub DiziBilgiButon_Click(sender As Object, e As EventArgs) Handles DiziBilgiButon.Click
        Dim selectedValue As String = AnaListe.SelectedItem
        conn.Open()

        Dim commandText As String = "SELECT * FROM Series WHERE name = @name"
        Dim command As New SqlCommand(commandText, conn)
        command.Parameters.AddWithValue("@name", selectedValue)
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                'id
                Dim v1 As String = reader.GetValue(0)
                'name
                Dim v2 As String = reader.GetValue(1)
                'releaseDate
                Dim v3 As String = reader.GetValue(2)
                'season
                Dim v4 As String = reader.GetValue(3)
                'episode
                Dim v5 As String = reader.GetValue(4)
                DiziAdıBilgi.Text = v2
                CikisYiliBilgi.Text = v3
                SezonTextBoxBilgi.Text = v4
                FavBolumBilgi.Text = v5

            End While
        End If
        reader.Close()
        conn.Close()
    End Sub

    Private Sub IslemButon_Click(sender As Object, e As EventArgs) Handles IslemButon.Click
        If RadioButton1.Checked Then
            Dim value = Izledim.Items.Add(AnaListe.SelectedItem)
            Izledim.ForeColor = Color.DeepSkyBlue
        End If

        If RadioButton2.Checked Then
            Dim value2 = Izlıyorum.Items.Add(AnaListe.SelectedItem)
            Izlıyorum.ForeColor = Color.IndianRed
        End If

        If RadioButton3.Checked Then
            Dim value3 = Izleyecegim.Items.Add(AnaListe.SelectedItem)
            Izleyecegim.ForeColor = Color.DarkSeaGreen
        End If
    End Sub
End Class