using HomeAutomation.Models;

namespace HomeAutomation.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public ICollection<Client>? Clients{ get; set; }
        public DateTime RegisterBudget { get; set; } = DateTime.Now;
        public Double SumPrice { get; set; }
    }
}