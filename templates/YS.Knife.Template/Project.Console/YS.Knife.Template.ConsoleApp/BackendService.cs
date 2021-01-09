using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YS.Knife.Template.ConsoleApp
{
    public class BackendService : YS.Knife.HostedService.TimerTickHostedService
    {
        protected override TimeSpan Interval => throw new NotImplementedException();

        protected override void OnException(Exception exception)
        {

        }

        protected override void OnTick(CancellationToken state)
        {
            throw new NotImplementedException();
        }
    }
}
