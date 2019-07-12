using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManzantinesApp.Classes
{
    public class Anios
    {
        public int Value { get; set; }

        public static List<Anios> GetAnios(int anio)
        {
            List<Anios> misAnios = new List<Anios>();

            misAnios.Add(new Anios { Value = anio - 4});
            misAnios.Add(new Anios { Value = anio - 3 });
            misAnios.Add(new Anios { Value = anio - 2 });
            misAnios.Add(new Anios { Value = anio - 1 });
            misAnios.Add(new Anios { Value = anio });
            misAnios.Add(new Anios { Value = anio + 1 });
            misAnios.Add(new Anios { Value = anio + 2 });
            misAnios.Add(new Anios { Value = anio + 3 });
            misAnios.Add(new Anios { Value = anio + 4 });

            return misAnios;
        }
    }
}
