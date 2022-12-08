namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List <T> class
            //System.Collections.Generic
            //T-> Object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var item in sayiListesi)
                Console.WriteLine(item);
            foreach (var item in renkListesi)
                Console.WriteLine(item);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            //Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde Arama

            if (sayiListesi.Contains(10))
                 Console.WriteLine("10 Liste içerisinde bulunur.");

            //Eleman ile indexe erişmek
            renkListesi.BinarySearch("Sarı");

            //Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List <string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz 
            hayvanListesi.Clear();


            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi =new List<Kullanıcılar>();  

            Kullanıcılar kullanici = new Kullanıcılar();
            kullanici.Isim = "Mehmet";
            kullanici.Soyasisim = "Cantemir";
            kullanici.Yas = 25;

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Sedef";
            kullanici1.Soyasisim = "Cantemir";
            kullanici1.Yas = 20;

            kullanıcıListesi.Add(kullanici);
            kullanıcıListesi.Add(kullanici1);

           
          







        }
    }

    public class Kullanıcılar
    {
        private string isim;

        private string soyasisim;

        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyasisim { get => soyasisim; set => soyasisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}