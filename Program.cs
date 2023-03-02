//Vanessa Spiegl

System.Console.Write("Level? 0 or 1:");
int region = int.Parse(Console.ReadLine()!);
switch (region)
{
    case 0: DoLevel0(); break;
    case 1: DoLevel1(); break;
    case 2: DoLevel2(); break;
}


#region Level0
void DoLevel0()
{
    int east = 0, west = 0, south = 0, north = 0;
    char eastSymbol = '>', westSymbol = '<', northSymbol = '^', southSymbol = 'V';

    string roverMovement = string.Empty;

    do
    {
        System.Console.Write("Enter movement logs using ^, >, V, <: ");
        roverMovement = Console.ReadLine()!;
    } while (!roverMovement.Contains('<') && !roverMovement.Contains('>') && !roverMovement.Contains('^') && !roverMovement.Contains('V'));

    int CountMovementLogs(int count, int rover, string roverMovement)
    {
        return count = roverMovement.Count(t => t == rover);
    }

    east = CountMovementLogs(east, eastSymbol, roverMovement);
    west = CountMovementLogs(west, westSymbol, roverMovement);
    north = CountMovementLogs(north, northSymbol, roverMovement);
    south = CountMovementLogs(south, southSymbol, roverMovement);

    west = west - east;
    north = north - south;

    System.Console.Write("The rover is ");
    if (north == 0 && west == 0)
    {
        System.Console.Write("in the base station");
    }
    else
    {
        if (north > 0)
        {
            System.Console.Write($"{north}m north, ");
        }
        if (north < 0)
        {
            north *= -1;
            System.Console.Write($"{north}m south, ");
        }

        if (west > 0)
        {
            System.Console.Write($"and {west}m west.");
        }
        if (west < 0)
        {
            west *= -1;
            System.Console.Write($"and {west}m east.");
        }
    }
}
#endregion

#region Level1
void DoLevel1()
{
    int east = 0, west = 0, south = 0, north = 0;
    char eastSymbol = '>', westSymbol = '<', northSymbol = '^', southSymbol = 'V';

    string roverMovement = string.Empty;
    double linearDistance;
    int manhattanDistance;

    do
    {
        System.Console.Write("Enter movement logs using ^, >, V, <: ");
        roverMovement = Console.ReadLine()!;
    } while (!roverMovement.Contains('<') && !roverMovement.Contains('>') && !roverMovement.Contains('^') && !roverMovement.Contains('V'));

    int CountMovementLogs(int count, int rover, string roverMovement)
    {
        return count = roverMovement.Count(t => t == rover);
    }

    east = CountMovementLogs(east, eastSymbol, roverMovement);
    west = CountMovementLogs(west, westSymbol, roverMovement);
    north = CountMovementLogs(north, northSymbol, roverMovement);
    south = CountMovementLogs(south, southSymbol, roverMovement);

    west = west - east;
    north = north - south;

    linearDistance = Math.Round(Math.Sqrt(north * north + west * west), 2);
    if (linearDistance < 0) { linearDistance *= -1; }
    System.Console.Write($"Linear distance = {linearDistance}m, ");

    manhattanDistance = west + north;
    if (manhattanDistance < 0) { manhattanDistance *= -1; }
    System.Console.WriteLine($"Manhattan distance = {manhattanDistance}m");
}
#endregion

#region Level2
void DoLevel2() 
{

}
#endregion