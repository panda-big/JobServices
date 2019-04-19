using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobServiceDemo
{
    public class TestJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));
        public Task Execute(IJobExecutionContext context)
        {
            _logger.Info("每3秒输出");
            return Task.FromResult(true);
        }
    }
}
