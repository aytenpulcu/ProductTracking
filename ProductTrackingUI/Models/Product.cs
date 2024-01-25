using System.Diagnostics.CodeAnalysis;

namespace ProductTrackingUI.Models
{
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public int stock { get; set; }
        public Category category { get; set; }
    }
}
