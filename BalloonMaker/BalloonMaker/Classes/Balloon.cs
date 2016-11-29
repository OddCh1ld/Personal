using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonMaker.Classes
{
    class Balloon
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private string _size;

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private int _psi;

        public int Psi
        {
            get { return _psi; }
            set { _psi = value; }
        }

        public Balloon(string color, string size, int psi)
        {
            if (color == "yellow" || color == "Yellow")
                throw new ArgumentException("Yellow is fucking terrible!", "color");
            if (color != "blue" && color != "red" && color != "green" && color != "orange" && color != "pink" && color != "black" && color != "purple")
                throw new ArgumentException("Please select one of the listed colors.");
            Color = color;

            if (size == "large" || size == "medium" || size == "small")
                Size = size;
            else
                throw new ArgumentException("Not an option, try again", "size");
            /*
            if(size != "medium")
                throw new ArgumentException("Not an option, try again", "size");
            if(size != "small")
                throw new ArgumentException("Not an option, try again", "size");
             */
            Size = size;

            if (psi < 0)
                throw new ArgumentException("A positive number is needed here", "psi");
            Psi = psi;
        }

        public override string ToString()
        {
            return "The " + Color + " balloon is " + Size + " filled with " + Psi + "psi";
        }

    }
}