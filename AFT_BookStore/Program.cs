var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "Login",
        pattern: "dang-nhap",
        defaults: new { controller = "Auth", action = "Login" });

    endpoints.MapControllerRoute(
        name: "Register",
        pattern: "dang-ky",
        defaults: new { controller = "Auth", action = "Register" });

    endpoints.MapControllerRoute(
        name: "ProductDetail",
        pattern: "san-pham/{id}",
        defaults: new { controller = "Product", action = "Index" });

    endpoints.MapControllerRoute(
        name: "Shop",
        pattern: "cua-hang",
        defaults: new { controller = "Shop", action = "Index" });

    endpoints.MapControllerRoute(
        name: "ShopOrderingGuide",
        pattern: "huong-dan-dat-hang",
        defaults: new { controller = "Order", action = "OrderingGuide" });

    endpoints.MapControllerRoute(
        name: "ShippingInformation",
        pattern: "hinh-thuc-van-chuyen",
        defaults: new { controller = "Order", action = "ShippingInformation" });

    endpoints.MapControllerRoute(
        name: "Cart",
        pattern: "gio-hang",
        defaults: new { controller = "Order", action = "Cart" });

    endpoints.MapControllerRoute(
        name: "Posts",
        pattern: "bai-viet",
        defaults: new { controller = "Posts", action = "Index" });

    endpoints.MapControllerRoute(
        name: "Contact",
        pattern: "lien-he",
        defaults: new { controller = "Home", action = "Contact" });

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
