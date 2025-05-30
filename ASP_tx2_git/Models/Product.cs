namespace ASP_tx2_git.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Bạn phải nhập mã sản phẩm")]
        [DisplayName("Mã sản phẩm: ")]
        public int ProductID { get; set; }

        [Required (ErrorMessage ="Bạn phải nhập tên sản phẩm")]
        [DisplayName ("Tên sản phẩm: ")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        //[Required(ErrorMessage = "Bạn phải nhập mô tả: ")]
        [DisplayName("Mô tả: ")]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        [Required(ErrorMessage = "Bạn phải nhập giá nhập")]
        [DisplayName("Giá nhập: ")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "numeric")]
        [Required(ErrorMessage = "Bạn phải nhập giá bán")]
        [DisplayName("Giá bán: ")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập số lượng")]
        [DisplayName("Số lượng: ")]
        public int Quantity { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Bạn phải nhập loại nho")]
        [DisplayName("Loại nho")]
        public string Vintage { get; set; }


        [Required(ErrorMessage = "Bạn phải nhập mã thể loại")]
        [DisplayName("Mã thể loại: ")]
        [StringLength(10)]
        public string CatalogyID { get; set; }


        [Column(TypeName = "text")]
        [DisplayName("Hình ảnh: ")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập khu vực")]
        [DisplayName("Khu vực: ")]
        [StringLength(100)]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
