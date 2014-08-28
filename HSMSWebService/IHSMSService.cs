using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HSMSWebService
{

    [ServiceContract]
    public interface IHSMSService
    {
        // TODO: Add your service operations here
        [OperationContract]
        HSMS[] getAllActions();

        [OperationContract]
        HSMS[] getActionsByPriority(int priority);
    }

    [DataContract]
    public class HSMS
    {
        private int id;
        private string desc;
        private string number;
        private string price;
        private string organisation;
        private int priority;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        [DataMember]
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        [DataMember]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public string Organisation
        {
            get { return organisation; }
            set { organisation = value; }
        }

        [DataMember]
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
