Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 2;

if(num > 1)
{
    while(num1 <= num)
    {
        Console.Write(num1 + " ");
        num1 = num1 + 2;
    }
}