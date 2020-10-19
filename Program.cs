using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists_vs_Lists_vs_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //array, inmutable: Größe unveränderbar, nicht erweitbar, Limitiert auf einen Datentyp;
            int[] scores = new int[] { 99, 54, 62, 10 };
            // scores. //um die ganze Methoden zu sehen
            // scores.Resize könnte die Größe doch ändern aber  
            // was die Methode Array.Resize(...,...) macht ist, 
            // dass es die Werte aus dem Quell-Array in ein neues Array der angegeben Größe kopiert.
            // Es verändert also nicht das ursprüngliche Array.

                        //List kann nur einen Datentyp haben, veränderbar, erweitbar
                        List<int> list = new List<int> { 1, 2, 3,50,60,32 ,99,98,97,96};
            list.Add(4);        //wird gelöscht (Stelle 3,erste Zahl)
            list.Add(5);        //wird gelöscht (Stelle 3,zweite Zahl)
            list.Add(6);        //wird gelöscht (Stelle 5)
            list.Sort();        //sortieren
            list.RemoveAt(5);   //Löschen an einer bestimmte Stelle/n
            list.RemoveRange(3, 2);//loschen 2 stellen ab Position3

            // Nützliche Methoden!
            //Contains methode
            Console.WriteLine(list.Contains(32));
            //count methode
            Console.WriteLine(list.Count);
            //find Index
            Console.WriteLine(list.FindIndex(x=> x == 32));  // kann exceptions machen wenn es gar nicht ist???
            Console.WriteLine(list.FindIndex(x => x == 55));  // -1 wird zurückgegeben wenn es gar nicht gefunden wird. VORSICHTIG verwenden
                                                              //wenn wir danach ausversehen auf diese -1 zugreifen versuchen wird eine UNBEHANDELTE Exception geworfen!!

            // alles ausdrücken
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //alle ausdrücken ganz einfach VIA LAMBDA EXPRESSIONS!!
            list.ForEach(i => Console.WriteLine("Ausgabe Via Lambda: " + i));




            //  Array Lists kann nur jeder Datentyp haben, veränderbar, erweitbar
            //  die unterschiedlichen Datentypen können exceptions oder unerwarteten ausgaben ergeben!!
            //  muss man dann entsprechend auf alle klassen die da rein implementiert sein könnten richtig aufpassen und alles berücksichtigen!!
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);   //ints
            arrayList.Add("zwei");  //string
            arrayList.Add(1.564);       //float oder double
            arrayList.Add(new Number { n = 4 });   //klasse Number
            arrayList.Add(new Number { n = 5 });   //klasse Number
            arrayList.Add(new Number { n = 6 });   //klasse Number

            // das macht ein Fehler wenn es versucht den Klasse N auszugeben dafür brauchen wir die tostring in der klasse überschreiben
            foreach (Object o in arrayList)
            {
                Console.WriteLine(o);
            }



            Console.ReadKey();
        }
    }

    class Number
    {
        public int n { get; set; }

        //überschreiben um wert in Array Lists anzeigen zu können. selber richtiggemacht.
        public override string ToString()
        {
            return n.ToString();
        }

    }
}
