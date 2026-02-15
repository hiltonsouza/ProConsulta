using MudBlazor;

namespace ProConsulta.Components.Theme;

public static class CustomTheme
{
    public static MudTheme Default = new MudTheme()
    {
        PaletteLight = new PaletteLight()
        {
            Primary = "#5C5EF0",           // Roxo/Azul do botão
            Secondary = "#64748B",         // Cinza dos textos secundários
            Background = "#F6F6F8",        // Fundo claro
            Surface = "#FFFFFF",           // Fundo do Card claro
            TextPrimary = "#0F172A",       // Texto principal
            LinesInputs = "#E2E8F0",       // Bordas dos inputs
            AppbarBackground = "#FFFFFF"
        },
        PaletteDark = new PaletteDark()
        {
            Primary = "#5C5EF0",
            Secondary = "#94A3B8",
            Background = "#111121",        // Fundo escuro (Navy profundo)
            Surface = "#151925",           // Fundo do Card escuro
            TextPrimary = "#F8FAFC",
            LinesInputs = "#2D3348",       // Bordas sutis no escuro
            AppbarBackground = "#151925"
        },

        LayoutProperties = new LayoutProperties()
        {
            DefaultBorderRadius = "8px"    // Rounded-lg do Tailwind
        },

         Typography = new Typography()
        {
            Default = new DefaultTypography()
            {
                FontFamily = new[] { "Plus Jakarta Sans", "Roboto", "sans-serif" },
            },
         },
    };
}
