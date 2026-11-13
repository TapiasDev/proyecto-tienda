using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.StaticFiles;
using LaQuiebraBack.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger (en .NET 9 se instala manualmente el paquete Swashbuckle.AspNetCore)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=LocalConnection"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseDefaultFiles();
var staticFileContentTypes = new FileExtensionContentTypeProvider();
staticFileContentTypes.Mappings[".dat"] = "application/octet-stream";
app.UseStaticFiles(new StaticFileOptions { ContentTypeProvider = staticFileContentTypes });

app.UseAuthorization();

app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
