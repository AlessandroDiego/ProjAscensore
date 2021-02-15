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
        public Thread ThreadAndata;
        public Thread ThreadRitorno;
        Random r1 = new Random();



        public MainWindow()
        {
            InitializeComponent();
            ImageSource imm1 = new BitmapImage(uriAscensore);
            Ascensore_1.Source = imm1;

        }

        private void BTN_Terra_Click(object sender, RoutedEventArgs e)
        {
            SpegniBottoni();
            ThreadAndata = new Thread(new ThreadStart(PianoTerra));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadAndata.Start();
            


        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            SpegniBottoni();
            ThreadAndata = new Thread(new ThreadStart(Piano1));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadAndata.Start();
            
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            SpegniBottoni();
            ThreadAndata = new Thread(new ThreadStart(Piano2));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadAndata.Start();
            

        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            SpegniBottoni();
            ThreadAndata = new Thread(new ThreadStart(Piano3));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadAndata.Start();
            
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            SpegniBottoni();
            ThreadAndata = new Thread(new ThreadStart(Piano4));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadAndata.Start();
            

        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            SpegniBottoni();
            ThreadAndata = new Thread(new ThreadStart(Piano5));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadAndata.Start();
            
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
            Thread.Sleep(TimeSpan.FromMilliseconds(3000));
            ThreadRitorno.Start();

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
            Thread.Sleep(TimeSpan.FromMilliseconds(3000));
            ThreadRitorno.Start();
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
            Thread.Sleep(TimeSpan.FromMilliseconds(3000));
            ThreadRitorno.Start();
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
            Thread.Sleep(TimeSpan.FromMilliseconds(3000));
            ThreadRitorno.Start();
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
            Thread.Sleep(TimeSpan.FromMilliseconds(3000));
            ThreadRitorno.Start();
        }

        public void Ritorno()
        {
            while (posVerticaleAscensore <= 600)
            {
                posVerticaleAscensore += 10;
                posizioneQuarta -= 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);

                }));
            }
        }

        public void SpegniBottoni()
        {
            BTN_Terra.IsEnabled = false;
            BTN_1.IsEnabled = false;
            BTN_2.IsEnabled = false;
            BTN_3.IsEnabled = false;
            BTN_4.IsEnabled = false;
            BTN_5.IsEnabled = false;
        }
        public void AccendiBottoni()
        {
            BTN_Terra.IsEnabled = true;
            BTN_1.IsEnabled = true;
            BTN_2.IsEnabled = true;
            BTN_3.IsEnabled = true;
            BTN_4.IsEnabled = true;
            BTN_5.IsEnabled = true;
        }

        private void Btn_Ritornato_Click(object sender, RoutedEventArgs e)
        {
            if (posVerticaleAscensore >= 600)
            {
                AccendiBottoni();
            }
            else
            {
                MessageBox.Show("L'ascensore non è ancora tornato al piano terra");
            }
        }
    }
}
