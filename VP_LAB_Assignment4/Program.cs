using VP_LAB_Assignment4.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()

    .AddInteractiveServerComponents();
builder.Services.AddSingleton<VP_LAB_Assignment4.Services.AuthenticationStateService>();
builder.Services.AddSingleton<VP_LAB_Assignment4.Services.NotificationConfig>();
builder.Services.AddTransient<VP_LAB_Assignment4.Services.NotificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
