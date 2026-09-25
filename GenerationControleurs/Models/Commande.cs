namespace LinqEtSeedEF.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;
        public List<CommandePlat> CommandesPlats { get; set; } = null!;
    }
}
