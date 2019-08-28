using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TGDD.Data.Entities
{
    [Table("AppRole")]
    public class AppRole : IdentityRole<Guid>
    {
        public AppRole() { }

        public AppRole(string name, string description) : base(name)
        {
            Description = description;
        }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
