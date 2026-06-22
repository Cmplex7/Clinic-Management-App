using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tblRecordService")]
    public class RecordService
    {
        [Key]
        public int RecordServiceID { get; set; }

        public int RecordID { get; set; }
        [ForeignKey("RecordID")]
        public virtual MedicalRecord MedicalRecord { get; set; }

        public int ServiceID { get; set; }
        [ForeignKey("ServiceID")]
        public virtual Service Service { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal Price { get; set; }
    }
}
