using Blazorise;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazoriseExamples.Pages
{
    public partial class ReferencingBlazoriseThemeValuesInCustomCss
    {
        [CascadingParameter] Theme Theme { get; set; }

        readonly Random random = new();

        public ReferencingBlazoriseThemeValuesInCustomCss()
        {
            Theme ??= new Theme();
        }

        public void ChangeThemeColour()
        {
            //https://stackoverflow.com/a/730658
            Theme.ColorOptions.Primary = string.Format("#{0:X6}", random.Next(0x1000000));

            Theme.ThemeHasChanged();
        }
    }
}
