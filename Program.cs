using EF_task1.Data;
using EF_task1.Model;

namespace EF_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var product1 = new Product() {
                Name = "laptop",
                Price = 10000,
                Rate = 3,
                Description = "lonovo"

            };


            var cat1 = new Category()
            { Name = "electronecs" 
            
            };


            context.products.Add(product1);
            context.categories.Add(cat1);
            context.SaveChanges();


        }
    }
}
