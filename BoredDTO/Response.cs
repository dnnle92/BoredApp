using System;
using System.Collections.Generic;
using System.Text;

namespace BoredDTO
{
    public enum EType
    {
        Education,
        Recreational,
        Social,
        DIY,
        Charity,
        Cooking,
        Relaxation,
        Music,
        Busywork
    }

    public enum EPrice
    {
        Free, Cheap, Moderate, Expensive
    }

    public class Response
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public float Accessibility { get; set; }
        public EType? Type { get; set; }
        public int Participants { get; set; }
        public EPrice? Price { get; set; }
      }
}
