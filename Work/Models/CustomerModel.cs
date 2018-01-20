using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Work.Models
{
    public enum category{
        plumber,
        Carpenter,
        Cleaner
    }
    public class CustomerModel
    {
        
        
    }
    public class WorkerModel
    {
        [Key]
        public int Id { get; set; }
        public string WorkerCategory { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string HeadLine { get; set; }
        
    }
}