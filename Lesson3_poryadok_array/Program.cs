// упорядочение массива

int [] array = {1,5,4,8,3,2,2,4,5};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

void Sort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int min = i;
        
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j]<array[min]) min = j;
        }
        
        int temporary = array [i];
        array [i] = array[min];
        array[min]=temporary;
    }

}
PrintArray(array);
Sort(array);

PrintArray(array);
