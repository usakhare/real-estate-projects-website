﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Apollo.Models
{
    public enum status
    {
        waiting = 0,
        inProgress = 1,
        deliverd = 2,
        pending = 3
    }
    public class Project
    {
        public Project()
        {
            workers = new List<User>();
            comments = new List<Comments>();
            applied = new List<ApplyProject>();
            Requests = new List<Requests>();
        }
        public int ID { get; set; }
        public virtual User customer { get; set; }
        public virtual User projectManager { get; set; }
        public virtual User teamLeader { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public status status { get; set; }
        public Double? price { get; set; }
        public DateTime createDate { get; set; } = DateTime.Now;
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public virtual ICollection<User> workers { get; set; }
        public virtual ICollection<Comments> comments { get; set; }
        public virtual ICollection<ApplyProject> applied { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }

    }
}