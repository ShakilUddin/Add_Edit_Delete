using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Add_Edit_Delete
{
    class MyDetails
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(15)]
        public string Fname { get; set; }
        [Required, MaxLength(15)]
        public string Lname { get; set; }
        public int Age { get; set; }
    }
}
