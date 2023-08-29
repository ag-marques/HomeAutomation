using HomeAutomation.Models;

namespace HomeAutomation.Models
{
    public class Budget
    {
        public int Id { get; set; }        
        public DateTime RegisterBudget { get; set; } = DateTime.Now;
        public Double SumPrice { get; set; }
        public int ClientId{ get; set; }
        public Client client{ get; set; }
    }
}