using DataAcess.Data;
using DataAcess.DbAccess;
using ProcessoFIAP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDbDataAcess, DbDataAcess>();
builder.Services.AddScoped<IAlunoData, AlunoData>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<ITurmaData, TurmaData>();
builder.Services.AddScoped<ITurmaService, TurmaService>();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
