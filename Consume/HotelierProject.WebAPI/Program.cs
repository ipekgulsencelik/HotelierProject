
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.BusinessLayer.Concrete;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.EntityFramework;

namespace HotelierProject.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<IRoomDAL, EFRoomDAL>();
            builder.Services.AddScoped<IRoomService, RoomManager>();

            builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<IStaffDAL, EFStaffDAL>();
            builder.Services.AddScoped<IStaffService, StaffManager>();

            builder.Services.AddScoped<ISubscribeDAL, EFSubscribeDAL>();
            builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

            builder.Services.AddScoped<ITestimonialDAL, EFTestimonialDAL>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

            builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
            builder.Services.AddScoped<IAboutService, AboutManager>();

            builder.Services.AddScoped<IBookingDAL, EFBookingDAL>();
            builder.Services.AddScoped<IBookingService, BookingManager>();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("OtelApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("OtelApiCors");

            app.MapControllers();

            app.Run();
        }
    }
}