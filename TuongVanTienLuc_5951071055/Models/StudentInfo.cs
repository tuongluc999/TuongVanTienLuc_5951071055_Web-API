﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TuongVanTienLuc_5951071055.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "HoTen")]
        public string hoTen { get; set; }
        [DataMember(Name = "MSV")]
        public string msv { get; set; }
        [DataMember(Name = "Lop")]
        public string lop { get; set; }

    }
}