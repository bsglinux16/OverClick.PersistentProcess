Imports OverClick.PersistentProcess

Public Class ExampleUI
    ' Define Class / Sınıfı Tanımlıyoruz
    Dim persist As New PersistentProcess
    ' WARNING: These Commands won't work without Administrator / Bu Komutlar Uygulama Yönetici Olmadan Çalışamaz
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get Privileges / Yetkileri Alıyoruz
        persist.YetkiAl()
        ' Enable Persistent Process / Kalıcı işlemi Etkinleştir
        persist.KaliciON()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Get Privileges / Yetkileri Alıyoruz
        persist.YetkiAl()
        ' Disable Persistent Process / Kalıcı işlemi Devre Dışı Bırak
        persist.KaliciOFF()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://t.me/overclickofficial")
    End Sub
End Class
