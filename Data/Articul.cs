namespace PrettyNails.Data
{
    public enum TypeType { }

    public class Articul
    {
        public int Id { get; set; }


        public string ArticulName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public TypeType Type { get; set; }


        public virtual ICollection<Order> Orders { get; set; }


    }
}
