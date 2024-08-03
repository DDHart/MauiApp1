using MauiApp1.Models;

namespace MauiApp1;

public partial class AnimalPage : ContentPage
{
	public AnimalPage()
	{
		Animal myAnim = new Animal("Nemo");
		InitializeComponent();

		this.BindingContext = myAnim;

	}

	private void Buttom_Clicked(object sender, EventArgs e)
	{
		//this.myAnim.Name = "Dori";
	}
} 