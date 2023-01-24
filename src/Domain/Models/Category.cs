namespace dws_ex_1.src.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
