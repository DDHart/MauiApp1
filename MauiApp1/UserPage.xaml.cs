using MauiApp1.Models;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace MauiApp1;

public partial class UserPage : ContentPage
{
    User usr;
    public UserPage()
    {
        usr = new User()
        {
            Name = "New User",
            UsrPhoto = "animal1.jpeg",
            DateBirth = new DateTime(1900,1,1)
        };

        this.BindingContext = usr;
        InitializeComponent();
    }

    // site for reg ex:
    // https://regex101.com/
    private void CheckData(object sender, EventArgs e)
    {
        bool validOk = true;
        ValidMsg.Text = "Validating data ...";
        Regex rg;

        //age
        ValidAge.Text = string.Empty;
        if (usr.DateBirth.Year == 1900)
        {
            ValidAge.Text += "You must enter a valid DOB";
        }
        else
        {
            int age = DateTime.Now.AddYears(usr.DateBirth.Year * (-1)).Year;
            CalcAge.Text = "Your age: " + age;

            if (age < 18)
            {
                ValidAge.Text += "Sorry, you must be above 18.";
                validOk = false;
            }
        }
        /* old code if I get it from string ..
        ValidAge.Text = string.Empty;
        string dateOfB = usr.DateBirth==null?"no value":usr.DateBirth.ToString();
        rg = new(@"[0-3][0-9]/[0-1][0-9]/[0-9][0-9]");
        if (!rg.IsMatch(dateOfB))
            ValidAge.Text += "date of birth wrong format DD/MM/YY";
        else
        {
            DateTime enteredDate = DateTime.Parse(dateOfB);
            int age = DateTime.Now.Year - enteredDate.Year;
            ValidAge.Text += "date ok. your age is " + age;
            CalcAge.Text = "Your age: " + age;
            if (age < 18)
            {
                ValidAge.Text += "Sorry, you must be above 18.";
                validOk = false;
            }
                
        }
        */

        // user name - no spaces no digits
        usr.UserName = (usr.UserName == null ? "" : usr.UserName);
        //rg = new Regex(@"^[a-zA-Z].[a-zA-Z0-9]+$");
        rg = new Regex(@"[ \d]");  // regex to include spaces and/or digits
        ValidUserName.Text = "User name: " + usr.UserName;
        if ( !rg.IsMatch(usr.UserName))
        {
            ValidUserName.Text += ", User name is not valid (" + usr.UserName + ") - no spaces or digits allowed";
            validOk = false;
        }

        // Password - at least one capital AND one digit
        // or with RegEx:
        // (?=[A-Z])(?=.\d).+
        ValidPass.Text = "";
        usr.Password = (usr.Password == null ? "" : usr.Password);
        ValidPass.Text += "Password: " + usr.Password;
        char[] chars = usr.Password.ToCharArray();
        int dgcnt = 0, ltcnt = 0;
        foreach(char c in chars)
        {
            if (c >= '0' && c <= '9') dgcnt++;
            if (c >= 'A' && c <= 'Z') ltcnt++;
        }
        if (dgcnt == 0 || ltcnt == 0)
        {
            ValidPass.Text += ". Password is not valid (" + usr.Password + ") - at least one capital letter and a digit";
            validOk = false;
        }
        //return validOk;
    }
}