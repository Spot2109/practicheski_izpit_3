﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LName { get; set; }

        public string DateExpire { get; set; }

        private User()
        {
        }
        public User(string name, string lname, string dateexpire)
        {
            Name = name;
            LName = lname;
            DateExpire = dateexpire;
            ID = Guid.NewGuid().ToString();
        }
        public User(string id, string name, string lname, string dateexpire)
        {
            ID = id;
            Name = name;
            LName = lname;
            DateExpire = dateexpire;
        }
        public override string ToString()
        {
            return "ID: " + ID + " Name: " + Name + " LName: " + LName + " Date Expire: " + DateExpire;
        }
    }
}
