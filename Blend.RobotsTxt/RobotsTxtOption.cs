using System;
using System.ComponentModel;

namespace Blend.RobotsTxt
{
    /// <summary>
    /// Definition for each robot object
    /// </summary>
    [Description("Definition for each robot object")]
    public class RobotsTxtOption
    {

        /// <summary>
        /// User Agent to target
        /// </summary>
        [DefaultValue("*")]
        [Description("User Agent to target")]
        public string UserAgent { get; set; }

        /// <summary>
        /// Array of paths to allow
        /// </summary>
        [DefaultValue(new string[] { })]
        [Description("Array of paths to allow")]
        public string[] Allow { get; set; }

        /// <summary>
        /// Array of paths to disallow
        /// </summary>
        [DefaultValue(new string[] { "/" })]
        [Description("Array of paths to allow")]
        public string[] Disallow { get; set; }

        /// <summary>
        /// Path to the sitemap.xml file
        /// </summary>
        [DefaultValue("")]
        [Description("Path to the sitemap.xml file")]
        public string Sitemap { get; set; }

    }
}
