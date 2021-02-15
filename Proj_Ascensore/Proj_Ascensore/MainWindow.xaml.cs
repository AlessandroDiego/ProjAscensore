using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace Proj_Ascensore
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriAscensore = new Uri("Ascensore.png", UriKind.Relative);
        public int posVerticaleAscensore = 600;
        public int posOrizzontaleAscensore = 294;
        public int posizioneQuarta = 0;
        public Thread t1;
        Random r1 = new Random();


        public MainWindow()
        {
            InitializeComponent();
            ImageSource imm1 = new BitmapImage(uriAscensore);
            Ascensore_1.Source = imm1;

        }

        private void BTN_Terra_Click(object sender, RoutedEventArgs e)
        {
            t1= new Thread(new ThreadStart(PianoTerra));
            t1.Start();
            Wait();

        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            t1 = new Thread(new ThreadStart(Piano1));
            t1.Start();
            Wait();
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
             t1 = new Thread(new ThreadStart(Piano2));
            t1.Start();
            Wait();
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            t1 = new Thread(new ThreadStart(Piano3));
            t1.Start();
            Wait();
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
             t1 = new Thread(new ThreadStart(Piano4));
            t1.Start();
            Wait();
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            t1 = new Thread(new ThreadStart(Piano5));
            t1.Start();
            Wait();
        }

        public void PianoTerra()
        {
            while (posVerticaleAscensore > 600)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);

                }));

            }
            
        }

        public void Piano1()
        {
            while (posVerticaleAscensore > 490)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                   
                }));
                
            }
           

        }
        public void Piano2()
        {
            while (posVerticaleAscensore > 372)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);

                }));

            }
           
        }
        public void Piano3()
        {
            while (posVerticaleAscensore > 246)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);

                }));

            }
           
        }
        public void Piano4()
        {
            while (posVerticaleAscensore > 132)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);

                }));

            }
            


        }
        public void Piano5()
        {
            while (posVerticaleAscensore > 0)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);

                }));

            }
            
           
        }

        public void Wait()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            posVerticaleAscensore = 600;
            posOrizzontaleAscensore = 294;
            posizioneQuarta = 0;
        }



    }
}
