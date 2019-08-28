using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Contact")]
    public class Contact : DomainEntity<int>, ISwichable
    {
        public Contact() { }

        public Contact(int id, string name, string email, string phone, string website, string address, string order, double? lat, double? lng, Status status)
        {
            Id = id;
            Name = Name;
            Email = email;
            Phone = phone;
            Website = website;
            Address = address;
            Order = order;
            Lat = lat;
            Lng = lng;
            Status = status;

        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        public string Website { get; set; }

        public string Address { get; set; }

        public string Order { get; set; }

        public double? Lat { get; set; }
        public Status Status { get; set; }

        public double? Lng { get; set; }
}
}
