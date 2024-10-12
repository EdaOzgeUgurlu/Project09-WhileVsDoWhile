        //WHİLE
        Console.Write("Limit Degeri Giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        int sayac = 0;

        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir patika'lıyım! ");
            sayac++;
        }

        //DO-WHİLE
        Console.Write("Limit Degeri Giriniz: ");
        int limitt = Convert.ToInt32(Console.ReadLine());
        int sayacc = 0;

        do
        {
            Console.WriteLine("Ben bir patika'lıyım! ");
            sayacc++;
        }
        while (sayacc <= limitt);

        Console.ReadKey();

//While ve Do-While döngüleri arasındaki temel farkı: Döngünün çalıştırıldıktan sonra, koşulun kontrol edilmesi ve edilmemesinden kaynaklıdır.
//While döngüsünde : Koşul öncelikle kontrol edilir ve koşul sağlanmıyorsa döngü başlatılmaz.
//Do-While döngüsünde: Döngü en az bir kez çalışır ve sonra koşul kontrol edilir. Eğer ki koşul sağlanmıyorsa döngü sonlanır. 
//While döngüsünde : negatif bir limit girildiğinde, hiç çıktı üretmeyecek ve döngü çalışmayacaktır. çünkü belittiğimiz koşul sağlanmıyor.
//Do-While döngüsünde: dögü en az bir defa çalışır. sonra koşula bakar ve koşul sağlanmadığı için döngü sonlanır.Bu nedenle, negatif bir limit girişi olsa bile, "Ben bir Patika'lıyım" ifadesi bir kez yazdırılır.
