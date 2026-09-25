using Microsoft.AspNetCore.Mvc.Rendering;

namespace LinqEtSeedEF.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public List<Commande> Commandes { get; set; } = null!;
        public List<Plat> Plats { get; set; } = null!;
    }
}
