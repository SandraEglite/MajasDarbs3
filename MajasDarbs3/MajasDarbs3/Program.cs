

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

Car auto = new Car();

auto.Mark = "SAAB";
auto.LicensePlate = "AB1234";
auto.Speed = 120;
Console.WriteLine("Lūdzu ievadi sava auto marku, nummurzīmi un ātrumu");

string mark = auto.Mark;
string plate = auto.LicensePlate;
int speed = auto.Speed;

Console.WriteLine($"Lietotājs ievadīja marku {mark}, nummurzīmi {plate} un maksimālo ātrumu {speed}");

Console.WriteLine($"Parādi, ko Tavs auto prot!");

auto.Drive();
auto.SpeedUp();
auto.Stop();
auto.MakeSound();


Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

Console.WriteLine("3.uzdevums PRECE");


Console.WriteLine("Lūdzu ievadi izgatavojamās kastes garumu!");

string ievaditaisGarums = Console.ReadLine();
double A = double.Parse(ievaditaisGarums);

Console.WriteLine("Lūdzu ievadi izgatavojamās kastes platumu!");

string ievaditaisPlatums = Console.ReadLine();
double B = double.Parse(ievaditaisPlatums);

Console.WriteLine("Lūdzu ievadi izgatavojamās kastes augstumu!");

string ievaditaisAugstums = Console.ReadLine();
double C = double.Parse(ievaditaisAugstums);

Console.WriteLine($"Preces pasūtītājs ievadīja garumu {A}, platumu {B} un augstumu {C}");

Product box = new Product(A, B, C);


Console.WriteLine($"Ievadītie parameti atbilst izmēram {box.Size}");


box.Demonstration();

Console.WriteLine("Paldies par pasūtījumu!");

Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

Console.WriteLine("4.uzdevums PERSONA");


Console.WriteLine("Lūdzu ievadi savu vārdu");

