namespace ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Kaç öğrenci kaydetmek istiyorsunuz?");
                    int kayit = int.Parse(Console.ReadLine());


                    for (int a = 0; a < kayit; a++)
                    {

                        Console.WriteLine("Öğrencinin Numarasını giriniz:");
                        decimal numara = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Öğrencinin Adını giriniz:");
                        string isim = Console.ReadLine();
                        Console.WriteLine("Öğrencinin Soyadını giriniz:");
                        string soyad = Console.ReadLine();

                        while (true)
                        {
                            Console.WriteLine("Öğrencinin Vize notunu giriniz:");
                            int vize = int.Parse(Console.ReadLine());
                            Console.WriteLine("Öğrencinin Final notunu giriniz:");
                            int final = int.Parse(Console.ReadLine());
                            double ort = double.Parse(Console.ReadLine());
                            string harf = Console.ReadLine();

                            if (0 <= vize && vize <= 100 && 0 <= final && final <= 100)
                            {
                                ort = final * 0.6 + vize * 0.4;
                                Console.WriteLine(ort);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Not aralığı 0-100 arasında olmalıdır.");
                            }


                            //if (0 <= ort && ort <= 9)
                            //{
                            //    harf = "FF";
                            //}
                            //else if (10 <= ort && ort <= 19)
                            //{
                            //    harf = "FD";
                            //}
                            //else if (20 <= ort && ort <= 29)
                            //{
                            //    harf = "DD";
                            //}
                            //else if (30 <= ort && ort <= 39)
                            //{
                            //    harf = "DC";
                            //}
                            //else if (40 <= ort && ort <= 49)
                            //{
                            //    harf = "CC";
                            //}
                            //else if (50 <= ort && ort <= 59)
                            //{
                            //    harf = "CB";
                            //}
                            //else if (60 <= ort && ort <= 74)
                            //{
                            //    harf = "BB";
                            //}
                            //else if (75 <= ort && ort <= 84)
                            //{
                            //    harf = "BA";
                            //}
                            //else if (85 <= ort && ort <= 100)
                            //{
                            //    harf = "AA";
                            //}
                            //else
                            //{

                            //}

                            //Console.WriteLine(harf);
                        }


                        //string[,] dizi = new string[6, kayit];

                        //dizi[0, 0] = "Numara";
                        //dizi[0, 1] = "Ad";
                        //dizi[0, 2] = "Soyad";
                        //dizi[0, 3] = "Vize Notu";
                        //dizi[0, 4] = "Final Notu";
                        //dizi[0, 5] = "Ortalama";
                        //dizi[0, 6] = "Harf Notu";


                        //dizi[0, kayit] = numara;
                        //dizi[1, kayit] = isim;
                        //dizi[2, kayit] = soyad;
                        //dizi[3, kayit] = vize;
                        //dizi[4, kayit] = final;
                        //dizi[5, kayit] = ort;
                        //dizi[6, kayit] = harf;

                        //Console.WriteLine(dizi);
                    }





                }






                catch (OverflowException)
                {
                    Console.WriteLine("Lütfen uygun değer aralığında sayılar giriniz.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen değerleri uygun formatta giriniz.");
                }
            }


        }

    }
}

