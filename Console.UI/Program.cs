using System.Diagnostics;

string s;

do
{
    Console.WriteLine("---> Codility_   ");
    s = Console.ReadLine();

    if (!String.IsNullOrWhiteSpace(s))
    {
        appMenu(s.Trim());
    }

} while (true); //Space & Enter Kill the process.

static void appMenu(string codilityId)
{
    Codility codility = new();

    switch (codilityId)
    {
        case "5":
            codility.MinAvgTwoSlices();
            break;
        default:
            Console.WriteLine("There is no solution for the problem # {0} yet. Please try it later. Thanks! \n", codilityId);
            break;
    }
}

Process.GetCurrentProcess().Kill();
