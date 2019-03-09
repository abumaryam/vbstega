Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        textboxImage.Text = "Ini hasilnya nak"
        Dim gambar As New Bitmap(boxGambar.Image)

        Dim x, y As Integer
        Dim rint, gint, bint As Integer
        Dim rbin, gbin, bbin As String


        textboxImage.Text = "Lebar = " & gambar.Width & " dan Tinggi = " & gambar.Height

        ' rbin = DecimalToBinary(gambar.GetPixel(0, 0).R)
        rint = gambar.GetPixel(0, 0).R
        rbin = Convert.ToString(rint, 2).PadLeft(8, "0"c)
        gint = gambar.GetPixel(0, 0).G
        gbin = Convert.ToString(gint, 2).PadLeft(8, "0"c)
        bint = gambar.GetPixel(0, 0).B
        bbin = Convert.ToString(bint, 2).PadLeft(8, "0"c)

        textboxImage.Text = textboxImage.Text & vbCrLf & "R = " & rint & " bin = " & rbin
        textboxImage.Text = textboxImage.Text & vbCrLf & "G = " & gint & " bin = " & gbin
        textboxImage.Text = textboxImage.Text & vbCrLf & "B = " & bint & " bin = " & bbin
    End Sub

    Private Sub btnASCII_Click(sender As Object, e As EventArgs) Handles btnASCII.Click
        Dim textInput, textOutput, decAsc As String

        Dim i, tempInt As Integer
        textOutput = "DEC : "

        textInput = TbInputASCII.Text

        Dim binChar(textInput.Length) As Char
        i = 0
        For Each karakter As Char In textInput
            decAsc = Asc(karakter)
            textOutput = textOutput & " " & decAsc
            tempInt = Convert.ToInt32(decAsc)
            binChar(i) = Convert.ToString(tempInt, 2).PadLeft(16, "0"c)
            i = i + 1
        Next

        textOutput = textOutput & vbCrLf & "BIN : "

        For Each kar2 As Char In binChar
            textOutput = textOutput & " " & kar2.ToString
        Next

        TbOutputASCII.Text = textOutput

    End Sub
End Class