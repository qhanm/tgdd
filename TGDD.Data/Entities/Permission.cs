using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Permission")]
    public class Permission : DomainEntity<int>
    {
        public Permission() { }

        public Permission(int id, Guid roleId, string functionId, bool canRead, bool canUpdate, bool canDelete, bool canCrete)
        {
            Id = id;
            RoleId = roleId;
            FunctionId = functionId;
            CanRead = canRead;
            CanCreate = canCrete;
            CanDelete = canDelete;
            CanUpdate = canUpdate;
        }

        [Required]
        public Guid RoleId { get; set; }

        public string FunctionId { get; set; }

        public bool CanRead { get; set; }

        public bool CanCreate { get; set; }

        public bool CanUpdate { get; set; }

        public bool CanDelete { get; set; }

        [ForeignKey("RoleId")]
        public virtual AppRole AppRole { get; set; }

        [ForeignKey("FunctionId")]
        public virtual Function Function { get; set; }
    }
}
