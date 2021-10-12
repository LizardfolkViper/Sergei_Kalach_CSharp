using System;

namespace ITAcademy.Homework.Telecomms
{
    class Program
    {
        static void Main(string[] args)
        {
            var Telecompany = new TelecomHub();
            var medNumber = Telecompany.CreateNewTerminal();
            Telecompany.terminalDictionary[medNumber].TerminalMakeCall("6666666");
            Telecompany.terminalInfo(medNumber);

        }
    }
}
