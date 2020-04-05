using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello2020BD;

namespace Hello2020PRC
{
    public class PaisBD
    {
        PaisBD BD = new PaisBD();

        public List<Pais> Pais_List()
        {
            return BD.Pais_List();
        }
    }
}
