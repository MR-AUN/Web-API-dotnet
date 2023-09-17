namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemonter { get; set; }
    }
}
