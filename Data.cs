﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesModels
{
    public class Data
    {
        public string UserId { get; set; }
        public string SessionId { get; set; }
        public string Input { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Service Service { get; set; }
        public int Likes { get; set; }
        public string XPing { get; set; }
        public string HiddenUrl { get; set; }
        public string ImageId { get; set; }
        public Stream ImageStream { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy, hh.mm tt}")]
        [DataType(DataType.Date)]
        public DateTime Time { get; set; }

    }
}
