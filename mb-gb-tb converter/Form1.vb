Imports System.Windows.Forms

Public Class Form1
    ' Dönüşüm işlemini yapacak fonksiyon
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputValue As Double

        ' Kullanıcının girdiği değeri kontrol et
        If Double.TryParse(txtInput.Text, inputValue) Then
            Dim mbResult As Double
            Dim gbResult As Double
            Dim tbResult As Double

            ' Seçilen RadioButton'a göre giriş birimini ayarla
            If rbtnMB.Checked Then
                mbResult = inputValue ' MB değeri
                gbResult = inputValue / 1024 ' MB'den GB'ye
                tbResult = inputValue / (1024 * 1024) ' MB'den TB'ye
            ElseIf rbtnGB.Checked Then
                mbResult = inputValue * 1024 ' GB'den MB'ye
                gbResult = inputValue ' GB değeri
                tbResult = inputValue / 1024 ' GB'den TB'ye
            ElseIf rbtnTB.Checked Then
                mbResult = inputValue * 1024 * 1024 ' TB'den MB'ye
                gbResult = inputValue * 1024 ' TB'den GB'ye
                tbResult = inputValue ' TB değeri
            End If

            ' ListBox'ı temizle ve yeni sonuçları ekle
            lstResults.Items.Clear()
            lstResults.Items.Add("Sonuçlar:")
            lstResults.Items.Add("Megabyte: " & mbResult.ToString("F0") & " MB")
            lstResults.Items.Add("Gigabyte: " & gbResult.ToString("F0") & " GB")
            lstResults.Items.Add("Terabyte: " & tbResult.ToString("F0") & " TB")
        Else
            MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ListBox'taki bir öğeye tıklandığında değeri TextBox'a yazdır ve panoya kopyala
    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        If lstResults.SelectedIndex > 0 Then ' "Sonuçlar:" satırını atlamak için kontrol
            Dim selectedItem As String = lstResults.SelectedItem.ToString()
            Dim valueOnly As String = selectedItem.Split(" "c)(1) ' Değer kısmını ayır
            txtInput.Text = valueOnly

            ' Seçilen öğeyi panoya kopyala
            Clipboard.SetText(selectedItem)
            MessageBox.Show("Sonuç panoya kopyalandı: " & selectedItem, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://algyazilim.com")
    End Sub
End Class
