using Blazorise;
using Microsoft.AspNetCore.Components;

namespace BlazoriseExamples.Pages
{
    public partial class ReferencingBlazoriseThemeValuesInCustomCss
    {
        [CascadingParameter] Theme Theme { get; set; }

        public ReferencingBlazoriseThemeValuesInCustomCss()
        {
            Theme ??= new Theme();
        }

        public void ChangeThemeColour()
        {
            var currentPrimaryValue = Theme.ColorOptions.Primary;
            var currentSecondaryValue = Theme.ColorOptions.Secondary;

            Theme.ColorOptions.Primary = currentSecondaryValue;
            Theme.ColorOptions.Secondary = currentPrimaryValue;

            Theme.ThemeHasChanged();
        }
    }
}
