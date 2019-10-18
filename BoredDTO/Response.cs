using System;
using System.Collections.Generic;
using System.Text;

namespace BoredDTO
{
    class Response
    {
        public string Activity { get; set; }
        public double Accessibility { get; set; }
        public EType Type { get; set; }
        public int Participants { get; set; }
        public double Price { get; set; }
    }
}
