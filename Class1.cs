using System.Collections.Generic;

namespace Ezednevnik
{
    public class TheNote
    {
        public int Data;
        public int Mesyats = 10;
        public string Name;
        public string Podrobno;
        public int Nomer;
        public static List<TheNote> zametka = new List<TheNote>();
    }
}
