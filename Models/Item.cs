namespace HomeAutomation.Models
{
    public class Item
    {
        public int Id { get; private set; }
        public Budget? BudgetId { get; set; }
        public DateTime RegisterItem { get; set; }= DateTime.Now;
        public ICollection<Service>? Services { get; set; }
        public string? DescriptionService { get; set; }
        public Double PriceService { get; set; }    
    }
}