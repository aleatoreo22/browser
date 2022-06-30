using Avalonia.Web.Blazor;

namespace browser.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<browser.App>()
            .SetupWithSingleViewLifetime();
    }
}