using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense.Models
{
    public class GameObject
    {
        private float wx, wy;
        //public float WorldX { get { return wx; } set { wx = value; screenspr = new RectangleF(ViewX, ViewY, ViewX + Width, ViewY + Height); } }
        //public float WorldY { get { return wy; } set { wy = value; screenspr = new RectangleF(ViewX, ViewY, ViewX + Width, ViewY + Height); } }
        public short TextureIndex;
        public int Width;
        public int Height;
        //public int ViewX { get { return (int)(WorldX); } }
        //public int ViewY { get { return (int)(WorldY); } }
        public byte ViewZ;
        public bool DeleteMe = false;
        //private RectangleF screenspr;
        //public RectangleF ScreenSprite { get { return new RectangleF(ViewX, ViewY, ViewX + Width, ViewY + Height); } set { screenspr = value; } }


        public GameObject(short TextureIndex, float worldX, float worldY, int width = 0, int height = 0)
        {
            this.TextureIndex = TextureIndex;
            //this.WorldX = worldX;
            //this.WorldY = worldY;
            if (width == 0 && height == 0)
            {
                throw new Exception("width not set");
            }
            else { this.Width = width; this.Height = height; }
            //ScreenSprite = new RectangleF(ViewX, ViewY, ViewX + Width, ViewY + Height);
        }
            
        
        public virtual void Draw() //pas as pramaneter instance of class responsible for drawing
        {
            //draw logic
        }


        public virtual void Update(double curTime)
        {
            //update in function of time 
            //TODO: Implement timer
        }
    }
}
