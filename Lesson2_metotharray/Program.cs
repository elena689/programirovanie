//ищем первый индекс для заданного числа массива
int [] array = {1,2,33,27,94,55,66,27,8};

int n = array.Length;
int find = 27;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; //index=index+1
}
