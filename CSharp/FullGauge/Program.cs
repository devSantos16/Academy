namespace FullGauge
{
    public class Person
    {
        public string Name;
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
            {
                new Person { Name = "Rodrigo", Age = 29 },
                new Person { Name = "Felipe", Age = 31 },
                new Person { Name = "Guilherme", Age = 29 },
                new Person { Name = "Cleber", Age = 33 },
                new Person { Name = "Maurício", Age = 28 }
            };

            var result = persons.Where(person => person.Age >= 30).FirstOrDefault();

            if (result != null) 
            { 
                Console.WriteLine(result.Name);            
            }
        }
    }
}
