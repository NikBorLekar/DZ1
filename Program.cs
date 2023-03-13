Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;
if(num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}
Console.WriteLine("Максимальное значение = " + max + ", а " + "Минимальное значение = " + min);