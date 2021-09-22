using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009_Collections_WeiterStukturen
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }


        public Movie(int id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public (string, string, decimal) GetTitleDescitpionAndPrice()
        {
            return (this.Title,this.Description,  this.Price); 
        }

        public (string titel, string beschreibung) GetTitelAndBeschreibung()
        {
            return (this.Title, this.Description);
        }


        public void Deconstruct(out int id, out string title, out string description, out decimal price)
        {
            id = this.Id;
            title = this.Title;
            description = this.Description;
            price = this.Price;
        }
    }
}
