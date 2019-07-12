using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzantinesApp.Classes
{
    public class Meses
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public static List<Meses> GetMeses()
        {
            List<Meses> misMeses = new List<Meses>();

            misMeses.Add(new Meses() { Value = 1, Text = "Enero"});
            misMeses.Add(new Meses() { Value = 2, Text = "Febrero" });
            misMeses.Add(new Meses() { Value = 3, Text = "Marzo" });
            misMeses.Add(new Meses() { Value = 4, Text = "Abril" });
            misMeses.Add(new Meses() { Value = 5, Text = "Mayo" });
            misMeses.Add(new Meses() { Value = 6, Text = "Junio" });
            misMeses.Add(new Meses() { Value = 7, Text = "Julio" });
            misMeses.Add(new Meses() { Value = 8, Text = "Agosto" });
            misMeses.Add(new Meses() { Value = 9, Text = "Septiembre" });
            misMeses.Add(new Meses() { Value = 10, Text = "Octubre" });
            misMeses.Add(new Meses() { Value = 11, Text = "Noviembre" });
            misMeses.Add(new Meses() { Value = 12, Text = "Diciembre" });

            return misMeses;
        }
    }
}
