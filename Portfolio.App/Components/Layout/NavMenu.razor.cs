using Microsoft.AspNetCore.Components;

namespace Portfolio.App.Components.Layout;

public partial class NavMenu
{
    private string _applicationVersion = string.Empty;

    private bool _hidden = true;

    private string _hiddenClass => _hidden ? "hidden": string.Empty;

    [Inject] public IConfiguration? Configuration { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        _applicationVersion = Configuration?["ApplicationVersion"] ?? "1.0.0";
    }

    private void Toogle() => _hidden = !_hidden;
}