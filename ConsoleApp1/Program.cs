internal class Program
{
    private static void Main(string[] args)
    {
        //1) Klavyeden girilen A ve B gibi iki sayıyı, sadece toplama ve çıkarma işlemlerini kullanarak(direkt çarpma işlemi kullanmadan)
        //  çarpma işlemini yapan ve bunun sonucunu ekrana,
        //  ekranın geri plan rengi beyaz ve ekrana yazılan mesajın rengi kırmızı olacak şekilde yazan programı yazınız.

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;

        int carpimSonucu = 0, a, b;
        Console.WriteLine("Lütfen ilk sayıyı girin.");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
        b = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < b; i++)
        {
            carpimSonucu = carpimSonucu + a;
        }
        Console.WriteLine(a + "*" + b + "=" + carpimSonucu);


        // 1-100 arasındaki tüm asal sayıları ekrana yazdıran programı hazırlayınız.
        int sayac = 0;
        for (int sayi = 2; sayi < 100; sayi++)
        {
            int kont = 0;
            for (int x = 2; x < sayi; x++)
            {
                if (sayi % x == 0)
                {
                    kont = 1;
                    break;
                }
            }
            if (kont == 0)
            {
                Console.WriteLine(sayi + "\n");
                sayac++;
            }
        }

        //3) Klavyeden girilen 6 basamaklı bir sayının tüm basamaklarındaki sayıları toplayıp yazdıran programı hazırlayınız

        int girilenSayı, basamakToplamı = 0;
        Console.WriteLine("Lütfen altı basamakloı bir sayı giriniz.");
        girilenSayı = Convert.ToInt32(Console.ReadLine());

        while (girilenSayı > 0)
        {
            basamakToplamı += girilenSayı % 10;
            girilenSayı /= 10;

        }

        Console.WriteLine("basamak toplamı :" + basamakToplamı);

        //4) Bir ders için yapılan iki ara sınav ve bir genel sınav sonucu değerlendirilerek geçme notları hesaplanacaktır.
        // Bu dersin geçme notu 1.ara sınav notunun % 20’si,
        // 2.ara sınav notunun % 30’u ve genel sınav notunun % 50’si toplanarak hesaplanmaktadır.
        // Geçme notunu hesaplayan ve sonucu ekrana yazdıran programı yazın.

        double not1, not2, genelSınav, gecmeNotu;
        Console.Write("ilk ara sınav : ");
        not1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ikinci ara sınav : ");
        not2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("genel sınav: ");
        genelSınav = Convert.ToDouble(Console.ReadLine());

        gecmeNotu = ((not1 * 20) / 100) + ((not2 * 30) / 100) + ((genelSınav * 50) / 100);

        Console.WriteLine("Geçme notu :" + gecmeNotu);

        //5) Girilen 4 haneli bir tam sayının yüzler hanesindeki sayı degerinin 3 ile bölümünden elde edilen kalanın
        // aynı sayının birler hanesindeki deger ile farkını bulan programı yazın.

        int girilenSayı1, bin, binKalan, yuz, yuzkalan, on, onkalan, bir, fark;
        Console.WriteLine("lütfen dört basamaklı bir sayı giriniz: ");
        girilenSayı1 = Convert.ToInt32(Console.ReadLine());

        string cevir = girilenSayı1.ToString();
        if (cevir.Length == 4)
        {
            bin = girilenSayı1 / 1000;
            binKalan = girilenSayı1 - (bin * 1000);
            yuz = binKalan / 100;
            yuzkalan = binKalan - (yuz * 100);
            on = yuzkalan / 10;
            onkalan = yuzkalan - (on * 10);
            bir = onkalan * 1;
            Console.WriteLine("\n binlerbasmagı: {0}\n yüzler basamagı: {1}, \n onlar basamagı: {2}\n birler basamagı: {3}", bin, yuz, on, bir);
            fark = (yuz - (yuz / 3) * 3) - bir;
            Console.WriteLine("\n fark: " + fark);
        }
        else
        {
            Console.WriteLine("Dört rakamlı bri sayı girmediniz!");
        }



        Console.ReadKey();

    }
}