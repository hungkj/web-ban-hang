using doanweb1.Entities;
using doanweb1.Interfaces;

using doanweb1.Reponsitory;
using doanweb1.Services;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAuthReponsitory, AuthReponsitory>();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddDbContext<san_phamContext>();
builder.Services.AddTransient<IProductReponsitory, ProductReponsitory>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IHomeReponsitory, HomeReponsitory>();
builder.Services.AddTransient<IHomeService, HomeService>();
builder.Services.AddTransient<ICardService, CardService>();
builder.Services.AddTransient<ICardReponsitory, CartReponsitory>();

builder.Services.AddHttpContextAccessor();
//add http accessor
builder.Services.AddHttpContextAccessor();
//xu ly session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>

{
    options.IdleTimeout = TimeSpan.FromSeconds(60);
    //options.Cookie.HttpOnly = true;
    //options.Cookie.IsEssential = true; // Make the session cookie essential
});        
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//xu ly session
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
