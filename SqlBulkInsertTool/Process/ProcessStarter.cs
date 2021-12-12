using System;
namespace SqlBulkInsertTool.Process
{
    public class ProcessStarter : IProcess
    {
        void IProcess.Process()
        {
            Console.WriteLine("Configured");
        }
    }
}

