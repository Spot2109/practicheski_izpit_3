using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Author
    {
        [Key]
        public string ID { get; set; }
       
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string LName { get; set; }
       
        [Required]
        public string Born { get; set; }
        
        public string Died { get; set; }
       
        [Required]
        public string Genres { get; set; }

        private Author()
        {
        }

        public Author(string id,string name, string lname,string born,string died, string genres)
        {
            ID = id;
            Name = name;
            LName = lname;
            Born = born;
            Died = died;
            Genres = genres;
        }
    }
}
