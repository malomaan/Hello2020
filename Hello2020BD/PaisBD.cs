using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2020BD
{
    public class PaisBD
    {
        DaneDivipolaEntities BD = new DaneDivipolaEntities();

        private List<Pais> Pais_List()
        {
            return BD.Pais.ToList();
        }

        private void Pais_Inser(Pais pais)
        {
            BD.Pais.Add(pais);
            BD.SaveChanges();
        }


    }
}
