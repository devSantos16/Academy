using Poo.Class;

namespace Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person caio = new Person("Barbalho", "Caio", 19);

            caio.SetCpf(600000000);
            caio.Show();

            Console.WriteLine(caio.Cpf);
            Console.WriteLine(caio.Characteristics());
            Console.WriteLine(caio.NewCharacteristics());
        }
    }
}
