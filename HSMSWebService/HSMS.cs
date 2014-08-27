using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSMSWebService
{
    public class HSMS
    {
        private int id;
        private string desc;
        private string number;
        private string price;
        private string organisation;
        private int priority;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Organisation
        {
            get { return organisation; }
            set { organisation = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public HSMS()
        {

        }

        public HSMS(int id, string desc, string number, string price, string organisation, int priority)
        {
            this.id = id;
            this.desc = desc;
            this.number = number;
            this.price = price;
            this.organisation = organisation;
            this.priority = priority;
        }
    }
}