using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne_2___Polymorfi___override
{

    internal class Patient
    {
        string cprNummer;
        string fornavn;
        string efternavn;
        byte alder;

        public void patient() {
            Console.WriteLine($"CPR: {cprNummer}\nfornavn: {fornavn}\nefternavn: {efternavn}\nalder: {alder}\n");
        }
        public void patient(String fornavn, String efternavn)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
        }
        public void patient(byte alder)
        {
            this.alder = alder;
        }


    }

    internal static class lommeregner {
        public static int sumAfToTal(int a, int b)
        {
            return a + b;
        }
        public static float sumAfToTal(float a, float b)
        {
            return a + b;
        }

        /* virker ikke da den tager samme paremeter og type som overstaaende i pareneter feltet
        public static int sumAfToTal(float a, float b)
        {
            float temp = a + b;
            return Convert.ToInt32(temp);
        }
        */
    }

    internal static class myoverload
    {
        public static void toTry()
        {
            var patient = new Patient();
            patient.patient();
            patient.patient("Jim", "Damgaard");
            patient.patient();
            patient.patient(29);
            patient.patient();

            int output = lommeregner.sumAfToTal(3, 6);
            Console.WriteLine(output);

            float input = 3;
            float input2 = 5;
            float output2 = lommeregner.sumAfToTal(input , input2);
            Console.WriteLine(output2);
        }
    }

}
