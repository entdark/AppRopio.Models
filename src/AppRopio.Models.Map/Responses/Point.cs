﻿using System;
using AppRopio.Models.Base.Responses;

namespace AppRopio.Models.Map.Responses
{
    public class Point
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string WorkTime { get; set; }

        public string Distance { get; set; }

        public string Phone { get; set; }

        public string AdditionalInfo { get; set; }

        public Coordinates Coordinates { get; set; }
    }
}
