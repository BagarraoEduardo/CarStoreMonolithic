// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CarStore.Models
{
    public partial class CarType
    {
        public CarType()
        {
            Car = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}