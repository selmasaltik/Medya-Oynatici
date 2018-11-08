using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedyaOynatici
{
public abstract class Media
    {
        public string MediaTuru { get; set; }

        public virtual string Cek()
        {
            return "Cek... " + this.MediaTuru;
        }
    }
}
