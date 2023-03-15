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
