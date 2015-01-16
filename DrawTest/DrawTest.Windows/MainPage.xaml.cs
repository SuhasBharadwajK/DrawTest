using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DrawTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public delegate void hand(object sender, TappedRoutedEventArgs e);

        TextBlock txtTest = new TextBlock();
        Rectangle blueRectangle = new Rectangle();
        DoubleAnimation myAnim = new DoubleAnimation();
        Storyboard mySb = new Storyboard();

        public void meth(object sender, TappedRoutedEventArgs e)
        {
            sb.Begin();
        }

        //hand hndlr = meth;

        public MainPage()
        {
            this.InitializeComponent();
            //sb.Begin();

            
            blueRectangle.Height = 107;
            blueRectangle.Width = 111;
            blueRectangle.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left;
            blueRectangle.Fill = new SolidColorBrush(Colors.Blue);
            blueRectangle.Name = "blueRectangle";

            myAnim.From = 200;
            myAnim.To = 400;
            myAnim.Duration = new Duration(TimeSpan.FromSeconds(1));
            Storyboard.SetTargetName(myAnim, blueRectangle.Name);
            //Storyboard.SetTargetProperty(myAnim, new PropertyPath(Rectangle.WidthProperty));
            mySb.Equals(sb1);

           
            txtTest.Text = "Suhas Mofos!";
            txtTest.FontSize = 18;
            Canvas.SetZIndex(txtTest, -10);
            //myCanvas.Children.Add(blueRectangle);
            //myCanvas.Children.Add(txtTest);
            myCanvas.Children.Add(blueRectangle);
            myCanvas.Children.Add(txtTest);


            //hand hndlr = meth;
            blueRectangle.Tapped += delegate(object sender, TappedRoutedEventArgs e)
            {
                sb1.Begin();
                txtTest.Text = Canvas.GetLeft(testRekt).ToString() + ", " + Canvas.GetTop(testRekt).ToString();
            };
            //new System.EventHandler(this.tapRekt);
            //Canvas can = new Canvas();
            //can.Height = 600;
            //can.Width = 600;
            ////drawEllipse(can);
            //Ellipse newEllipse = new Ellipse();
            //newEllipse.Width = 400;
            //newEllipse.Height = 400;
            //newEllipse.Fill = new SolidColorBrush(Colors.Aquamarine);
            //can.Children.Add(newEllipse);
            ////newEllipse.SetValue(Canvas.LeftProperty, aCanvas.ActualWidth / 2.0);
            ////newEllipse.SetValue(Canvas.TopProperty, aCanvas.ActualHeight / 2.0);
            //Canvas.SetLeft(newEllipse, can.ActualWidth / 2.0);
            //Canvas.SetTop(newEllipse, can.ActualHeight / 2.0);
        }

        //private Ellipse drawEllipse(Canvas aCanvas)
        //{
        //    Ellipse newEllipse = new Ellipse();
        //    newEllipse.Width = 40;
        //    newEllipse.Height = 40;
        //    newEllipse.Fill = new SolidColorBrush(Colors.Aquamarine);
        //    aCanvas.Children.Add(newEllipse);
        //    //newEllipse.SetValue(Canvas.LeftProperty, aCanvas.ActualWidth / 2.0);
        //    //newEllipse.SetValue(Canvas.TopProperty, aCanvas.ActualHeight / 2.0);
        //    Canvas.SetLeft(newEllipse, aCanvas.ActualWidth / 2.0);
        //    Canvas.SetTop(newEllipse, aCanvas.ActualHeight / 2.0);

        //    return newEllipse;
        //}

        private void Rekt_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            //sb.Begin();
        }

        private void Rekt_Tapped(object sender, TappedRoutedEventArgs e)
        {
            txtTest.Text = "Something";
            sb.Begin();
            //Canvas.SetLeft(Rekt, 400);
            //Canvas.SetTop(Rekt, 900);
            //Grid.SetColumn(Rekt, 400);
            //Grid.SetRow(Rekt, 900);
            Canvas.SetLeft(blueRectangle, 600);
            Canvas.SetTop(blueRectangle, 400);
            Canvas.SetZIndex(Rekt, -850);
            //mySb.Begin();
            //myCanvas.Children.Add(blueRectangle);
            
        }

        //private void tapRekt(object sender, TappedRoutedEventArgs e)
        //{
        //    sb1.Begin();          
        //}

    }
}
