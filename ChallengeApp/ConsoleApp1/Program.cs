var name = "Ewa";
var sex = "Kobieta";
var age = 33;

if (sex == "Kobieta" && age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (sex == "Kobieta" && age < 30)
    Console.WriteLine("Kobieta poniżej 30 lat");
