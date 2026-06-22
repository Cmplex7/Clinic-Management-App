using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tblPatients")]
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(10)]
        public string Gender { get; set; } // Nam/Nữ

        [StringLength(20)]
        public string Phone { get; set; }

        public int BirthYear { get; set; } 

        [StringLength(200)]
        public string Address { get; set; }

        public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}