using Microsoft.AspNetCore.Mvc;
using System.Text;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Controllers;

namespace Blend.RobotsTxt
{
    public class RobotsTxtController : PluginController
    {
        private readonly IRobotsBuilder _robotsBuilder;

        public RobotsTxtController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IRobotsBuilder robotsBuilder)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger)
        {
            _robotsBuilder = robotsBuilder;
        }

        [Route("robots.txt")]
        public IActionResult RenderRobots()
        {
            var robotsTxt = _robotsBuilder.BuildRobots();
            return Content(robotsTxt, "text/text", Encoding.UTF8);
        }
    }
}
