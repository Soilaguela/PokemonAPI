namespace PokemonAPI.Models
{
    public class PokemonOwner
    {
      public int Pokemonld {  get; set; }
      public int Ownerld { get; set; }
      public Pokemon? Pokemon { get; set; }
      public Owner? Owner { get; set; }
    }
}
