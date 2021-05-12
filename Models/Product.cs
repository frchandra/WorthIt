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
        public int DisplaySize { get; set; }
        public string DisplayType { get; set; }
        public string OS { get; set; }
        public string CPU { get; set; }
        public int Benchmark { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public int MainCamera { get; set; }
        public int FrontCamera { get; set; }
        public string CameraFeature { get; set; }
        public int BatteryCapacity { get; set; }
        public double ChargingSpeed { get; set; }
        public bool AudioJack { get; set; }
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
