using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace WebApplication4.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Display(Name="ZA電話")]
        [Required(ErrorMessage ="阿呆嗎?")]
        [StringLength(20, ErrorMessage ="號呆嗎?")]
        public string Phone { get; set; }


        [Display(Name = "ZA名")]
        [Required(ErrorMessage = "NAME 阿呆嗎?")]
        [MinLength(10)]
        [MaxLength(10)]
        public string Name   { get; set; }


    }
}