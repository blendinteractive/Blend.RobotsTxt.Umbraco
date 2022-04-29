
namespace Our.Umbraco.Blend.RobotsTxt
{
    public class RobotOptions
    {
        public const string Robots = "Robots";

        public string UserAgent { get; set; }

        public string[] Allow { get; set; }

        public string[] Disallow { get; set; }

        public string Sitemap { get; set; }
    }
}
