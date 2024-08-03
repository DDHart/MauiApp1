using MauiApp1.Models;

namespace MauiApp1;

public partial class UserPage : ContentPage
{
    User usr;
    public UserPage()
    {
        usr = new User()
        {
            Name = "New User",
            UsrPhoto = "animal1.jpeg"
        };

        this.BindingContext = usr;
        InitializeComponent();
    }
}