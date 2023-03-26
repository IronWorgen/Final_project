void printArray(String[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write($"\"{array[i]}\"");
            break;
        }
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write("]");
}

String[] GetItemsWithLength3(String[] array)
{
    int counter = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            (array[counter], array[i]) = (array[i], array[counter]);
            counter++;
        }
    }

    String[] resultArray = new String[counter];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = array[i];
    }
    return resultArray;
}

String[] array = { "hello", "2", "world", ":-)" };
printArray(GetItemsWithLength3(array));

