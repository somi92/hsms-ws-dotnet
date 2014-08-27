using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HSMSWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHSMSService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        HSMS[] getAllActions();

        [OperationContract]
        HSMS[] getActionsByPriority(int priority);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
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
