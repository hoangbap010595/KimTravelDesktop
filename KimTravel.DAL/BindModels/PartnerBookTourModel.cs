﻿using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.BindModels
{
    public class PartnerBookTourModel
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public string TourName { get; set; }
        public string Room { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<float> Pax { get; set; }
        public Nullable<int> Total { get; set; }
        public string SaleBook { get; set; }
        public string Note { get; set; }
    }
}
