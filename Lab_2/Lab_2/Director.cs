namespace Lab_2
{
    public class Director
    {
        private IDesigner _dress;
        public IDesigner Designer
        {
            set { _dress = value; }
        }
        public void MakeCocktailDress()
        {
            this._dress.SetName("cocktail dress");
            this._dress.SetFabric("chiffon");
            this._dress.SetLength("midi");
        }
        public void MakeEveningDress()
        {
            this._dress.SetName("evening dress");
            this._dress.SetFabric("satin");
            this._dress.SetLength("maxi");
            this._dress.SetEmbroidery();
        }
    }
}
