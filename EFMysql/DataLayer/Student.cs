using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MySql.Data.Entity;

namespace EFMysql.DataLayer
{
    //[Table("StudentMaster", Schema="Admin")]
    public class Student
    {
        public Student()
        {         
        }

       // [Key, DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
//        [Column(Order=1)]
        public int StudentID { get; set; }        

        [StringLength(50)]
        public string StudentName { get; set; }

        //[Index]
        public DateTime DateOfBirth { get; set; }
        public byte[]  Photo { get; set; }

        //[Index("INDEX_Height", IsUnique=true)]
        public decimal Height { get; set; }
        public float Weight { get; set; }

        //[Timestamp]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime RowVersion { get; set; }
        [ConcurrencyCheck]
        //[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedUtc { get; set; }

        //[NotMapped]
        public int Age { get; set; }

        // Foreign key for standard
        //[ForeignKey("CurrentStandard")]
        public int CurrentStandardId { get; set; }

        //[ForeignKey("PreviousStandard")]
        //public int PreviousStandardId { get; set; }

        [ForeignKey("CurrentStandardId")]
        public virtual Standard CurrentStandard { get; set; }

        //[ForeignKey("PreviousStandardId")]
        //public Standard PreviousStandard { get; set; }
    }
}
