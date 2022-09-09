using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace API;

public class CleanUpDtoSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.Type.Name.Contains("DTO", StringComparison.InvariantCultureIgnoreCase))
        {
            schema.Title = context.Type.Name.Replace("DTO", "", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}