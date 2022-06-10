using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Data.Entities
{
    [Table("Lop")]
    public class Lop
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }
}
