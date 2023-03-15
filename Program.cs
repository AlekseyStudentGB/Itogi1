int GetLenthNewMass(string[] mass)
{
    int lenNewMass = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            lenNewMass += 1;
        }
    }
    return lenNewMass;
}

void NewMass(string[] mass, string[] newMass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            newMass[i] = mass [i];
        }
    }
}

void PrintMass (string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i < mass.Length - 1)Console.Write($"{mass[i]}, ");
        else Console.Write(mass[i]);
    }
}
Console.WriteLine("Введите текст который будет преобразован в массив");
string[] mass =  Console.ReadLine().Split(" ");
string[] newMass = new string [GetLenthNewMass(mass)];
NewMass( mass, newMass);
PrintMass (newMass);
