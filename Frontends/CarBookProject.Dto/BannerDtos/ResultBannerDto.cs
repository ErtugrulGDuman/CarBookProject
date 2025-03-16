﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.BannerDtos
{
    public class ResultBannerDto
    {
        public int BannerID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string videoDescription { get; set; }
        public string videoUrl { get; set; }
    }
}
