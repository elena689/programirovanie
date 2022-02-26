int FFS = 1;
int SFS = 2;
int dogSpeed = 5;
int distance = 10000;
int time = 0;
int friend = 2;
//Console.SetCursorPosition(xb, yb);
//Console.WriteLine("+");

int count = 0;

while(distance > 10)
{
        if(friend == 1)
    {
        time = distance/(FFS + dogSpeed);
        friend = 2;
    }
        else
    {
        time = distance/(SFS + dogSpeed);
        friend = 1;
    }
    
    distance = distance + (FFS + SFS) * time;
    count = count + 1;
}
Console.WriteLine("Собака пробежит " +count+ " раз(а)");