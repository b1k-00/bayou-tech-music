using API;
using Application;
using Application.Interfaces;
using Application.Persistence;
using Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Persistence;
using Persistence.Repositories;
using Swashbuckle.AspNetCore.Swagger;

var builder = WebApplication.CreateBuilder(args);

//We'll be using this in several spots, so just grab it once
//var cognitoAuthority = builder.Configuration["AWS:CognitoAuthority"];

//This will slugify and lowercase all routes automatically (so /api/DadJokes will become /api/dad-jokes)
builder.Services.AddControllers();

//    (options =>
//{
//    options.Conventions.Add(new RouteTokenTransformerConvention(new SlugifyParameterTransformer()));
//});

//Use our extension methods to configure anything we've defind in our other libraries
//builder.Services.ConfigureApplicationServices();
//builder.Services.ConfigurePersistenceServices(builder.Configuration);

//Add our CORS polic. We are being as permissive as possible here.
//builder.Services.AddCors(options =>
//    {
//        options.AddPolicy("CorsPolicy",
//            policyBuilder => policyBuilder.AllowAnyOrigin()
//            .AllowAnyMethod()
//            .AllowAnyHeader());
//    });

builder.Services.AddHttpContextAccessor();
//This adds Amazon Cognito as the Identity Provider
//builder.Services.AddCognitoIdentity();

//builder.Services.AddDbContext<BayouTechDbContext>(options => 
//options.UseSqlServer(builder.Configuration.GetConnectionString("BayouTechDb")), ServiceLifetime.Scoped);

builder.Services.AddDbContext<BayouTechDbContext>(options =>
                options.UseSqlServer(builder
                .Configuration
                .GetConnectionString("BayouTechMusicDb")), ServiceLifetime.Scoped);

builder.Services.AddScoped<ISongApp, SongApp>();
builder.Services.AddScoped<IGenericRepository<Song>, SongRepository>();
builder.Services.AddScoped<IArtistApp, ArtistApp>();
builder.Services.AddScoped<IGenericRepository<Artist>, ArtistRepository>();



//This adds Amazon Cognito as the Identity Provider
//builder.Services.AddCognitoIdentity();

////Configure our authentication services to use Amazon Cognito
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//.AddJwtBearer(options =>
//{
//    options.Authority = builder.Configuration["AWS:CognitoAuthority"];
//    options.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuerSigningKey = true,
//        ValidateAudience = false
//    };
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Bayou Tech Music .Net API V1", Version = "v1" });
    options.EnableAnnotations();
    //options.SchemaFilter<CleanUpDtoSchemaFilter>();
    //options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    //{
    //    Type = SecuritySchemeType.OAuth2,
    //    Flows = new OpenApiOAuthFlows
    //    {
    //        Implicit = new OpenApiOAuthFlow
    //        {
    //            AuthorizationUrl = new System.Uri($"{cognitoAuthority}/oauth2/default/v1/authorize"),
    //            TokenUrl = new System.Uri($"{cognitoAuthority}/oauth2/default/v1/token"),
    //        }
    //    }
    });

//    options.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme {
//                Reference = new OpenApiReference
//                {
//                    Type = ReferenceType.SecurityScheme,
//                    Id = "oauth2"
//                }
//            },
//            new[] { "readAccess", "writeAccess" }
//        }
//    });
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger(new SwaggerOptions());
app.UseSwaggerUI(options =>
{
    //        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Bayou Tech Music .Net API V1");
    //        options.OAuthClientId(builder.Configuration["AWS:UserPoolClientId"]);
    //        options.OAuthUseBasicAuthenticationWithAccessCodeGrant();
    //        options.OAuthAppName("Swagger UI");
    //        options.OAuthScopeSeparator($"openid profile email");
    //        options.OAuthAdditionalQueryStringParams(new Dictionary<string, string> { { "nonce", "nonce" } });
});
//}

//app.UseHttpsRedirection();

//app.UseAuthentication();
//app.UseAuthorization();

//app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();

//Add this partial class here to aid in Integration testing
public partial class Program { }