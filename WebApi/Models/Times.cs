namespace WebApi.Models
{
    public class Times
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int DateId { get; set; }
        public string Sabah { get; set; }
        public string Ogle { get; set; }
        public string Ikindi { get; set; }
        public string Aksam { get; set; }
        public string Yatsı { get; set; }

        public Cities Cities { get; set; }
        public Dates Dates { get; set; }

    }
}
