using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFMysql.DataLayer
{
    public class Standard
    {
        public Standard()
        {

        }

        [Key]
        public int StandardId { get; set; }

        [StringLength(50)]
        public string StandardName { get; set; }

       // [InverseProperty("CurrentStandard")]
        //public virtual IList<Student> CurrentStudents { get; set; }

        //[InverseProperty("PreviousStandard")]
        public virtual IList<Student> PreviousStudents { get; set; }
    }
}
