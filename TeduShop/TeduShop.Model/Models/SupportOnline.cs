﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Department { set; get; }

        [MaxLength(50)]
        public string Skype { set; get; }

        [MaxLength(50)]
        public string Mobile { set; get; }

        [MaxLength(50)]
        public string Email { set; get; }

        [MaxLength(50)]
        public string Yahoo { set; get; }

        [MaxLength(50)]
        public string Facebook { set; get; }   

        public int? DisplayOrder { set; get; }
    }
}