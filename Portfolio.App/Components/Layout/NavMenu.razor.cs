using Microsoft.AspNetCore.Components;

namespace Portfolio.App.Components.Layout;

public partial class NavMenu
{
    private string _applicationVersion = string.Empty;

    [Inject] public IConfiguration? Configuration { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _applicationVersion = Configuration?["ApplicationVersion"] ?? "1.0.0";
    }
}