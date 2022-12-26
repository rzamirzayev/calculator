using calculator;
hesab H= new hesab();


Console.WriteLine("Ilkin ededinizi daxil edin:");
H.num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ikinci ededinizi daxil edin:");
H.num2= Convert.ToInt32(Console.ReadLine());


do
{
    Console.WriteLine("Hansi emeli edessiz? \n 1.Toplama:+ \n 2.Cixma:- \n 3.Vurma:* \n 4.Bolme:/ \n 5.Cixis elemek ucun STOP yazin ");
    H.secim = Console.ReadLine();
    H.Calculate();
} while (H.secim!="STOP");
