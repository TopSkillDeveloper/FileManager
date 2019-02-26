using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileManager.Models
{
    // пока не делал
    public class Permissions
    {
        public int permissionId { get; set; }
        public int parentUserId { get; set; }
        public int childUserId { get; set; }
        public int objectId { get; set; }
        public bool write { get; set; }
        public bool read { get; set; }
        public bool download { get; set; }
    }
} 
