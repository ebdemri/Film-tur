using System;
using System.Collections;

namespace Film_Turr
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Tur = new Hashtable();
            Hashtable Tur2 = new Hashtable();
            Hashtable Tur3 = new Hashtable();
            Hashtable Tur4 = new Hashtable();
            Hashtable Tur5 = new Hashtable();
            Tur.Add("1", "Dabbe");
            Tur.Add("2", "Yarım Ada");
            Tur.Add("3", "Bird Box");
            Tur.Add("4", "Platform");

            Tur2.Add("1", "İntikam Vakti");
            Tur2.Add("2", "Oksijen");
            Tur2.Add("3", "Hayal Adası");

            Tur3.Add("1", "Forest Gump");
            Tur3.Add("2", "Hayat Güzeldir");
            Tur3.Add("3", "3 Ahmak");
            Tur3.Add("4", "Hababam Sınıfı");
            Tur3.Add("5", "Truman Show");

            Tur4.Add("1", "İnception");
            Tur4.Add("2", "Gravity");
            Tur4.Add("3", "Yenilmezler");
            Tur4.Add("4", "Örümcek Adam");
            Tur4.Add("5", "Demir Adam");

            Tur5.Add("1", "Dun Kirk");
            Tur5.Add("2", "1917");
            Tur5.Add("3", "Ryan' nı Kurtarmak");
            Tur5.Add("4", "300 Spartalı");
            Tur5.Add("5", "Outlaw King");

            Console.WriteLine("1-Filmler");

            Console.WriteLine("2-Film Ekle");

            Console.WriteLine("3-Film Sil");

            Console.Write("Yapmak İstedğiniz Eylemi Seçiniz:");
            int eylem = Convert.ToInt32(Console.ReadLine());
            switch (eylem)
            {
                case 1:
                    {
                        Console.WriteLine("1-Korku");
                        Console.WriteLine("2-Gerilim");
                        Console.WriteLine("3-Komedi");
                        Console.WriteLine("4-Bilim-Kurgu");
                        Console.WriteLine("5-Tarih");

                        Console.Write("Lütfen İzlemek İstediğinzi Film Türünün Yanındaki Numarayı Giriniz:");
                        int kategori = Convert.ToInt32(Console.ReadLine());
                        switch (kategori)
                        {
                            case 1:
                                {
                                    foreach (DictionaryEntry oge in Tur)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            case 2:
                                {
                                    foreach (DictionaryEntry oge in Tur2)
                                        Console.WriteLine("--->" + oge.Value);
                                }
                                break;
                            case 3:
                                {
                                    foreach (DictionaryEntry oge in Tur3)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            case 4:
                                {
                                    foreach (DictionaryEntry oge in Tur4)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;

                                }
                            case 5:
                                {
                                    foreach (DictionaryEntry oge in Tur5)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }

                            default:
                                break;


                        }

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("1-Korku");
                        Console.WriteLine("2-Gerilim");
                        Console.WriteLine("3-Komedi");
                        Console.WriteLine("4-Bilim-Kurgu");
                        Console.WriteLine("5-Tarih");

                        Console.Write("Lütfen Eklemek İstediğinzi Film Türünün Yanındaki Numarayı Giriniz:");
                        int kategori = Convert.ToInt32(Console.ReadLine());
                        switch (kategori)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Film Kodu Giriniz (Min 5 olmalı):");
                                    int kod = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Film Adını Giriniz:");
                                    string ad= Console.ReadLine();
                                    Tur.Add(kod , ad);
                                    foreach (DictionaryEntry oge in Tur)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Film Kodu Giriniz (Min 5 olmalı):");
                                    int kod = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Film Adını Giriniz:");
                                    string ad = Console.ReadLine();
                                    Tur.Add(kod, ad);
                                    foreach (DictionaryEntry oge in Tur2)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Film Kodu Giriniz (Min 5 olmalı):");
                                    int kod = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Film Adını Giriniz:");
                                    string ad = Console.ReadLine();
                                    Tur.Add(kod, ad);
                                    foreach (DictionaryEntry oge in Tur3)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Film Kodu Giriniz (Min 5 olmalı):");
                                    int kod = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Film Adını Giriniz:");
                                    string ad = Console.ReadLine();
                                    Tur.Add(kod, ad);
                                    foreach (DictionaryEntry oge in Tur4)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Film Kodu Giriniz (Min 5 olmalı):");
                                    int kod = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Film Adını Giriniz:");
                                    string ad = Console.ReadLine();
                                    Tur.Add(kod, ad);
                                    foreach (DictionaryEntry oge in Tur5)
                                        Console.WriteLine("--->" + oge.Value);
                                    break;
                                }
                            default:
                                break;
                        }

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("1-Korku");
                        foreach (DictionaryEntry oge in Tur)
                            Console.WriteLine("--->" + oge.Value);
                        Console.WriteLine("2-Gerilim");
                        foreach (DictionaryEntry oge in Tur2)
                            Console.WriteLine("--->" + oge.Value);
                        Console.WriteLine("3-Komedi");
                        foreach (DictionaryEntry oge in Tur3)
                            Console.WriteLine("--->" + oge.Value);
                        Console.WriteLine("4-Bilim-Kurgu");
                        foreach (DictionaryEntry oge in Tur4)
                            Console.WriteLine("--->" + oge.Value);
                        Console.WriteLine("5-Tarih");
                        foreach (DictionaryEntry oge in Tur5)
                            Console.WriteLine("--->" + oge.Value);

                        Console.Write("Lütfen Silmek İstediğinzi Film Türünün Yanındaki Numarayı Giriniz:");
                        int kategori = Convert.ToInt32(Console.ReadLine());
                        switch (kategori)
                        {
                            case 1:
                                {
                                        foreach (DictionaryEntry oge in Tur)
                                        Console.WriteLine(oge.Key + "---" + oge.Value);
                                        Console.Write("Silmek istediğiniz filmin numarasını giriniz:");
                                    
                                    int filmnosu = Convert.ToInt32(Console.ReadLine());

                                    switch (filmnosu)
                                    {
                                        case 1:
                                            {                                               
                                                Tur.Remove("1");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Tur.Remove("2");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Tur.Remove("3");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 4:
                                            {
                                                Tur.Remove("4");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        
                                        

                                        default:
                                            break;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    foreach (DictionaryEntry oge in Tur2)
                                        Console.WriteLine(oge.Key + "---" + oge.Value);
                                    Console.Write("Silmek istediğiniz filmin numarasını giriniz:");

                                    int filmnosu = Convert.ToInt32(Console.ReadLine());

                                    switch (filmnosu)
                                    {
                                        case 1:
                                            {
                                                Tur2.Remove("1");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur2)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Tur2.Remove("2");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur2)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Tur2.Remove("3");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur2)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        
                                        default:
                                            break;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    foreach (DictionaryEntry oge in Tur3)
                                        Console.WriteLine(oge.Key + "---" + oge.Value);
                                    Console.Write("Silmek istediğiniz filmin numarasını giriniz:");

                                    int filmnosu = Convert.ToInt32(Console.ReadLine());

                                    switch (filmnosu)
                                    {
                                        case 1:
                                            {
                                                Tur3.Remove("1");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur3)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Tur3.Remove("2");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur3)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Tur3.Remove("3");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur3)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 4:
                                            {
                                                Tur3.Remove("4");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur3)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 5:
                                            {
                                                Tur3.Remove("5");
                                                Console.WriteLine("<------Yeni Liste------->");
                                                Console.WriteLine("-------------------------");
                                                foreach (DictionaryEntry oge in Tur3)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);

                                                break;
                                            }


                                        default:
                                            break;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    foreach (DictionaryEntry oge in Tur4)
                                        Console.WriteLine(oge.Key + "---" + oge.Value);
                                    Console.Write("Silmek istediğiniz filmin numarasını giriniz:");

                                    int filmnosu = Convert.ToInt32(Console.ReadLine());

                                    switch (filmnosu)
                                    {
                                        case 1:
                                            {
                                                Tur4.Remove("1");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur4)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Tur4.Remove("2");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur4)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Tur4.Remove("3");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur4)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 4:
                                            {
                                                Tur4.Remove("4");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur4)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 5:
                                            {
                                                Tur4.Remove("5");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur4)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }


                                        default:
                                            break;
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    foreach (DictionaryEntry oge in Tur5)
                                        Console.WriteLine(oge.Key + "---" + oge.Value);
                                    Console.Write("Silmek istediğiniz filmin numarasını giriniz:");

                                    int filmnosu = Convert.ToInt32(Console.ReadLine());

                                    switch (filmnosu)
                                    {
                                        case 1:
                                            {
                                                Tur5.Remove("1");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur5)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 2:
                                            {
                                                Tur5.Remove("2");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur5)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 3:
                                            {
                                                Tur5.Remove("3");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur5)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 4:
                                            {
                                                Tur5.Remove("4");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur5)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }
                                        case 5:
                                            {
                                                Tur5.Remove("5");
                                                Console.WriteLine("<------Yeni Liste--->");
                                                Console.WriteLine("-----------------------");
                                                foreach (DictionaryEntry oge in Tur5)
                                                    Console.WriteLine(oge.Key + "---" + oge.Value);
                                                break;
                                            }


                                        default:
                                            break;
                                    }
                                    break;
                                   
                                }

                            default:
                                break;
                        }
                        break;
                    }
                default:
                    break;
            }


            


            
        }
    }
}
