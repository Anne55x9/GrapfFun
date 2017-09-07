using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;




// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GrapfFun
{

    //Koden til grafen indsættes direkte i test1. 

    public class Student
    {
        /// <summary>
        /// To attributter til klassen student.
        /// </summary>
        public string SName { get; set; }

        public int Marks { get; set; }

        public int Marks2 { get; set; }


        public Student()
        {

        }

    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            GetChartData();
            GetChartData2();


        }


        private void GetChartData()
        {
            List<Student> student = new List<Student>();
            student.Add(new Student()
            {
                SName = "Anders And",
                Marks = 10
            });

            student.Add(new Student()
            {
                SName = "Mule",
                Marks = 7
            });

            student.Add(new Student()
            {
                SName = "Rip",
                Marks = 12
            });

            student.Add(new Student()
            {
                SName = "Helle",
                Marks = 4
            });



           (LineChart.Series[0] as LineSeries).ItemsSource = student;
            

        }

        private void GetChartData2()
        {
            List<Student> student1 = new List<Student>();
            student1.Add(new Student()
            {
                SName = "Anders And",
                Marks2 = 2
            });

            student1.Add(new Student()
            {
                SName = "Mule",
                Marks2 = 12
            });

            student1.Add(new Student()
            {
                SName = "Rip",
                Marks2 = 4
            });

            student1.Add(new Student()
            {
                SName = "Helle",
                Marks2 = 12
            });



            (LineChart.Series[1] as LineSeries).ItemsSource = student1;


        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

    }
}
