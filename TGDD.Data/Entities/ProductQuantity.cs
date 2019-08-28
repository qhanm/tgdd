using System.ComponentModel.DataAnnotations.Schema;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("ProductQuantity")]
    public class ProductQuantity : DomainEntity<int>
    {

        [Column(Order = 2)]
        public int SizeId { get; set; }

        [Column(Order = 3)]
        public int ColorId { get; set; }

        [Column(Order = 1)]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }

        public virtual Color Color { get; set; }
    }
}