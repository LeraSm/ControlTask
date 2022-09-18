// Console.WriteLine("Hello, World!");

string[] Array1 = new string[6] {"Lera", "24", "hello", "world", ":*", "like"};
string[] Array2 = new string[Array1.Length];
void NewArray(string[] Array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        Array2[count] = Array1[i];
        count++;
        }
    }
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
NewArray(Array1, Array2);
PrintArray(Array2);