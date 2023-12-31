using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IFileManagement, FileManagement>();
builder.Services.AddDbContext<RestaurantContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//AutoMapperProfile
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddSingleton(provider => new MapperConfiguration(config =>
{
    config.AddProfile(new AutoMapperProfile());
}).CreateMapper());
//conneting to the angular front end application
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(builders => {
        var angularAppOrigin = builder.Configuration.GetValue<string>("AngularApplication");

        builders.WithOrigins(angularAppOrigin).AllowAnyHeader().AllowAnyMethod();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using(var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<RestaurantContext>();
    SampleSeedData.SeedData(context);
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseRouting();

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
