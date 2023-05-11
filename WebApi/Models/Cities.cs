namespace WebApi.Models
{
    public class Cities
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public ICollection<Times> Times { get; set; }

    }
}
