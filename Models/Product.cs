using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorthIt.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Display(Name="Short Description")]
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        [Display(Name = "Display Size")]
        public int DisplaySize { get; set; }
        [Display(Name = "Display Type")]
        public string DisplayType { get; set; }
        public string OS { get; set; }
        public string CPU { get; set; }
        public int Benchmark { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        [Display(Name = "Main Camera")]
        public int MainCamera { get; set; }
        [Display(Name = "Front Camera")]
        public int FrontCamera { get; set; }
        [Display(Name = "Camera Feature")]
        public string CameraFeature { get; set; }
        [Display(Name = "Battery Capacity")]
        public int BatteryCapacity { get; set; }
        [Display(Name = "Charging Speed")]
        public double ChargingSpeed { get; set; }
        [Display(Name = "Audio Jack")]
        public bool AudioJack { get; set; }
        [Display(Name = "Wireless Charging")]
        public bool WirelesCharging { get; set; }

        [Range(1, int.MaxValue)]
        public double Price { get; set; }
        public string Image { get; set; }
        [Display(Name ="Category Type")] 
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
}
