
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FinalProjesi.FINALPROJEDataSetTableAdapters
Imports FontAwesome.Sharp

Public Class KitapEkraniForm

    Dim connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"
    Dim conn As New SqlConnection(connectionString)

    Private Sub KitapEkraniForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Kitapların Ana Listeye çekilmesi
        'Dim connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"
        'Dim conn As New SqlConnection(connectionString)
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

        Dim releaseDate = DateTextBox.Text
        Dim infoWriter = WriterInfo.Text


        Dim conn As New SqlConnection("Server=.;Database=FINALPROJE;Trusted_Connection=True;")
        Dim cmd As New SqlCommand("INSERT INTO Books (name, releaseDate, writerInfo) VALUES (@name, @releaseDate, @writerInfo)", conn)
        conn.Open()
        cmd.Parameters.AddWithValue("@name", kitap)
        cmd.Parameters.AddWithValue("@releaseDate", releaseDate)
        cmd.Parameters.AddWithValue("@writerInfo", infoWriter)
        cmd.ExecuteNonQuery()
        conn.Close()

        KitapEkleArea.Clear()
        DateTextBox.Clear()
        WriterInfo.Clear()

        MsgBox("Kitap Başarılı Şekilde Eklendi")

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
        Dim selectedValue As String = AnaListe.SelectedItem
        conn.Open()

        Dim commandText As String = "SELECT * FROM Books WHERE name = @name"
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
                'writerInfo
                Dim v4 As String = reader.GetValue(3)
                KitapAdıBilgi.Text = v2
                CikisYiliBilgi.Text = v3
                YazarBilgi.Text = v4

            End While
        End If
        reader.Close()
        conn.Close()

    End Sub

    Private Sub IslemButon_Click(sender As Object, e As EventArgs) Handles IslemButon.Click

        If RadioButton1.Checked Then
            Dim value = Okudum.Items.Add(AnaListe.SelectedItem)
            Okudum.ForeColor = Color.DeepSkyBlue
        End If

        If RadioButton2.Checked Then
            Dim value2 = Okuyorum.Items.Add(AnaListe.SelectedItem)
            Okuyorum.ForeColor = Color.IndianRed
        End If

        If RadioButton3.Checked Then
            Dim value3 = Okuyacağım.Items.Add(AnaListe.SelectedItem)
            Okuyacağım.ForeColor = Color.DarkSeaGreen
        End If
    End Sub

End Class