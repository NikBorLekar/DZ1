Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Div = num % 2;

if(Div == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}