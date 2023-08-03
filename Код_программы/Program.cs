void EnterArray(string[] InputArray)
{
    Console.Write($"Изначальный массив: ");
    for (int i = 0; i < InputArray.Length; i++) Console.Write($"{InputArray[i]} ");
    Console.WriteLine();
}
void FindArray(string[] OutputArray)
{
    Console.Write($"Итоговый массив: ");
    string[] newarray = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)
    {
        if (OutputArray[i].Length <= 3)
        {
            newarray[i] = OutputArray[i];
            Console.Write($"{newarray[i]} ");
        }
    }
    Console.WriteLine();
}

