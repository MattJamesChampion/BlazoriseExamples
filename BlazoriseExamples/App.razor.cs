using Blazorise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoriseExamples
{
    public partial class App
    {
        Theme Theme { get; set; }

        public App()
        {
            //Theme values copied from https://blazorise.com/docs/theming/

            Theme = new Theme
            {
                ColorOptions = new ThemeColorOptions
                {
                    Primary = "#45B1E8",
                    Secondary = "#A65529",
                }
            };
        }
    }
}
