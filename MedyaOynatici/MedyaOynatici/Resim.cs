using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedyaOynatici
{
public  class Resim : Player, IMediaPlayer2
    {
        public string RenkDagilimi { get; set; }
        public string ResmiCeken { get; set; }

        public string Goster(string dosyaUzantisi)
        {
            return ".jpg uzantili " + dosyaUzantisi + "resim dosyasi gosteriliyor...";
        }

        public string Kapat(string dosyaUzantisi)
        {
            return ".jpg uzantili " + dosyaUzantisi + "resim dosyasi kapatiliyor...";
        }

        public override string Cek()
        {
            return base.Cek();
        }
    }
}
