Imports OverClick.PersistentProcess
Module PersistentProcessConsole
    ' Define Class / Sınıfı Tanımlıyoruz
    Dim persist As New PersistentProcess
    ' WARNING: These Commands won't work without Administrator / Bu Komutlar Uygulama Yönetici Olmadan Çalışamaz
    Sub Main()
        Console.Title = "Examples.PersistentProcessConsole /// TG: t.me/overclickofficial"
        Console.WriteLine("OverClick Telegram: t.me/overclickofficial")
        Console.WriteLine("                                          ")
        ' Get Privileges / Yetkileri Alıyoruz
        persist.YetkiAl()
        ' Enable Persistent Process / Kalıcı işlemi Etkinleştir
        persist.KaliciON()
        Console.WriteLine("Persistent Process Enabled / Kalıcı İşlem Etkin")
        Console.WriteLine("                                               ")
        Console.WriteLine("Type D123 to Disable Persistent Process")
        Console.WriteLine("Kalıcı işlemi Devre Dışı Bırakmak İçin D123 yazın")
        Dim cevap As String = Console.ReadLine
        If cevap = "D123" Then
            ' Get Privileges / Yetkileri Alıyoruz
            persist.YetkiAl()
            ' Disable Persistent Process / Kalıcı işlemi Devre Dışı Bırak
            persist.KaliciOFF()
            Console.WriteLine("Persistent Process Disabled")
            Console.WriteLine("Kalıcı İşlem Devre Dışı Bırakıldı")
            Console.WriteLine("                                          ")
            Console.WriteLine("OverClick Telegram: t.me/overclickofficial")
            Console.WriteLine("                                          ")
        End If
        Console.ReadLine()

    End Sub

End Module
