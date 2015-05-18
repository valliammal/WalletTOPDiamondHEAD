using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WalletTopUp.Contract;

/*
Project Name:-WalletTopUpService
Organization:- MpowerSoftComm with all copyrights reserved.
----------------------------------------------------------------------------------------------------------------------------------------------
Version No         Date(DD-MM-YYYY)      Name                    SR Issue/CR No               ModificationDescription 
----------------------------------------------------------------------------------------------------------------------------------------------
  
* 1.0             22-12-2014        Manisha Narula                 5783                       to call wcf service   
*/

namespace WalletTopUpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WalletTopUpService : IWalletTopUp
    {
        public void GetData(TopUpRequest req)
        {
            WalletTopUpQueue queue = new WalletTopUpQueue(req);
            queue.Queuecall();

        }

    }
}
