﻿using Moslah.Models.OwnModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Moslah.Models
{
    public class Description
    {
        public Description()
        {
            Deleted = false;
            Date = DateTime.Now;
        }
        [Key]
        public int ID { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string StatusRoad { get; set; }
        public bool Deleted { get; set; }
        public DateTime Date { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        [ForeignKey("City")]
        public int cityID { get; set; }
        public virtual City City { get; set; }

    }
}