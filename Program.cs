Console.WriteLine("Введите массив из строк разделяя , : ");
string[] array = Console.ReadLine()!.Split(",");

ShowStringArray(array);

string[] result = GetElementsLowerThree(array);

ShowStringArray(result);

string[] GetElementsLowerThree(string[] arr)
{
    string tmp = string.Empty;
    for(int i = 0; i< array.Length;i++)
    {
        if(array[i].Length <= 3)
        {
            tmp += array[i] + " ";
        }
    }
    tmp = tmp.TrimEnd();
    string[] res = tmp.Split(" ");

    return res;
}

void ShowStringArray(string[] arr)
{
    Console.WriteLine($"[{String.Join(", ",arr)}]");
}
