using System;

namespace BolasColoridas
{
    public class cor
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public cor(int red, int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        
         public cor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }


    }
}