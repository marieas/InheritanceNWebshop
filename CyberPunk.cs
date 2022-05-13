namespace InheritanceIntro
{
    internal class CyberPunk : Game, IDownloadable, IPhysical
    {
        public CyberPunk()
        {
            this.Id = "2";
            this.GameName = "Cyberpunk";
            this.Price = 250;
        }
    }
}