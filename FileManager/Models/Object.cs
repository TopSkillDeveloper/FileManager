using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileManager.Models
{
    public class Object
    {
        // пока не делал
        public int objectId { get; set; } 
        public int userId { get; set; }
        public string fileName { get; set; }
        public bool type { get; set; }
        public int parentCatalog { get; set; }
        // здесь еще поле
    }
}
