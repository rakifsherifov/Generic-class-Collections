using System;
using System.Collections;

namespace Generic_class__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(30);
            arrayList.Add(23);
            arrayList.Add(29);
            arrayList.Add("Rakif");
            arrayList.Add('R');

            arrayList.Remove();// verilmis value ni silir meselen: 
            arrayList.Remove("Rakif");
            arrayList.RemoveAt();//verilmis indexi silir meselen :
            arrayList.RemoveAt(3);
            arrayList.Clear();// verilmis butun objectleri temizleyir
            arrayList.LastIndexOf();// sonuncu indexi qaytarir
            arrayList.IndexOf();
            arrayList.Sort(); //boyukden kiciye dogru arraylari qaytarir
            arrayList.Reverse(); //value elave edir
            arrayList.Insert(2, 50); //verilmis indexe verilmis value ni yerlesdiririk

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            Queue queue= new Queue();
            queue.Enqueue(50);
            queue.Enqueue(29);
            queue.Enqueue(47);
            queue.Enqueue("Rakif");
            queue.Enqueue('R');

            foreach (var item in queue)
            {
                Console.WriteLine(queue);
            }
        }
    }
}
