using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable]
    class DisplayPicture
    {
        private Image displayPicture;

        public DisplayPicture(Image displayPicture) {
            this.displayPicture = displayPicture;
        }

        public void setPicture(Image displayPicture) {
            this.displayPicture = displayPicture;
        }

        public Image getPicture() {
            return displayPicture;
        }
    }
}
