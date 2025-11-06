var builder = WebApplication.CreateBuilder(args); //setup the web application builder, configuration, services, etc.

// Add services to the container.
builder.Services.AddControllersWithViews(); // Add MVC services to the service container with supportfor both controller and views

var app = builder.Build(); // Build the application pipeline, configure middleware, etc.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) 
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts(); // Use HSTS (HTTP Strict Transport Security) in production to enforce secure connections
} // Use exception handling middleware in production and enable HSTS, 

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseRouting(); // Enable routing middleware to match incoming requests to endpoints

app.UseAuthorization(); // Enable authorization middleware to enforce access control policies, authorizes user to acces secured resources

app.MapStaticAssets(); // Map static assets to be served from the wwwroot folder like html, css, js, images, etc.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets(); // Map the default route for controllers, with optional id parameter, and enable static assets for this route


app.Run(); // Run the application, starting the web server and listening for incoming requests
