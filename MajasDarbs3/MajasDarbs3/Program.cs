

using MajasDarbs3;
Phone telefons = new Phone();


telefons.Model = "Lielupe";
telefons.Mark = 111;
telefons.Size = 12;

string telefonsModel = telefons.Model;
int telefonsMark = telefons.Mark;   
int telefonsSize = telefons.Size;

Console.WriteLine("1.uzdevums TELEFONS");


Console.WriteLine("Lūdzu ievadi sava telefona modeli");

Console.WriteLine($"Lietotājs ievadīja modeli {telefonsModel}, marku {telefonsMark} un izmēru {telefonsSize}");

Console.WriteLine($"Parādi, ko tavs telefons {telefonsModel} prot?");

telefons.Call();
telefons.SendSMS();


Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

Console.WriteLine("2.uzdevums MAŠĪNA");

