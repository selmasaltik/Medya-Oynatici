using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedyaOynatici
{
public class Player : Media
    {
    public string Ad { get; set; }
    public float Boyut { get; set; }
    public DateTime OlusturmaTarihi { get; set; }
    public Resim resim { get; set; }
    public Video video { get; set; }

    public override string Cek()
    {
        return base.Cek();
    }
    }
}
