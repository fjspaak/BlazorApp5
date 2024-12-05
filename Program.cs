using BlazorApp5.Authorization;
using BlazorApp5.Components;
using BlazorApp5.Models;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
            .AddNegotiate();

        builder.Services.AddDbContext<DwhNlPortalContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("ExternalDbConnection")));

        builder.Services.AddScoped<IAuthorizationHandler, UserInDatabaseHandler>();
        builder.Services.AddAuthorization(options =>
        {
            //options.AddPolicy("UserInDatabase", policy =>
            //    policy.Requirements.Add(new UserInDatabaseRequirement()));
            options.FallbackPolicy = options.DefaultPolicy;
        });

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddCascadingAuthenticationState();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
