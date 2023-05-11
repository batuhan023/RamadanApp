namespace WebApi.Models
{
    public class Dates
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public ICollection<Times> Times { get; set; }

    }
}
