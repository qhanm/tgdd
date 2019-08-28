using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;

namespace TGDD.Data.Entities
{
    [Table("AppUser")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwichable
    {
        public AppUser() { }

        public AppUser(Guid id, string fullName, string userName, string email,string phoneNumber, DateTime birthDay, decimal balance, string avatar, Status status)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDay = birthDay;
            Avatar = avatar;
            Balance = balance;
            Status = status;
        }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public DateTime? BirthDay { get; set; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
    }
}
