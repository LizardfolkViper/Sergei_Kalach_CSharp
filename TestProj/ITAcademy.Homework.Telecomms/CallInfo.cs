using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademy.Homework.Telecomms
{
    class CallInfo
    {
        public TelecommTerminal initialTerminal;

        public string calledTerminal;

        public CallInfo(TelecommTerminal InitialTerminal, string TargetedTerminal)
        {
            initialTerminal = InitialTerminal;
            calledTerminal = TargetedTerminal;
        }
    }
}
