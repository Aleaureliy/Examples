double Factiorial (int number)
{
    if(number == 1) return 1;
    else return number * Factiorial(number - 1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factiorial(i)}");
}