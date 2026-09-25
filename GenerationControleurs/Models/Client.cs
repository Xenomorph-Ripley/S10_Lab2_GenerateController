using Microsoft.AspNetCore.Mvc.Rendering;

namespace LinqEtSeedEF.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public List<Commande> Commandes { get; set; } = null!;
    }
}
