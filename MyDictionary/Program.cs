using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kirtasiyeUrunleri = new Dictionary<int, string>();
            kirtasiyeUrunleri.Add(1, "Kırmızı Kalem");
            kirtasiyeUrunleri.Add(2, "Sınav Silgisi");
            kirtasiyeUrunleri.Add(3, "Tükenmez Kalem");
            kirtasiyeUrunleri.Add(4, "Kalemlik");
            kirtasiyeUrunleri.Add(5, "Defter");
            kirtasiyeUrunleri.Add(6, "Matematik Kitabı");
            kirtasiyeUrunleri.Add(7, "Notebook");
            kirtasiyeUrunleri.Add(8, "Fosforlu Kalem");

            foreach (KeyValuePair<int, string> kirtasiye in kirtasiyeUrunleri)
            {
                Console.WriteLine(kirtasiye.Key + " " + kirtasiye.Value);
            }
        }
    }
}
