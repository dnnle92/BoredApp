using System;
using System.Collections.Generic;
using System.Text;
using BoredApi.Data;

namespace BoredApi.Models
{
    public class Response : IEntity
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public float Accessibility { get; set; }
        public string Type { get; set; }
        public int Participants { get; set; }
        public string Price { get; set; }
      }
}
