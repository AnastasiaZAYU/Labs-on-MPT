namespace Lab_2
{
     public class DressDesigner : IDesigner
    {
        private Dress _dress = new Dress();
        public DressDesigner()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._dress = new Dress();
        }
        public void SetName(string name)
        {
            this._dress.Add("type - " + name);
        }
        public void SetFabric(string fabric)
        {
            this._dress.Add("fabric - " + fabric);
        }
        public void SetLength(string length)
        {
            this._dress.Add("length - " + length);
        }
        public void SetEmbroidery()
        {
           this._dress.Add("with embroidery");
        }
        public Dress GetDress()
        {
            Dress result = this._dress;
            this.Reset();
            return result;
        }
    }
}
