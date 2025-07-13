using EmployeeCustomAPI.Filters;
using Microsoft.OpenApi.Models; // <-- Needed for Swagger security config

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>(); // Global exception filter
});

builder.Services.AddScoped<CustomAuthFilter>();
builder.Services.AddEndpointsApiExplorer();

// ✅ Swagger config with Authorization header support
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "EmployeeCustomAPI",
        Version = "v1",
        Description = "API to manage employee data"
    });

    // 🔐 Add Bearer token config to Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer <token>' (just needs to contain the word 'Bearer')"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
