using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp40
{
    public class TrafficLight
    {
        public TrafficLight(string color, int duration)
        {
            if (color.ToLower() == "red")
            {
                this.color = Color.Red;
            }
            else if (color.ToLower() == "yellow")
            {
                this.color= Color.Yellow;
            }
            else if(color.ToLower() == "green")
            {
                this.color = Color.Green;
            }
            else
            {
                Exception ex = new Exception("Not a trafficlight color");
                throw ex;
            }
            this.prev_colour = Color.Green;
            if (duration <= 0) throw new Exception("Time cannot be less or equal to zero");
            else this.duration = duration;
        }
        public TrafficLight(Color color, int duration)
        {
            if(color == Color.Red || color == Color.Green || color == Color.Yellow)
            {
                this.color = color;
                this.prev_colour = Color.Green;
            }
            else
            {
                Exception ex = new Exception("Not a trafficlight color");
                throw ex;
            }
            if (duration <= 0) throw new Exception("Time cannot be less or equal to zero");
            else this.duration = duration;

        }
        public TrafficLight()
        {
            this.color = Color.Green;
            this.duration = 5;
            this.prev_colour = Color.Green;
        }

        public bool allowed_move() => this.color == Color.Green;
        public void move()
        {
           
            if(color == Color.Green)
            {
                this.prev_colour = color;
                this.color = Color.Yellow;
            }
            else if (color == Color.Red)
            {
                this.prev_colour = color;
                this.color = Color.Yellow;
            }
            else if (color == Color.Yellow)
            {

                if (prev_colour == Color.Green)
                {
                    this.color = Color.Red;
                }
                else
                {
                    this.color = Color.Green;
                }
                this.prev_colour = color;
            }
        }
        private Color prev_colour;
        public Color color { get; private set; }
        private int duration;

    }
}
