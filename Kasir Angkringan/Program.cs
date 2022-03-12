using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSwitchAndLoop
{
    class Program
    {
        public double nasi, sate, gorengan, minuman, totnasi, totsate, totgorengan, totminuman;
        public List<double> harga = new List<double>();
        int pilih;

        public void Hitungnasi()
        {
            Console.WriteLine("Berapa bungkus nasi yang ingin anda beli?");
            nasi = Double.Parse(Console.ReadLine());
            totnasi = nasi * 2500;
            harga.Add(totnasi);
            Console.WriteLine("\nBerhasil menambahkan Nasi sebanyak: {0} bungkus kedalam keranjang \n", nasi);
        }

        public void Hitungsate()
        {
            Console.WriteLine("Berapa tusuk sate yang ingin anda beli?");
            sate = Double.Parse(Console.ReadLine());
            totsate = sate * 3000;
            harga.Add(totsate);
            Console.WriteLine("\nBerhasil menambahkan Sate sebanyak: {0} tusuk kedalam keranjang  \n", sate);
        }

        public void Hitunggorengan()
        {
            Console.WriteLine("Berapa biji Gorengan yang ingin anda beli?");
            gorengan = Double.Parse(Console.ReadLine());
            totgorengan = gorengan * 1000;
            harga.Add(totgorengan);
            Console.WriteLine("\nBerhasil menambahkan Gorengan sebanyak: {0} Biji kedalam keranjang  \n", gorengan);
        }

        public void Hitungminuman()
        {
            Console.WriteLine("Berapa gelas minuman yang ingin anda beli?");
            minuman = Double.Parse(Console.ReadLine());
            totminuman = minuman * 4000;
            harga.Add(totminuman);
            Console.WriteLine("\nBerhasil menambahkan Minuman sebanyak: {0} gelas kedalam keranjang \n", minuman);
        }



        public void Menu()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Nasi Rp. 2.500/Bungkus" +
                        "\n2. Sate Rp. 3.000/Tusuk" +
                        "\n3. Gorengan Rp. 1.000/Biji" +
                        "\n4. Minuman Rp. 4.000/Gelas" +
                        "\n5. Selesai/Keluar");
                    Console.Write("Pilihan (1/2/3/4/5) : ");
                    pilih = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    switch (pilih)
                    {
                        case 1:
                            Hitungnasi();
                            break;
                        case 2:
                            Hitungsate();
                            break;
                        case 3:
                            Hitunggorengan();
                            break;
                        case 4:
                            Hitungminuman();
                            break;
                        case 5:
                            if (!harga.Any())
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("========================================================");
                                Console.WriteLine("List Menu:" +
                                    "\n {0} bungkus Nasi, " +
                                    "\n {1} tusuk Sate," +
                                    "\n {2} biji Gorengan," +
                                    "\n {3} gelas Minuman"
                                    , nasi, sate, gorengan, minuman);
                                Console.WriteLine("Total Belanja = Rp. {0}\n", harga.Sum(x => x));
                                Console.WriteLine("========================================================\n");
                                Console.WriteLine("Apakah masih ingin berbelanja?\n" +
                                    "tekan 'iya' untuk melanjutkan belanja atau tekan 'apa saja untuk keluar'");

                                if (!Console.ReadLine().Equals("iya", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    harga.Clear();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("\n````````\n");
                                    break;
                                }
                            }
                        default:
                            Console.WriteLine("Pilihan tidak tersedia");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Harap memsukkan angka 1 - 5\n");
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Selamat Datang di Aplikasi Ngangkringmen" +
                "\n========================================================" +
                "\nJalan Wakhid Hasyim No 102, Keringan, Palbapang, Bantul" +
                "\n========================================================" +
                "\nSilahkan memilih pada menu pembelian" +
                "\n========================================================\n");
            p.Menu();
        }
    }
}