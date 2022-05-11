// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Este programa calcula el area de un rectangulo");
Console.WriteLine("Ingrese el valor de la base");
double baseRec = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la altura");
double alturaRec = double.Parse(Console.ReadLine());
double areaRec = baseRec * alturaRec;
Console.WriteLine("El area del rectangulo es: " + areaRec);
bool esMayorADiez = areaRec > 10;

if (esMayorADiez)
{
    Console.WriteLine("El area del rectangulo es mayor a 10");
}

Console.ReadLine();
