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
  
* 1.0             22-12-2014        Manisha Narula                 5783                      wcf of wallettopupservice   
*/

namespace WalletTopUpService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWalletTopUp
    {
        [OperationContract(IsOneWay=true)]
        void GetData(TopUpRequest request);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    
}
