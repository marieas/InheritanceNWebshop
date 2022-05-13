namespace InheritanceIntro
{
    internal class BattleField : Game, IDownloadable 
    {
        public BattleField()
        {
            this.Id = "1";
            this.GameName = "Battlefield";
            this.Price = 650;
        }
    }
}