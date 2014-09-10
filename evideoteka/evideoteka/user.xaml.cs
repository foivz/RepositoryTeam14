using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace evideoteka
{
    /// <summary>
    /// Interaction logic for user.xaml
    /// </summary>
    public partial class user : Window
    {
        AxAXVLC.AxVLCPlugin2 vlcPlayer = new AxAXVLC.AxVLCPlugin2();
        String path;
        //Thread th;
        public user(String s)
        {
            InitializeComponent();
            
            wh1.Child = vlcPlayer;
            path = s;
            this.Closed += new EventHandler(user_Closed);
          //  th = new Thread(new ThreadStart(playMovie));
        }

        private void user_Closed(object sender, EventArgs e)
        {
            vlcPlayer.playlist.items.clear();
            MessageBox.Show("dasdsa");
            
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
           // th.Start();
            String playURL = completeString(path);
            MessageBox.Show(playURL);
            vlcPlayer.playlist.add(playURL);

            MessageBox.Show(vlcPlayer.input.Time.ToString());
            // MessageBox.Show(vlcPlayer..ToString());
            vlcPlayer.playlist.play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(vlcPlayer.input.Time.ToString());
            MessageBox.Show(vlcPlayer.input.Length.ToString());
            MessageBox.Show(vlcPlayer.input.Position.ToString());

        }
        /// <summary>
        /// Funkcija za kreiranje putanje filma koja je zapisana u bazi 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private string completeString(String c)
        {
            String aa = "";
            String toReturn = "file:///";
            for (int i = 0; i < c.Length; i++)
            {
                aa += c[i];
                if (c[i] == '\\' && c[i + 1] != '\\')
                {
                    aa += "\\";

                }

            }
            return toReturn + aa;
        }

       /* private void playMovie()
        {
            String playURL = completeString(path);
            MessageBox.Show(playURL);
            vlcPlayer.playlist.add(playURL);

            MessageBox.Show(vlcPlayer.input.Time.ToString());
            // MessageBox.Show(vlcPlayer..ToString());
            vlcPlayer.playlist.play();
        }*/
    }
}
