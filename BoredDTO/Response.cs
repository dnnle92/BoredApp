using System;
using System.Collections.Generic;
using System.Text;

namespace BoredDTO
{
    public class Response
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public float Accessibility { get; set; }
        public EType Type { get; set; }
        public int Participants { get; set; }
        public float Price { get; set; }
    }
}
