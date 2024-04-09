namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulos triangulo = new Triangulos();

            Console.WriteLine("Verifivar o tipo de triangulo");
            Console.Write("Informe o primeiro Valor:");
            triangulo.x = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o primeiro Valor:");
            triangulo.y = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o primeiro Valor:");
            triangulo.z = Convert.ToDecimal(Console.ReadLine());

            if (triangulo.CalcularTriangulo() < triangulo.z) 
            {
                if (triangulo.x == triangulo.z && triangulo.y == triangulo.z && triangulo.x == triangulo.y) 
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (triangulo.x != triangulo.z && triangulo.y != triangulo.z && triangulo.x != triangulo.y)
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
                else Console.WriteLine("Triângulo Isósceles");

            }
            else Console.WriteLine("Triangulo invalido");



        }
    }
}
