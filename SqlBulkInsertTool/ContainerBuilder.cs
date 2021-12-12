using System;
using Microsoft.Extensions.DependencyInjection;
using SqlBulkInsertTool.Process;

namespace SqlBulkInsertTool
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IProcess, ProcessStarter>();

            return container.BuildServiceProvider();
        }
    }
}

