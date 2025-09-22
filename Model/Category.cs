using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_task1.Model
{
    class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Name { get; set; }


    }
}
