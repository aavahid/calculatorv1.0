using System;

Console.WriteLine("Calculator v1.0'a xos gelmisiniz");
bool isContinue = true;

while (isContinue == true)
{
    Console.WriteLine(" ");
    Console.WriteLine("1. Toplama");
    Console.WriteLine("2. Cixma");
    Console.WriteLine("3. Vurma");
    Console.WriteLine("4. Bolme");
    Console.WriteLine("5. Proqramdan cix");
    Console.WriteLine(" ");
    Console.Write("Seciminizi edin: ");

    string command = Console.ReadLine();

    switch (command)
    {
        case "1":
            Console.Write("1. ededi daxil edin: ");
            int toplanan1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int toplanan2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Netice: " +toplanan1+ " + " +toplanan2+ " = " +(toplanan1 + toplanan2));
            break;
        case "2":
            Console.Write("1. ededi daxil edin: ");
            int azalan = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int cixilan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("Netice: " +azalan+ " - " +cixilan+ " = " +(azalan - cixilan));
            break;
        case "3":
            Console.Write("1. ededi daxil edin: ");
            int vuruq1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int vuruq2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("Netice: " +vuruq1+ " * " +vuruq2+ " = " +(vuruq1 * vuruq2));
     
            break;
        case "4":
            Console.Write("1. ededi daxil edin: " );
            int bolunen = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ededi daxil edin: ");
            int bolen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("Netice: " +bolunen+ " / " +bolen+ " = " +(bolunen / bolen));
            break;
        case "5":
            Console.WriteLine("Sagolun. Proqramdan cixis edilir");
            isContinue = false;
            break;
        default:
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Sehv secim etdiniz bir daha secim edin");
            break;
    }
}