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
        //Ascensore
        readonly Uri uriAscensore = new Uri("Ascensore.png", UriKind.Relative);
        public int posVerticaleAscensore = 600;
        public int posizioneQuarta = 0;
        public Thread ThreadAndata;
        public Thread ThreadRitorno;
        //

        //Uomo
        readonly Uri uriUomo = new Uri("Uomo.png", UriKind.Relative);
        public int posOrizz1 = 374;
        public int posTerza1 = 1018;
        public int posQuarta1 = 10;
        public int posVerticale1 = 639;
        public Thread TEntrata1;
        public Thread TUscita1;
        int i = 0;
        //

        //Donna
        readonly Uri uriDonna = new Uri("Donna.png", UriKind.Relative);
        public int posOrizz2 = 351;
        public int posVerticale2 = 269;
        public int posTerza2 = 1004;
        public int posQuarta2 = 371;

        //


        public MainWindow()
        {
            InitializeComponent();
            SpegniBottoni();
            ImageSource imm1 = new BitmapImage(uriAscensore);
            Ascensore_1.Source = imm1;
            ImageSource imm2 = new BitmapImage(uriUomo);
            Uomo.Source = imm2;
            ImageSource imm3 = new BitmapImage(uriDonna);
            Donna.Source = imm3;
        }

        //MANUALE

        // ASCENSORE E MOVIMENTO PERSONE DENTRO
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
        private void Btn_Ritornato_Click(object sender, RoutedEventArgs e)
        {
            Btn_Ritornato.IsEnabled = false;
            if (posVerticaleAscensore >= 600)
            {
                AccendiBottoni();
            }
            else
            {
                MessageBox.Show("L'ascensore non è ancora tornato al piano terra");
            }
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
                posQuarta1 += 10;
                posVerticale1 -= 10;
                posQuarta2 += 10;
                posVerticale2 -= 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                    if (i == 0)
                    {
                        Uomo.Margin = new Thickness(posOrizz1, posVerticale1, posTerza1, posQuarta1);
                    }
                    if (i == 2)
                    {
                        Donna.Margin = new Thickness(294, (posVerticale2+350), 1061, (posQuarta2-350));
                    }

                }));
                
            }
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            TUscita1.Start();

        }
        public void Piano2()
        {
            while (posVerticaleAscensore > 372)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                posQuarta1 += 10;
                posVerticale1 -= 10;
                posQuarta2 += 10;
                posVerticale2 -= 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                    if (i == 0)
                    {
                        Uomo.Margin = new Thickness(posOrizz1, posVerticale1, posTerza1, posQuarta1);
                    }
                    if (i == 2)
                    {
                        Donna.Margin = new Thickness(294,(posVerticale2+350), 1061, (posQuarta2-350) );
                    }
                }));

            }
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            TUscita1.Start();
        }
        public void Piano3()
        {
           
            while (posVerticaleAscensore > 246)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                posQuarta1 += 10;
                posVerticale1 -= 10;
                posQuarta2 += 10;
                posVerticale2 -= 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                    if (i == 0)
                    {
                        Uomo.Margin = new Thickness(posOrizz1, posVerticale1, posTerza1, posQuarta1);
                    }
                    if (i == 2)
                    {
                        Donna.Margin = new Thickness(294, (posVerticale2+350), 1061,(posQuarta2-350));
                    }
                }));

            }
            if (i == 0)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                TUscita1 = new Thread(new ThreadStart(Esce1));
                TUscita1.Start();
            }
            else if (i == 1 || j==22)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                TEntrata1 = new Thread(new ThreadStart(MovimentoDonna));
                TEntrata1.Start();
            }
  
        }
        public void Piano4()
        {
            while (posVerticaleAscensore > 132)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                posQuarta1 += 10;
                posVerticale1 -= 10;
                posQuarta2 += 10;
                posVerticale2 -= 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                    if (i == 0)
                    {
                        Uomo.Margin = new Thickness(posOrizz1, posVerticale1, posTerza1, posQuarta1);
                    }
                    if (i == 2)
                    {
                        Donna.Margin = new Thickness(294,(posVerticale2 + 350), 1061, (posQuarta2-350));
                    }

                }));

            }
            Thread.Sleep(TimeSpan.FromMilliseconds(1000));
            TUscita1.Start();
        }
        public void Piano5()
        {
            while (posVerticaleAscensore > 0)
            {
                posVerticaleAscensore -= 10;
                posizioneQuarta += 10;
                posQuarta1 += 10;
                posVerticale1 -= 10;
                posQuarta2 += 10;
                posVerticale2 -= 10;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                    if (i == 0)
                    {
                        Uomo.Margin = new Thickness(posOrizz1, posVerticale1, posTerza1, posQuarta1);
                    }
                    if (i == 2)
                    {
                        Donna.Margin = new Thickness(294, (posVerticale2 + 350), 1061,(posQuarta2-350));
                    }

                }));

            }
                Thread.Sleep(TimeSpan.FromMilliseconds(1000));
                TUscita1.Start();
        }

        public void Ritorno()
        {
            i++;
            while (posVerticaleAscensore <= 600)
            {
                posVerticaleAscensore += 10;
                posizioneQuarta -= 10;
                posQuarta2 -= 10;
                posVerticale2 += 10;
                
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Ascensore_1.Margin = new Thickness(294, posVerticaleAscensore, 1049, posizioneQuarta);
                    if (i == 2)
                    {
                        Donna.Margin = new Thickness(294,(posVerticale2+350),1061,(posQuarta2-350));
                    }
                   
                }));
            }
            if (j == 22)
            {
                i = 2;
                int piano = rnd.Next(1, 6);
                switch (piano)
                {
                    case 1:
                        TUscita1 = new Thread(new ThreadStart(Esce2));
                        ThreadAndata = new Thread(new ThreadStart(Piano1));
                        ThreadAndata.Start();
                        break;
                    case 2:
                        TUscita1 = new Thread(new ThreadStart(Esce2));
                        ThreadAndata = new Thread(new ThreadStart(Piano2));
                        ThreadAndata.Start();
                        break;
                    case 3:
                        TUscita1 = new Thread(new ThreadStart(Esce2));
                        ThreadAndata = new Thread(new ThreadStart(Piano3));
                        ThreadAndata.Start();
                        break;
                    case 4:
                        TUscita1 = new Thread(new ThreadStart(Esce2));
                        ThreadAndata = new Thread(new ThreadStart(Piano4));
                        ThreadAndata.Start();
                        break;
                    case 5:
                        TUscita1 = new Thread(new ThreadStart(Esce2));
                        ThreadAndata = new Thread(new ThreadStart(Piano5));
                        ThreadAndata.Start();
                        break;
                }

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

            if (i == 2)
            {
                BTN_3.IsEnabled = false;
            }
        }
        //

        //UOMO

        private void Btn_PrimaPersona_Click(object sender, RoutedEventArgs e)
        {
            AccendiBottoni();
            Btn_PrimaPersona.IsEnabled = false;
            TEntrata1 = new Thread(new ThreadStart(MovimentoUomo));
            TUscita1 = new Thread(new ThreadStart(Esce1));
            TEntrata1.Start();
        }
        public void MovimentoUomo()
        {
            while (posOrizz1 > 318)
            {
                posOrizz1 -= 2;
                posTerza1 += 2;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                   Uomo.Margin = new Thickness(posOrizz1, 639, posTerza1, 10);

                }));

            }
            
        }

        public void Esce1()
        {
            while (posOrizz1 > 230)
            {
                posOrizz1 -= 2;
                posTerza1 += 2;

                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                     Uomo.Margin = new Thickness(posOrizz1, posVerticale1, posTerza1, posQuarta1);
                    
                }));

            }

            Thread.Sleep(TimeSpan.FromMilliseconds(1));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadRitorno.Start();
        }
        //

        //DONNA
        private void BTN_SecondaPersona_Click(object sender, RoutedEventArgs e)
        {
            BTN_SecondaPersona.IsEnabled = false;
            if (i == 1 )
            {
                ThreadAndata = new Thread(new ThreadStart(Piano3));
                TUscita1 = new Thread(new ThreadStart(Esce2));
                ThreadAndata.Start();
            }
            else
            {
                MessageBox.Show("la prima persona non ha ancora finito il suo percorso");
            }
        }

        public void MovimentoDonna()
        {
            while (posOrizz2 > 290 )
            {
                posOrizz2 -= 2;
                posTerza2 += 2;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Donna.Margin = new Thickness(posOrizz2,269, posTerza2, 371);

                }));

            }

            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadRitorno.Start();
        }

        public void Esce2()
        {
            while (posOrizz2 > 230)
            {
                posOrizz2 -= 2;
                posTerza2 += 2;

                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Donna.Margin = new Thickness(posOrizz2,(posVerticale2+350), posTerza2,(posQuarta2-350));

                }));

            }

            Thread.Sleep(TimeSpan.FromMilliseconds(1));
            ThreadRitorno = new Thread(new ThreadStart(Ritorno));
            ThreadRitorno.Start();
        }

        //AUTOMATICO

        public Thread tUomo;
        public Thread tDonna;
        public Semaphore Semaforo = new Semaphore(0, 1);
        public Random rnd = new Random();
        public int j = 0;
        
        private void BTN_MovAuto_Click(object sender, RoutedEventArgs e)
        {
          
            BTN_MovAuto.IsEnabled = false;
            tUomo = new Thread(new ThreadStart(MovimentoAutoUomo));
           
            
            tUomo.Start();

        }


        public void MovimentoAutoUomo()
        {
           
            while (posOrizz1 > 318)
            {
                posOrizz1 -= 2;
                posTerza1 += 2;
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    Uomo.Margin = new Thickness(posOrizz1, 639, posTerza1, 10);

                }));

            }

                i = 0;
                int piano = rnd.Next(1, 6);
                switch (piano)
                {
                    case 1:
                        TUscita1 = new Thread(new ThreadStart(Esce1));
                        ThreadAndata = new Thread(new ThreadStart(Piano1));
                        ThreadAndata.Start();
                        break;
                    case 2:
                        TUscita1 = new Thread(new ThreadStart(Esce1));
                        ThreadAndata = new Thread(new ThreadStart(Piano2));
                        ThreadAndata.Start();
                        break;
                    case 3:
                        TUscita1 = new Thread(new ThreadStart(Esce1));
                        ThreadAndata = new Thread(new ThreadStart(Piano3));
                        ThreadAndata.Start();
                        break;
                    case 4:
                        TUscita1 = new Thread(new ThreadStart(Esce1));
                        ThreadAndata = new Thread(new ThreadStart(Piano4));
                        ThreadAndata.Start();
                        break;
                    case 5:
                        TUscita1 = new Thread(new ThreadStart(Esce1));
                        ThreadAndata = new Thread(new ThreadStart(Piano5));
                        ThreadAndata.Start();
                        break;
                }
        
        }
        
    }
}
