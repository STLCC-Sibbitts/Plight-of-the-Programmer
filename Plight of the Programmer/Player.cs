using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plight_of_the_Programmer
{
    class Player
    {
        /*-----Variables-----*/
        private static string skin = "Jordan";
        private static int xPos = 0;
        private static int yPos = 0;

        /*-----Get/Set-----*/
        public static string Skin
        {
            get { return skin; }
            set { skin = value; }
        }
        public static int Xpos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public static int Ypos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        /*-----Functions-----*/
        public void movement(int dx, int dy)
        {
            Xpos += dx;
            Ypos += dy;
        }
    }
}
