using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tblMedicalRecords")]
    public class MedicalRecord
    {
        [Key]
        public int RecordID { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public int PatientID { get; set; }
        [ForeignKey("PatientID")]
        public virtual Patient Patient { get; set; }

        public int DoctorID { get; set; }
        [ForeignKey("DoctorID")]
        public virtual User Doctor { get; set; }

        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Waiting";

        public decimal TotalAmount { get; set; }

        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }

        public virtual ICollection<RecordService> RecordServices { get; set; }
    }
}