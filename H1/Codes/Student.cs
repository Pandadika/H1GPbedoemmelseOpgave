using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Codes
{
    internal record Student
    {
        public int ElevId { get; set; }
        public int Telefonnummer { get; set; }
        public string? ForNavn { get; set; }
        public string? EfterNavn { get; set; }

        public Student(int elevId, int telefonnummer, string forNavn,string efterNavn)
        {
            ElevId = elevId;
            Telefonnummer = telefonnummer;
            ForNavn = forNavn;  
            EfterNavn = efterNavn;
        }
    }
}
