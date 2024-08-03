

using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1;

public partial class CodeBehindPage : ContentPage
{
    VerticalStackLayout mainLayout;
	public CodeBehindPage()
	{
		InitializeComponent();
        BuildUI();
	}
    
    private void BuildUI()
    {
        // main content
        mainLayout = new VerticalStackLayout() { BackgroundColor = Colors.Yellow };
        // main title
        AddTitlePage();
        AddButtonToPage();
        this.Content = mainLayout;
    }

    private void AddButtonToPage()
    {
        Button btn = new Button()
        {
            Text = "Press Me",
            WidthRequest = 120
        };

        btn.Clicked += ClickBtnEvent;
        mainLayout.Children.Add(btn);
    }

    private void ClickBtnEvent (object sender, EventArgs e)
    {

    }

    private void AddTitlePage()
    {
        Label title = new Label()
        {
            Text = "Hello, I LOVE Animals!",
            FontAttributes = FontAttributes.Bold,
            FontFamily = "RubikDoodle",
            FontSize = 24,
            HorizontalTextAlignment = TextAlignment.Center
        };
        mainLayout.Children.Add(title);
    }
    
}