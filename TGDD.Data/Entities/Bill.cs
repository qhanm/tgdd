using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TGDD.Data.Enum;
using TGDD.Data.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("Bill")]
    public class Bill : DomainEntity<int>, ISwichable, IDateTracking
    {
        public Bill() { }

        public Bill(string customerName, string customerAddress, string customerMessage, string customerMobile, PaymentMethod paymentMethod, BillStatus billStatus, Status status, Guid? customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            PaymentMethod = paymentMethod;
            BillStatus = billStatus;
            Status = status;
            CustomerId = customerId;
        }

        public Bill(int id, string customerName, string customerAddress, string customerMessage, string customerMobile, PaymentMethod paymentMethod, BillStatus billStatus, Status status, Guid? customerId)
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerAddress;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            PaymentMethod = paymentMethod;
            BillStatus = billStatus;
            Status = status;
            CustomerId = customerId;
        }

        [Required]
        [StringLength(255)]
        public string CustomerName { set; get; }

        [Required]
        [StringLength(255)]
        public string CustomerAddress { set; get; }

        public string CustomerMessage { set; get; }

        [Required]
        [StringLength(15)]
        public string CustomerMobile { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public BillStatus BillStatus { set; get; }

        public Guid? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual AppUser AppUser { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }

        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }

        [DefaultValue(Status.Active)]
        public Status Status { set; get; }
    }
}
