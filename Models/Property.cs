using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealtorApp.Models
{
    public class Property
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        [Display(Name = "Year Built")]
        public int YearBuilt { get; set; }
        [Display(Name = "Property Type")]
        public string PropertyType { get; set; }
        [Display(Name = "Square Feet")]
        public int SquareFeet { get; set; }
        public int Bedrooms { get; set; }
        public double Bathrooms { get; set; }
        [Display(Name = "Garage Capacity")]
        public double GarageCapacity { get; set; }
        [Display(Name = "Relator Name")]
        public string RelatorName { get; set; }
        [Display(Name = "Relator Phone")]
        public string RelatorPhone { get; set; }
        [Display(Name = "Relator Email")]
        public string RelatorEmail { get; set; }
    }
}