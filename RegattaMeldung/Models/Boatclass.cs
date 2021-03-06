﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegattaMeldung.Models
{
    public class Boatclass
    {
        [Key]
        [Display(Name = "Bootsklasse")]
        public int BoatclassId { get; set; }
        [Display(Name = "Bootsklasse")]
        public string Name { get; set; }
        [Display(Name = "Sitze")]
        public int Seats { get; set; }
        public List<Competition> Competitions { get; set; }
    }
}
