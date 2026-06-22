using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tblPrescriptionDetails")]
    public class PrescriptionDetail
    {
        [Key]
        public int DetailID { get; set; } 

        public int RecordID { get; set; }
        [ForeignKey("RecordID")]
        public virtual MedicalRecord MedicalRecord { get; set; }

        public int MedicineID { get; set; }
        [ForeignKey("MedicineID")]
        public virtual Medicine Medicine { get; set; }

        public int Quantity { get; set; }     

        [StringLength(200)]
        public string Usage { get; set; }   

        public decimal UnitPrice { get; set; } 
    }
}