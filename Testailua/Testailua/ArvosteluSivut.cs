using System;
using System.Collections.Generic;
using System.Text;

namespace Testailua
{
    public static class ArvosteluSivut
    {
        private static int Ekasivu = 1;
        private static int TokaSivu = 1;
        private static int KolmasSivu = 1;

        public static int Ekasivu1 { get => Ekasivu; set => Ekasivu = value; }
        public static int TokaSivu1 { get => TokaSivu; set => TokaSivu = value; }
        public static int KolmasSivu1 { get => KolmasSivu; set => KolmasSivu = value; }
    }
}
