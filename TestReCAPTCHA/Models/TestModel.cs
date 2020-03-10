﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestReCAPTCHA.Models
{
    public class TestModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [StringLength(4)]
        public string CaptchaCode { get; set; }
    }
}
