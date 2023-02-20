namespace PrettyNails.Data
{
    public class Order
    {
        public int Id { get; set; }


        public int ArticulId { get; set; }
        public virtual Articul Articuls { get; set; }


        public string UserId { get; set; }
        public virtual User Users { get; set; }


        public DateTime OrderedOn { get; set; }

    }
}
