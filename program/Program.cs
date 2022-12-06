Console.Write("Задайте длину массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

string [] CreateArray()
{
    string[] array = new string [lengthArray];
    for(int i = 0; i < lengthArray; i++)
    {
        Console.Write("Введите объект: ");
        array[i] = (Console.ReadLine());
    }
    return array;
}

string[] SortArray(string[] array)
{
    string[] newArray = new string [array.Length];
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            newArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newArray, count);

    return newArray;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write($"{array[i]}. ");
        else Console.Write($"{array[i]}, ");
    }
}

string[] array = new string [lengthArray];
array = CreateArray();
SortArray(array);
string[] productArray = new string [array.Length];
productArray = SortArray(array);
PrintArray(productArray);