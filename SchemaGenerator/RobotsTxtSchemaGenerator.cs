using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using NJsonSchema.Generation;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace SchemaGenerator
{
    internal class RobotsTxtSchemaGenerator
    {
        private readonly JsonSchemaGenerator _schemaGenerator;

        public RobotsTxtSchemaGenerator()
        {
            _schemaGenerator = new JsonSchemaGenerator(new BlendRobotsTxtSchemaGeneratorSettings());
        }

        public string Generate()
        {
            var schema = GenerateRobotsTxtSchema();
            return schema.ToString();
        }

        private JObject GenerateRobotsTxtSchema()
        {
            var schema = _schemaGenerator.Generate(typeof(RobotsTxtAppSettings));
            return JsonConvert.DeserializeObject<JObject>(schema.ToJson());
        }
    }

    internal class BlendRobotsTxtSchemaGeneratorSettings : JsonSchemaGeneratorSettings
    {
        public BlendRobotsTxtSchemaGeneratorSettings()
        {
            AlwaysAllowAdditionalObjectProperties = true;
            SerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver(),
            };
            DefaultReferenceTypeNullHandling = ReferenceTypeNullHandling.NotNull;
            SchemaNameGenerator = new DefaultSchemaNameGenerator();
            SerializerSettings.Converters.Add(new StringEnumConverter());
            IgnoreObsoleteProperties = true;
            GenerateExamples = true;
        }
    }
}
