using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Sharpnado.Tabs;

namespace MealPlanner;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSharpnadoTabs(loggerEnable: true)
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Montserrat-Regular.ttf", "Montserrat");
                fonts.AddFont("Montserrat-Italic.ttf", "MontserratItalic");
                fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");
                fonts.AddFont("Montserrat-BoldItalic.ttf", "MontserratBoldItalic");
                fonts.AddFont("Montserrat-Light.ttf", "MontserratLight");
                fonts.AddFont("Montserrat-LightItalic.ttf", "MontserratLightItalic");
                fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
                fonts.AddFont("Montserrat-MediumItalic.ttf", "MontserratMediumItalic");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
