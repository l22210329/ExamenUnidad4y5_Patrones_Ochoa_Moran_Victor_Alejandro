using Microsoft.Extensions.DependencyInjection;

namespace EXAMEN_4_Y_5_Unidad;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}