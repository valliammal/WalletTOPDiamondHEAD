using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using WalletTopUp.Contract;
using WalletTopUp.Data;


/*
Project Name:-WalletTopUpService
Organization:- MpowerSoftComm with all copyrights reserved.
----------------------------------------------------------------------------------------------------------------------------------------------
Version No         Date(DD-MM-YYYY)      Name                    SR Issue/CR No               ModificationDescription 
----------------------------------------------------------------------------------------------------------------------------------------------
  
* 1.0             22-12-2014        Manisha Narula                 5783                      to insert data after reversal wallettopupservice   
*/

namespace WalletTopUpService
{
  public class WalletTopUpQueue
    {
        TopUpRequest request;
        WalletTopUp.Data.CommunicationData data = new CommunicationData();
        public WalletTopUpQueue(TopUpRequest req)
        {
            request = req;
        }
        public void Queuecall()
        {
            try
            {
                Queue queue = new Queue();
             
                long Requestid = 0;
                int ProcessorId = 0;
                string type = string.Empty, Description = string.Empty;

                Requestid = request.RequestId;
                ProcessorId = request.ProcessorId;
                type = request.Type;
                Description = request.Description;

                data.InsertCommunicationLog(Requestid, ProcessorId, type, Description);

            }
            catch (Exception ex)
            {
                try
                {
                    data.LogError("Exception", ex.ToString(), request.RequestId);
                }
                catch (Exception ex1)
                {

                }
            }
        }
    }
}
