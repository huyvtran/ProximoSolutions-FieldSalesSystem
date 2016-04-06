using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    class DisplayPicture
    {
        private string pictureURL;
        public void setPicture(string pictureURL) {
            this.pictureURL = pictureURL;
        }

        public void getPicture() {
            return this.pictureURL;
        }
    }
}
