﻿using System.ComponentModel.DataAnnotations.Schema;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    [Table("BillDetail")]
    public class BillDetail : DomainEntity<int>
    {
        public BillDetail()
        {
        }

        public BillDetail(int billId, int productId, int quantity, decimal price, int colorId, int sizeId)
        {
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            ColorId = colorId;
            SizeId = sizeId;
        }

        public BillDetail(int id, int billId, int productId, int quantity, decimal price, int colorId, int sizeId)
        {
            Id = id;
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            ColorId = colorId;
            SizeId = sizeId;
        }

        public int BillId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int ColorId { get; set; }

        public int SizeId { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }

        [ForeignKey("CorlorId")]
        public virtual Color Color { get; set; }
    }
}