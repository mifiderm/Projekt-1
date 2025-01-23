namespace IznjamljivanjeAutomobila.Models
{
    public class Automobil
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public decimal CijenaPoDanu { get; set; }
        public bool Dostupan { get; set; }
    }
}
