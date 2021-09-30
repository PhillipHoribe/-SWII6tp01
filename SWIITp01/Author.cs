using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWIITp01
{
    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author(string _name, string _email, char _gender)
        {
            this.Name = _name;
            this.Email = _email;
            this.Gender = _gender;
        }
        public Author()
        {
            Email = "example@example";
            Gender = 'm';
        }
    }
}
