namespace AppiSimo.Client.Model
{
    public class Light : Entity
    {
        public string LightType { get; set; }
        public decimal Price { get; set; }
        public bool Enabled { get; set; }
    }
}