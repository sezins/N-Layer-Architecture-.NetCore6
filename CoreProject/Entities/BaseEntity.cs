using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        //ılk seferde nullable olacak
        public DateTime? UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
