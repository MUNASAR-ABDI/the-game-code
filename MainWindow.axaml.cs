using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace MyApp2
{
    public partial class MainWindow : Window
    {
            public readonly int randNum; //i set this int to readonly
          public readonly TextBox guesTxt_box;//its guessing text box
           private readonly TextBlock resultTxt;
             public MainWindow()
        {
            InitializeComponent();
            randNum = new Random().Next(10, 31); //i added 20+1=21

             guesTxt_box = this.FindControl<TextBox>("GssTxtBx");//the geussing text box
         resultTxt = this.FindControl<TextBlock>("Resulttext");//the result box
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnGuessButtonClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(guesTxt_box.Text, out int guess))
            {
                if (guess == randNum)
                {
                    resultTxt.Text = "you are correct :) the number was " + randNum;
                }

               else if(guess>randNum){
                    resultTxt.Text = "your number is higher than your obtions ";
                }
                else if(guess<randNum){
                    resultTxt.Text = "your number is less than your obtions ";
                }
                // i added this part to use it to know the value easier OR when i have more numbers.


                else
                {
                    resultTxt.Text = "no :(  its a wrong number. Try again.";
                }
            }
            else
            {
                resultTxt.Text = "its not a valid obtion, please put an integer.";
            }
        }
    }
}
