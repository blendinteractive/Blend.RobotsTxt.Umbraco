using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Blend.RobotsTxt
{
    public class RobotsTxtComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddOptions<List<RobotsTxtOption>>().Bind(builder.Config.GetSection(RobotsTxtConstants.Robots));
            builder.Services.AddSingleton<IRobotsBuilder, RobotsTxtBuilder>();
        }
    }
}
