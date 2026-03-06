// Cree un programa que pida un número al usuario y muestre su tabla de multiplicar del 1 al 10 utilizando do-while.

int num = 0;
int tabla = 1;

Console.WriteLine("Ingrese un número");
num = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{num} X {tabla} = {num * tabla}");
    tabla++;


} while (tabla <= 10);

