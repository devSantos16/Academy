using Linq.Class;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product(1, "Coffee", 10),
                new Product(2, "GTA VI", 600),
                new Product(3, "Play 5", 3000),
                new Product(4, "Bodygroom", 400)
            };

            var dear = products.Where(x => x.Price >= 100).OrderBy(x => x.Price);
            var hasGTA = products.Any(x => x.Name.Contains("gta".ToUpper()));
            var names = products.Select(x => x.Name);
            var namesDear = dear.Select(x => x.Name);

            var group = products.GroupBy(x => x.Price >= 100 ? "Dear" : "Less");
            var example = products.GroupBy(x => x.Name); 

        }
    }
}
