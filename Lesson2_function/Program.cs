int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}


int num1 = 15;
int num2 = 16;
int num3 = 84;
int num4 = 54;
int num5 = 65;
int num6 = 25;
int num7 = 95;
int num8 = 35;
int num9 = 33;

//int max1 = Max(num1,num2,num3);
//int max2 = Max(num4,num5,num6);
//int max3 = Max(num7,num8,num9);
//int max4 = Max(max1,max2,max3);

int max4 = Max(
    Max(num1,num2,num3),
    Max(num4,num5,num6),
    Max(num7,num8,num9));

Console.WriteLine("Максимальное число " +max4);
