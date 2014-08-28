using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HSMSWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class HSMSService : IHSMSService
    {
        
        private HSMSDatabase database = new HSMSDatabase();

        public HSMS[] getAllActions()
        {
            database.ConnectToDatabase();
            return database.AllActions();
        }

        public HSMS[] getActionsByPriority(int priority)
        {
            database.ConnectToDatabase();
            return database.ActionsByPriority(priority);
        }
    }
}
