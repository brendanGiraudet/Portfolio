using Microsoft.AspNetCore.Components;

namespace Portfolio.App.Components.Experience;

public partial class Experience
{
    [Parameter] public Models.Experience ExperienceModel { get; set; }
}