using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Models
{
    public struct RectangleF //: IEquatable<RectangleF>
    {
        public static readonly RectangleF Empty;

        //public static bool operator !=(RectangleF left, RectangleF right);
        //public static bool operator ==(RectangleF left, RectangleF right);
        //public static implicit operator System.Drawing.RectangleF(RectangleF input);
        //public static implicit operator RectangleF(System.Drawing.RectangleF input);

        public float Bottom { get; set; }
        public float Height { get; set; }
        public float Left { get; set; }
        public float Right { get; set; }
        public float Top { get; set; }
        public float Width { get; set; }
        public float X { get; set; }
        public float Y { get; set; }


        

        

        //public override void Equals(object obj){}
        //public void Equals(RectangleF other){}
        //public override void GetHashCode(){}
    }
}
