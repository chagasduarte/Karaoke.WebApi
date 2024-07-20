using karaoke.WebApi.Mapping;
using Karaoke.Domain.Interfaces;
using Karaoke.Infrastruct.Context;
using Karaoke.Domain.Models.Settings;
using Karaoke.Infrastruct.Rest;
using Karaoke.Infrastruct.Services;
using Karaoke.WebApi.Mapping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("ConnectionStrings")));
builder.Services.AddHttpClient();
builder.Services.AddTransient<IPlaylistService, PlaylistService>();
builder.Services.AddTransient<IYoutubeApi, YoutubeApiRest>();
builder.Services.AddTransient<IVideoService, VideoService>();
builder.Services.AddScoped<IGetUrlRequest, GetUrlRequest>();
builder.Services.AddSingleton<IListKaraokeService, ListKaraokeService>();

builder.Services.AddSingleton(builder.Configuration.GetSection("AplicationSettings").Get<AplicationSettings>());



builder.Services.AddAutoMapper(typeof(PlaylistMapping));
builder.Services.AddAutoMapper(typeof(VideosMapping));
builder.Services.AddAutoMapper(typeof(YoutubeMapping));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
