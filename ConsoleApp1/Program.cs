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
            Console.WriteLine("Cevabınız Doğru");
        }
        else 
        {
            Console.WriteLine("Cevabınız Yanlış");
        }
    }

}
