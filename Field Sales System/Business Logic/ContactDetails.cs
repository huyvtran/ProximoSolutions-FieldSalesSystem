using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Business_Logic
{
    [Serializable()]
    public class ContactDetails
    {
        private int mobileNo;
        private int landNo;
        private string emailAddress;
        private string addressLine_1;
        private string addressLine_2;
        private string addressLine_3;

        public int MobileNo
        {
            get
            {
                return mobileNo;
            }

            set
            {
                mobileNo = value;
            }
        }

        public int LandNo
        {
            get
            {
                return landNo;
            }

            set
            {
                landNo = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
            }
        }

        public string AddressLine_1
        {
            get
            {
                return addressLine_1;
            }

            set
            {
                addressLine_1 = value;
            }
        }

        public string AddressLine_2
        {
            get
            {
                return addressLine_2;
            }

            set
            {
                addressLine_2 = value;
            }
        }

        public string AddressLine_3
        {
            get
            {
                return addressLine_3;
            }

            set
            {
                addressLine_3 = value;
            }
        }

        public ContactDetails( int mobileNo, int landNo, string emailAddress, string addressLine_1,string addressLine_2,string addressLine_3) {
            this.MobileNo = mobileNo;
            this.LandNo = landNo;
            this.EmailAddress = emailAddress;
            this.AddressLine_1 = addressLine_1;
            this.AddressLine_2 = addressLine_2;
            this.AddressLine_3 = addressLine_3;
                    
        }

        
    }
}
