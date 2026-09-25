namespace LinqEtSeedEF.Models
{
    public class Plat
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Prix { get; set; }
        public int? NiveauPiquant { get; set; }
        public int RestaurantId { get; set; }
        public bool Vegetarien {  get; set; }
        public Restaurant Restaurant { get; set; } = null!;
        public List<CommandePlat> CommandesPlats { get; set; } = null!;
    }
}
