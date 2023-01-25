using CommandLine;

namespace SchemaGenerator
{
    internal class Options
    {
        [Option('o', "outputFile", Required = false,
            HelpText = "",
            Default = "..\\Blend.RobotsTxt\\appsettings-schema.robotstxt.json")]
        public string OutputFile { get; set; }
    }
}
