Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int number_0 = number * (-1);
    Console.Write(number_0);
    int count = number_0;

while (count < number)
{
  count = count + 1;
    Console.Write($" {count} ");
}
