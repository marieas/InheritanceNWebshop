namespace InheritanceIntro
{
    internal class PUBG : Game, IDownloadable, IPhysical
    {
        
        public PUBG()
        {
            this.GameName = "PUBG";
            this.Id = "4";
            this.Price = 100;
        }
    }
}