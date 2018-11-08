using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedyaOynatici
{
 public interface IMediaPlayer
    {
     string Play(string dosyaUzantisi);
     string Stop(string dosyaUzantisi);
    }
}
