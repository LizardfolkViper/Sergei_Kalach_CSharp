using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Homework.Telecomms
{
    class TelecomHub
    {
        public Dictionary<string, TelecommTerminal> terminalDictionary;
        public List<CallInfo> CallsHistory { get; set; }

        public TelecomHub()
        {
            terminalDictionary = new Dictionary<string, TelecommTerminal>();
            CallsHistory = new List<CallInfo>();
        }

        public string CreateNewTerminal()
        {
            var terminalNumber = new Random().Next(1000000, 10000000).ToString();
            var newTerminal = new TelecommTerminal(terminalNumber);
            try
            {
                terminalDictionary.Add(terminalNumber, newTerminal);
            }
            catch
            {
                CreateNewTerminal();
            }
            terminalDictionary[terminalNumber].RecordCallInfo += SaveCall;
            return terminalNumber;
        }

        public void terminalInfo(string terminalNumber)
        {
            Console.WriteLine($"Terminal {terminalNumber}, balance - {terminalDictionary[terminalNumber].terminalBalance}");
        }

        public void SaveCall(TelecommTerminal currentTerminal, string targetedNumber)
        {
            var recordedCall = new CallInfo(currentTerminal, targetedNumber);
            CallsHistory.Add(recordedCall);
        }


    }
}
