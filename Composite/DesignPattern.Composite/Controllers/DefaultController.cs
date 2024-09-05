using Microsoft.AspNetCore.Mvc;
using DesignPattern.Composite.DAL;
using DesignPattern.Composite.CompositePattern;
using Microsoft.EntityFrameworkCore;
namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var categories = _context.Categories.Include(x => x.Products).ToList();

            var values = Recursive(categories, new Category { CategoryName = "First Category", CategoryID = 0 }, new ProductComposite(0, "First Composite"));

            ViewBag.v = values;


            return View();
        }

        public ProductComposite Recursive(List<Category> categories,Category firstCategory,ProductComposite FirstComposite,ProductComposite leaf=null)
        {
            categories.Where(x => x.UpperCategoryID == firstCategory.CategoryID).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);

                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));
                });
                if (leaf!=null)
                {
                    leaf.Add(productComposite);

                }
                else
                {
                    FirstComposite.Add(productComposite);
                }

                Recursive(categories, y, FirstComposite, productComposite);
            });

            return FirstComposite;

        }
    }
}
