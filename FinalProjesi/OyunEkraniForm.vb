Imports System.Data.SqlClient

Public Class OyunEkraniForm
    'Oyunların Ana Listeye çekilmesi
    Dim connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"
    Dim conn As New SqlConnection(connectionString)
    Private Sub OyunEkraniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn.Open()

        Dim cmd As New SqlCommand("SELECT * FROM Games", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            AnaListe.Items.Add(reader("name"))
        End While
        reader.Close()
        conn.Close()

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
        Dim selectedValue As String = AnaListe.SelectedItem
        conn.Open()

        Dim commandText As String = "SELECT * FROM Games WHERE name = @name"
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
                'developerCompany
                Dim v4 As String = reader.GetValue(3)
                OyunAdıBilgi.Text = v2
                CikisYiliBilgi.Text = v3
                DevTextBox.Text = v4

            End While
        End If
        reader.Close()
        conn.Close()
    End Sub

    Private Sub OyunEkleButon_Click(sender As Object, e As EventArgs) Handles OyunEkleButon.Click
        Dim oyun = OyunEkleArea.Text
        AnaListe.Items.Add(oyun)

        Dim releaseDate = DateTextBox.Text
        Dim devComp = DevCompTextBox.Text

        Dim conn As New SqlConnection("Server=.;Database=FINALPROJE;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("INSERT INTO Games (name, releaseDate, developerCompany) VALUES (@name, @releaseDate, @developerCompany)", conn)
        conn.Open()
        cmd.Parameters.AddWithValue("@name", oyun)
        cmd.Parameters.AddWithValue("@releaseDate", releaseDate)
        cmd.Parameters.AddWithValue("@developerCompany", devComp)
        cmd.ExecuteNonQuery()
        conn.Close()

        OyunEkleArea.Clear()
        DateTextBox.Clear()
        DevCompTextBox.Clear()
    End Sub

    Private Sub IslemButon_Click(sender As Object, e As EventArgs) Handles IslemButon.Click

        If RadioButton1.Checked Then
            Dim value = Oynadım.Items.Add(AnaListe.SelectedItem)
            Oynadım.ForeColor = Color.DeepSkyBlue
        End If

        If RadioButton2.Checked Then
            Dim value2 = Oynuyorum.Items.Add(AnaListe.SelectedItem)
            Oynuyorum.ForeColor = Color.IndianRed
        End If

        If RadioButton3.Checked Then
            Dim value3 = Oynayacagim.Items.Add(AnaListe.SelectedItem)
            Oynayacagim.ForeColor = Color.DarkSeaGreen
        End If
    End Sub

End Class