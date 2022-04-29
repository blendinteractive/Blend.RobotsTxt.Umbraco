using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Our.Umbraco.Blend.RobotsTxt
{
    public class RobotsComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddOptions<List<RobotOptions>>().Bind(builder.Config.GetSection(RobotOptions.Robots));
            builder.Services.AddSingleton<IRobotsBuilder, RobotsBuilder>();
        }
    }
}
