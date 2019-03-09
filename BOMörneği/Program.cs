using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BOMörneği
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("BOM sayısını giriniz:");
            int bom = Convert.ToInt32(Console.ReadLine());
            bool hatavar = false;
            string girilendeger;
          /*
          Kullanıcı BOM sayısı girsin.
          PC ile kullanıcı birer birer sayı arttıracak şekilde bir oyun oynayacak sırası geldiğinde PC otomatik olarak sayı
          girecek kullanıcıda elle girecek. BOM sayısı ve katlarında BOM yazılacak. PC zaten otomatik olarak BOM katlarında BOM
          yazmalı. Eğer kullanıcı da yazmazsa kullanıcı kaybetmeli.
          Eğer sonuna kadar kullanıcı kaybetmezse sonuç berabere bitecek. PC hiç yenilmemeli.
          */
             do
                {
                int i;
                    for ( i = 1; i <= 10; i++)
                    {

                        if (i % 2 == 0)
                        {
                            Console.Write("Kullanıcı:");
                            girilendeger = (Console.ReadLine());//Kullanıcıdan girilen değer
                            if (i % bom == 0) //i'nin bom sayısına bölümünden kalan 0 ise
                            {
                                if (girilendeger != "BOM") //BOM katlarında BOM yazılmadıysa 
                                {

                                    hatavar = true;
                                    Console.WriteLine("KAYBETTİNİZ..");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {

                            continue;  
                            }

                        }
                        else
                        {
                            if (i % bom == 0)//BOM katlarıysa 
                            {
                                girilendeger = Console.ReadLine();
                                Console.WriteLine("BOM");                           }
                            else
                            {
                                Console.WriteLine("PC:{0} ", i);//BOM katları değilse for döngüsündeki i değerini yaz
                            }
                        }

                        Thread.Sleep(500);//Oyun hızı

                    }
                if (hatavar==false)
                {
                    Console.WriteLine("BERABERE KALDINIZ...");
                }
             
                
                hatavar = true;
            } while (hatavar == false);//hatavar bool değişkeni false olduğu sürece dönecek
          
            
            Console.ReadKey();
        }
    }
}
