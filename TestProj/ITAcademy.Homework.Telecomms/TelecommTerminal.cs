using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Homework.Telecomms
{
    class TelecommTerminal
    {
        public readonly string terminalNumber;
        public decimal terminalBalance { get; private set; }

        public event Delegates.CallHandler RecordCallInfo;

        public TelecommTerminal(string TerminalNumber)
        {
            terminalNumber = TerminalNumber;
        }

        public void TerminalPayment(decimal paymentAmount)
        {
            terminalBalance += paymentAmount;
        }

        public void TerminalMakeCall(string targetedNumber)
        {
            if (terminalBalance >= 10)
            {
                terminalBalance -= 10;
                RecordCallInfo?.Invoke(this, targetedNumber);
            }
        }
    }
}
