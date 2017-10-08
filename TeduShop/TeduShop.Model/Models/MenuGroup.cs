﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class MenuGroup
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}