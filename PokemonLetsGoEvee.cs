namespace InheritanceIntro
{
    internal class PokemonLetsGoEvee : Game, IPhysical 
    {
        public PokemonLetsGoEvee()
        {
            this.Id = "3";
            this.GameName = "Pokemon";
            this.Price = 350;
        }
    }
}