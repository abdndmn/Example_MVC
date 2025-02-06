var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();

//Controller - Action - Model -  View - Razor - RazorView - wwwroot kavramlarının ve builder.Build() - app.Run() metotlarının ne işe yaradıklarını,  hangi amaçla kullanıldıklarını Program.cs'in en alt kısmında yorum satırı olarak açıklayınız.
//Controller, .NET içerindeki bir Base Controller Classtan miras alan bir classtır.
//Action bir metottur.
//Model veri yapıları ve iş mantıgını temsil eder.
//View, UI tarafının kodlarını barındırır.
//Razor(@) C# kodunu .cshtml içine yerleştirmek için kullanılır.
//RazorView, ASP.NET Core MVC’de görselleri (UI) oluşturan dinamik HTML dosyalarıdır.
// wwwroot/, ASP.NET Core projelerinde statik dosyaların (CSS, JS, resimler, fontlar) saklandığı klasördür.
//WebApplicationBuilder, servisleri ekler ve yapılandırır. Build() çağrıldığında uygulama çalışmaya hazır hale gelir.
//app.Run(); Uygulamayı çalıştıran ve HTTP isteklerini dinlemeye başlayan metottur.
