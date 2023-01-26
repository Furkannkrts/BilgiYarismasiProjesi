// See https://aka.ms/new-console-template for more information

{

    Console.WriteLine("Bilgi Yarışmsına Hoşgeldiniz");
    Console.WriteLine();
    Console.WriteLine("---------------------------");
    Console.WriteLine();

    int soru = 1;
    string cevap;
    if (soru == 1)
    {
        Console.WriteLine("Kanada'nın Başkenti Neresidir?");
        Console.WriteLine();
        Console.WriteLine("A) Toronto");
        Console.WriteLine("B) Ottowa");
        Console.WriteLine("C) Montreal");
        Console.WriteLine("D) Vancouver");
        Console.WriteLine();
        Console.Write("Cevabınız: ");
        cevap=Console.ReadLine();

        if(cevap=="b"||cevap=="B") 
        {
            soru=soru+1;
        }
        else 
        {
            Console.WriteLine("Cevabınız Yanlış.Puanınız:0");
        }
    }
    if (soru == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Uzaktan kumanda ilk kez Amerika'da kaç yılında kullanılmıştır?");
        Console.WriteLine();
        Console.WriteLine("A) 1950");
        Console.WriteLine("B) 1948");
        Console.WriteLine("C) 1956");
        Console.WriteLine("D) 1958");
        Console.WriteLine();
        Console.WriteLine("Cevabınız: ");
        cevap=Console.ReadLine();

        if (cevap=="b" ||cevap=="B") 
        {
            soru=soru+1;
        }
        else
        {
            Console.WriteLine("Cevabınız Yanlış.Puanınız:20");
        }
    }
    if(soru == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Hamileliğin kaçıncı ayında bebeğin kalbi kan pompalamaya başlar?");
        Console.WriteLine();
        Console.WriteLine("A) 5");
        Console.WriteLine("B) 6");
        Console.WriteLine("C) 7");
        Console.WriteLine("D) 8");
        Console.WriteLine("Cevabınız:");
        cevap=Console.ReadLine();
        if(cevap=="b"||cevap=="B")
        {
            Console.WriteLine();
            Console.WriteLine("Tebrikler Bütün Soruları Doğru Cevapladınız.");

        }
        else 
        {
            Console.WriteLine("Cevabınız Yanlış.Puanınız:40");
        }

    }

}
