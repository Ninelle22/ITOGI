// Контрольная работа - Итоги блока

using static System.Console;
Clear();

string[] array1 = new string[3] {"123, "1234", "12345"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIf(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count ++;
        }
    }
}
void PrintArray(string[]) array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
SecondArrayWithIf(array1, array2);
PrintArray(array2);