using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Runtime.CompilerServices;

namespace ProConsulta.Components.Layout;

/// <summary>
/// Code-behind para o layout principal. 
/// Gerencia o estado visual e a persistência de preferências do usuário.
/// </summary>
public partial class MainLayout : LayoutComponentBase
{
    [Inject]
    protected NavigationManager NavigationManager { get; set; }
    private MudThemeProvider _mudThemeProvider;

}
