using System;
using System.Collections.Generic;

namespace WorkersList.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Worker> Workers { get; set; }
    }
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public DateTime DateAdded { get; set; }
    }
}