using System;
using System.Collections.Generic;
using IBM.WMQ;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

/*
 * DaniloBuchner.com 
 **/

namespace MQMessaging.MQConnection
{
    public class MQConnect
    {
        MQQueueManager queueManager;
        MQQueue queue;
        MQMessage queueMessage;

        static string queueName;
        string message;

        public bool ConnectMQ(string queueManagerName, string queueName, string channelName, string mqHost)
        {            
            bool result = false;
            try
            {
                queueManager = new MQQueueManager(queueManagerName, channelName, mqHost);
                result = true;
            }
            catch (MQException exp)
            {
               Console.Write("Exception: " + exp.Message);
            }
            catch (Exception exp)
            {
                Console.Write("Exception: " + exp.Message);
            }
            return result;
        }

        public bool DisconnectMQ()
        {
            bool result = false;
            try
            {
                queueManager.Disconnect();
                result = true;
            }
            catch (MQException exp)
            {
                Console.Write("Exception: " + exp.Message);
            }
            catch (Exception exp)
            {
                Console.Write("Exception: " + exp.Message);
            }
            return result;
        }

        public bool WriteMsgLocalMQ(string strInputMsg, string strQueueName)
        {
            bool result = false;
            MQConnect.queueName = strQueueName;
            try
            {
                queue = queueManager.AccessQueue(MQConnect.queueName,
                  MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING);
                message = strInputMsg;
                queueMessage = new MQMessage();
                queueMessage.WriteString(message);
                queueMessage.Format = MQC.MQFMT_STRING;                
                queue.Put(queueMessage, new MQPutMessageOptions());
                result = true;                
            }
            catch (MQException MQexp)
            {
                Console.Write("Exception: " + MQexp.Message);
                result = false;
            }
            catch (Exception exp)
            {
                Console.Write("Exception: " + exp.Message);
                result = false;
            }
            return result;
        }       
        
        public Tuple<bool, string> ReadMsgLocalMQ(string QueueName)
        {
            string strResult = "";
            bool boolResult = false;

            MQConnect.queueName = QueueName;
            try
            {
                queue = queueManager.AccessQueue(MQConnect.queueName, MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING);
                queueMessage = new MQMessage()
                {
                    Format = MQC.MQFMT_STRING
                };                
                queue.Get(queueMessage, new MQGetMessageOptions());
                strResult = queueMessage.ReadString(queueMessage.MessageLength);
                boolResult = true;
                queue.Close();
            }
            catch (MQException MQexp)
            {
                strResult = "Exception: " + MQexp.Message;
            }
            catch (Exception exp)
            {
                strResult = "Exception: " + exp.Message;
            }
            return new Tuple<bool, string>(boolResult, strResult);
        }
    }
}
