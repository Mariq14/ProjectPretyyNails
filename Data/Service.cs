namespace PrettyNails.Data
{
    public enum TypeService { }
    public class Service
    {
        public int Id { get; set; }


        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public TypeService ServiceType { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
