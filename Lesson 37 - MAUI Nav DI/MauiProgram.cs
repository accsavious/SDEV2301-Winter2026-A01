using Lesson37DemoMauiApp.Services;
using Microsoft.Extensions.Logging;

namespace Lesson37DemoMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            // Our custom DI registration
            builder.Services.AddSingleton<IProductService, MockProductService>();
            builder.Services.AddSingleton<IDiscountService, SimpleDiscountService>();

            return builder.Build();
        }
    }
}
