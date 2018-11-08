using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedyaOynatici
{
 public  class Video : Player, IMediaPlayer
    {
        public uint Sure { get; set; }
        public float ImdbPuani{ get; set; }
        public string VideoCeken { get; set; }
        public string Play(string dosyaUzantisi)
        {
            return ".mp4 uzantili " + dosyaUzantisi + "video dosyasi oynatiliyor...";
        }

        public string Stop(string dosyaUzantisi)
        {
            return ".mp4 uzantili " + dosyaUzantisi + "video dosyasi durduruluyor...";
        }

        public override string Cek()
        {
            return base.Cek();
        }
    }
}
