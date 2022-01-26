H1.Codes.H1 H1 = new H1.Codes.H1();

int selectedMenu;
string? input;
Dato.dageTilbage();
Console.WriteLine("Tryk enter.");
Console.ReadLine();
while (true)
{
    selectedMenu = Menu.ShowMenu();
    if (selectedMenu == 1)
    {
        Console.WriteLine("Indtast Fag");
        input = Console.ReadLine();
        Console.WriteLine(string.Join(" ", H1.Search(input, SearchCriteria.Fag)));
        Console.WriteLine("Tryk enter for at vende tilbage");
        Console.ReadLine();
    }
    else if (selectedMenu == 2)
    {
        Console.WriteLine("Indtast lærer");
        input = Console.ReadLine();
        Console.WriteLine(string.Join(" ", H1.Search(input, SearchCriteria.Laere)));
        Console.WriteLine("Tryk enter for at vende tilbage");
        Console.ReadLine();
    }
    else if (selectedMenu == 3)
    {
        Console.WriteLine("Indtast elevs navn eller efternavn");
        input = Console.ReadLine();
        Console.WriteLine(string.Join(" ", H1.Search(input, SearchCriteria.Elev)));
        Console.WriteLine("Tryk enter for at vende tilbage");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Fortsat god dag");
        break;
    }
}