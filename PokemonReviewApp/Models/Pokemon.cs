﻿namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
