// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

namespace BasicProg;
class Program
{ 
    static void Main(String[] args)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine("        PROGRAM PENILAIAN KARYAWAN         ");
        Console.WriteLine("===========================================");
        Karyawan();
    }

    static void Karyawan()
    {
        int lembur;
        int j;
        
        Console.Write("Masukkan Jumlah Karyawan : ");
        j = Convert.ToInt32(Console.ReadLine());
        
        string[] nama = new string[j];
        for(int i = 0; i< nama.Length; i++)
        {
            Console.Write("Masukkan Nama Karyawan : ");
            nama[i] = Convert.ToString(Console.ReadLine());

            do
            {
                Console.Write("Masukkan Jam Lembur (0-5): ");
                lembur = int.Parse(Console.ReadLine());
                if(lembur>5 || lembur<0)
                {
                    Console.WriteLine("Error, Angka harus antara 0 sampai 5");
                    Console.WriteLine("");
                }
            } while (lembur > 5 || lembur < 0);
            

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nama Pegawai \t    : " + nama[i]);
            Console.WriteLine("Jam Lembur \t    : " + lembur+" jam");
            Console.WriteLine("Total gaji yang diperoleh : Rp. " + UangLembur(lembur));

            if(UangLembur(lembur) < 5100000)
            {
                Console.WriteLine("Dia Karyawan Hebat");
            }

            else if (UangLembur(lembur) < 5200000)
            {
                Console.WriteLine("Dia Karywan yang Sangat Rajin");
            }
            else
            {
                Console.WriteLine("Dia Budak Korporat");
            }
            //Grade(UangLembur(lembur));    SAAT PEMANGGILAN TERJADI ERROR, SEBEB OUTPUT YANG TAMPIL HANYA BAGIAN ELSE YAITU "DIA BUDAH KORPORAT"
            //Console.Write("Grade : "+ Grade(UangLembur(lembur)););
        }
    }

    /*static void Grade(double lembur)
    {
        string grade;
        if (UangLembur(lembur) < 5100000)
        {
            Console.WriteLine("Dia Karyawan Hebat");
            //grade = "Dia Karyawan yang Sangat Rajin";
           //return grade;
        }

        else if (UangLembur(lembur) < 5200000)
        {
            Console.WriteLine("Dia Karywan yang Sangat Rajin");
            //grade = "Dia Karywan Hebat";
            //return grade;
        }
        else
        {
            Console.WriteLine("Dia Budak Korporat");
            //grade = "Dia Karywan Hebat";
            //return grade;
        }
        //return grade;
    }*/

    static double UangLembur(double lembur)
    {
        //double gaji;
        //Console.Write("Masukkan Gaji Karyawan : "); gaji = Convert.ToDouble(Console.ReadLine());
        double uanglembur = 5000000 * 2 * 0.005780347 * lembur;
        double tgaji = 5000000 + uanglembur;
        return tgaji;
    }
}