namespace StudentAttendanceConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> students = new Dictionary<int, string>();
        // Sol taraf anahtar
        // Öğrenci Numarasını anahtar Öğrenci adını değer olarak içerek bir sözlük oluşturduk 
        students.Add(01, "Mahmut");
        students.Add(02, "Mehmet");
        students.Add(03, "Cem");
        students.Add(04, "Mila");
        students.Add(05, "Şeyma");


        // Öğrencileri biz ekleseydik 
        //while (true)
        //{
        //    Console.WriteLine("kişi ekle anahtarı ne olacak");
        //    var anahtar = int.Parse(Console.ReadLine());
        //    var deger = Console.ReadLine();

        //    students.Add(anahtar, deger);
        //}


        List<int> yoklamayaKatilanlar = new List<int>();
        //Yoklamaya katılan öğrencilerin numaralarını içeren bir liste oluşturuyoruz

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key} - {student.Value}");//Öğrenci bilgilerini yazdırma
        }


        while (yoklamayaKatilanlar.Count != students.Count) // 
        {
            try
            {
                Console.WriteLine("Lütfen Öğrenci numarası girin");//Öğrenci numarası giriş 

                int ogrenciNumarasi = Convert.ToInt32(Console.ReadLine());
                var ogrenci = students[ogrenciNumarasi];
                //Girilen öğrenci numarasını kullanarak öğrencinin adını alıyoruz

                if (yoklamayaKatilanlar.Contains(ogrenciNumarasi))
                {
                    Console.WriteLine("Bu öğrenci zaten var " + ogrenci);
                    //Eğer öğrenci numarası listede zaten varsa bu öğrenci zaten var yazdırıyoruz
                }
                else
                {
                    yoklamayaKatilanlar.Add(ogrenciNumarasi);
                    //Eğer öğrenci numarası yoksa listeye ekliyoruz
                }
            }

            catch (System.FormatException exception)
            {
                Console.WriteLine("Sadece sayılsal değer girebilirsiniz Lütfen Öğrenci numarasını girin");
                //Kullanıcı sayısal olmayan bir değer girince hata mesajı
            }
            catch (System.Collections.Generic.KeyNotFoundException exception)
            {
                Console.WriteLine("öğrenci bulunamadı");
                //Öğrenci no listede yoksa hata mesajı
            }
        }


        Console.WriteLine("herkes sınıfta");
        Console.Read();
       

        //int kontrolü ile sıfıtaki öğrencinin numarasını isteyin
        //int değer girilmezse hata fırlatın
        //değer int ise sınıftaki öğrenci numaralarında bu değeri arayın ve eğer böyle numaralı bir öğrenci yoksa hata fırlatın
        //eğer öğrenci varsa ekranda şu öğrenci sınıfta olarak işaretli yazsın ve sonra başka kim sınıfta diye sorsun
        //Aşağıdaki bonus ödevler için arrayler kullanmalısınız ya da listeler
        //Bonus ödev: Eğer öğrenci zaten sınıfta işaretlendiyse o zaman tekrar işretlemesin ve hata versin
        //Bonus ödev: tüm öğrenciler sınıfta olarak işaretlenirse uygulama tüm öğrenciler sınıfta desin ve kapansın
    }
}

