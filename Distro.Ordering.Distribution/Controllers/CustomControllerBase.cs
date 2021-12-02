using Distro.Ordering.DataAccess;
using Distro.Seedworks.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace Distro.Ordering.Distribution.Controllers
{
    public abstract class CustomControllerBase : ControllerBase
    {
        public ApplicationDbContext context { get; set; }
        public LogWriter logger { get; set; }

        protected CustomControllerBase(ApplicationDbContext dbContext)
        {
            context = dbContext;
            logger = new LogWriter(LogManager.GetCurrentClassLogger());
        }
    }
}
