var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Build the service provider
var provider = builder.Services.BuildServiceProvider();

// Get the configuration service from the provider
var configuration = provider.GetRequiredService<IConfiguration>();

// Add CORS policy
//Enable Cors

builder.Services.AddCors(c =>

{

    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

});


var app = builder.Build();


//Enable CORS

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());


//builder.Services.AddCors(options => {

//    var Frontend_url = configuration.GetValue<string>("Frontend_url");

//    options.AddDefaultPolicy(b =>
//    {
//        //builder.WithOrigins(Frontend_url).AllowAnyMethod().AllowAnyHeader();
//        b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//    });

//});


//app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
//app.MapControllers();


app.UseEndpoints(Endpoint => { Endpoint.MapControllers(); });
//app.UseCors(x => x.
//AllowAnyOrigin(). 
//AllowAnyMethod(). 
//AllowAnyHeader());
app.Run();








