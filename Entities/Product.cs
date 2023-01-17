using System.ComponentModel.DataAnnotations;

namespace ProductCatalogAPI.Entities
{
    public class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private ProductDepartment Department { get; set; }

        public Product(){}
    }
}
