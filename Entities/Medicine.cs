using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tblMedicines")]
    public class Medicine
    {
        [Key]
        public int MedicineID { get; set; }

        [Required]
        [StringLength(100)]
        public string MedicineName { get; set; }

        public string Unit { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int StockQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public int CategoryID { get; set; }
        public virtual MedicineCategory Category { get; set; }

        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
    }
}
