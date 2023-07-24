namespace HomeAutomation.Models
{
    public class Client
    {
        public int Id { get; set;}
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Whatsapp { get; set; }
        public DateTime  Register { get; set; }  = DateTime.Now;
    }
}