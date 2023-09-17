namespace PokemonReviewApp.Models
{
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Owner> Owners { get; set; }
    }
}
