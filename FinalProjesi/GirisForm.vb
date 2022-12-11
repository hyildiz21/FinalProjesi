Imports System.Data.SqlClient

Public Class GirisForm

    ReadOnly connectionString As String = "Server=.;Database=FINALPROJE;Trusted_Connection=True;"

    Private Sub girisbutton_Click(sender As Object, e As EventArgs) Handles girisbutton.Click
        Dim conn As SqlConnection = New SqlConnection(connectionString)
        conn.Open()
        Dim cmd As New SqlCommand("SELECT username FROM Users WHERE password = @password", conn)
        cmd.Parameters.AddWithValue("@password", TextBox2.Text)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            Dim column1 As String = reader("username").ToString()
            If column1 = TextBox1.Text Then
                Me.Hide()
                AnasayfaForm.Show()
            Else
                MsgBox("aaaa")
            End If
        End While

    End Sub

    Private Sub GirisForm_Load(sender As Object, e As EventArgs)
        KayitButon.BackColor = Color.FromArgb(223, 234, 246)

        girisbutton.BackColor = Color.DarkSeaGreen
        girisbutton.ForeColor = Color.White

        TextBox1.BackColor = Color.RoyalBlue
        TextBox1.ForeColor = Color.White
        TextBox2.BackColor = Color.RoyalBlue
        TextBox2.ForeColor = Color.White
    End Sub

    Private Sub KayitButon_Click(sender As Object, e As EventArgs) Handles KayitButon.Click
        Dim conn As SqlConnection = New SqlConnection(connectionString)
        conn.Open()

        If TextBox1.Text IsNot "" Then

            If conn.State = System.Data.ConnectionState.Open Then

                Dim cmd3 As New SqlCommand("INSERT INTO Users (username, password) VALUES (@username, @password)", conn)
                MsgBox("Kayıt ekleme başarılı")
                'aynı kullanıcıyı 2 kez kayıt etmesin.
                cmd3.Parameters.AddWithValue("@username", TextBox1.Text)
                cmd3.Parameters.AddWithValue("@password", TextBox2.Text)
                cmd3.ExecuteNonQuery()

            End If
        Else
            MsgBox("Giriş Başarısız, tekrar dene.")
        End If

    End Sub

    Private Sub CikisButon_Click(sender As Object, e As EventArgs) Handles CikisButon.Click
        Application.Exit()
    End Sub
End Class
