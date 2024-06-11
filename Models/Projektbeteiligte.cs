using System.ComponentModel.DataAnnotations;

namespace abs38.Models
{
    public class Projektbeteiligte
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string? Vorname { get; set; }
        public string? Nachname { get; set; }
        public string? Email { get; set; }
        public string? Firma { get; set; }
        public string? Straße { get; set; }
        public string? Hausnummer { get; set; }
        public string? PLZ { get; set; }
        public string? Ort { get; set; }
        public string? Bemerkung { get; set; }
        public string? Anmerkung { get; set; }
        public string? Telefon { get; set; }
        public DateTime? Geburtstag  { get; set; }
    }
}
