using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedyaOynatici
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            Resim r = new Resim();
            r.Ad = "Yıldızlı Gece";
            r.Boyut = 148;
            r.OlusturmaTarihi = "24.06.1889";
            r.RenkDagilimi = "Yoğun Mavi";
            r.ResmiCeken = "Vincent van Gogh";
            MessageBox.Show("Resim Adı: " + r.Ad + "\nResmi Çeken: " + r.ResmiCeken +
                             "\nOluşturma Tarihi: " + r.OlusturmaTarihi + "\nResim Boyut: " + r.Boyut +
                             "\nResim Renk Dağılımı: " + r.RenkDagilimi);
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Video v = new Video();
            v.Ad = "Nothing Else Matters";
            v.Boyut = 358;
            v.OlusturmaTarihi = "25.02.1991";
            v.Sure = 6;
            v.ImdbPuani = 9;
            v.VideoCeken = "Metallica";
            MessageBox.Show("Video Adı: " + v.Ad + "\nVideo Çeken: " + v.VideoCeken +
                             "\nOluşturma Tarihi: " + v.OlusturmaTarihi + "\nVideo Süre: "
                             + v.Sure + "\nVideo Boyut: " + v.Boyut + "\nVideo Imdb Puanı: " + v.ImdbPuani);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Resim r = new Resim();
            r.Play();

            Video v = new Video();
            v.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Resim r = new Resim();
            r.Stop();

            Video v = new Video();
            v.Stop();
        }

        
    }
}
