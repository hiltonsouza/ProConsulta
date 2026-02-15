namespace ProConsulta.Services;

public class ThemeService
{
    public bool IsDarkMode { get; private set; } = true;

    public event Action? OnChange;

    public void ToggleTheme()
    {
        IsDarkMode = !IsDarkMode;
        OnChange?.Invoke();
    }

}