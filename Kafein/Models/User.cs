using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kafein.Models
{
    public class User
    {
        public int ID { get; set; }
        public string TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public string Fullname
        {
            get { return Name + " " + Surname; }
        }

        public ICollection<UserProduct> UserProducts { get; set; }
    }
}
