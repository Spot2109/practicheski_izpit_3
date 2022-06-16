using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Book
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        public User LastTakenBy { get; set; }

        [Required]
        public Author Author { get; set; }

        private Book()
        { 
        }

        public Book(string id, string name, string genre)
        {
            ID = id;
            Name = name;
            Genre = genre;
        }
    }
}
