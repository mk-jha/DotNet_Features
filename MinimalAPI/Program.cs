// Just four lines code to create API endpoint

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Swagger implementation 11
app.UseSwagger();
app.UseSwaggerUI();
app.UseSwagger(x => x.SerializeAsV2 = true);
app.MapGet("/", () => "Hello World! Minimal API");

// Creating New endpoint for demo

app.MapGet("/getDetails", () => new { Name = "Murari jha", Address = "New Delhi", Contact = "888888" }); //done going to run now 

// For example
app.MapPost("Create", () =>new { });
app.MapPut("Update/{id}", () => new { });
app.MapDelete("Delete/{id}", () => new { });


app.Run();
