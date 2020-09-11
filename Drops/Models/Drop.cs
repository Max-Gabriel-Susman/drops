using System;
using Xamarin.Forms.Maps;


namespace Drops.Models
{
    public class Drop : Pin
    {
        public Drop() : base()
        {

        }

        public override string ToString()
        {
            return Label;
        }
         
    }
}