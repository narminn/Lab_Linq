using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinqExamples
{
    class Program
    {
        //EntityClass EntityClass = new EntityClass();
        static void Main(string[] args)
        {
           

            string[] names = { "Narmin", "Sekine", "Elvin", "Emin", "Naib", "Zohrali", "Fazil Abi", "Suleyman", "Zamin", "Nurlan" };

            int[] numbers = { 5, 7, 2, 6, 12, 25, 17, 9, 26, 33, 41 };
            //2.Arraylere aid olan queryler

            //2.1 Eyni herfle baslayan adlari qruplasdirib hansi herfle basladigini qeyd ederek ekrana cixardin
            //Meselen N herfi ile baslayan adlar:
            //Narmin,Nurlan,Naib...


            //2.2.Numbers arrayi icerisinde 5e bolunende eyni qaligi alinan ededleri qruplasdirib qaligini qeyd ederek ekrana cixardin
            //Meselen 5e bolunerken qaligi 1 olan ededler 6,26,41

            //2.3.Numbers arrayi icersinde cut ededlerden en kiciyinin 3 qatini ekrana cixardin



            int[] nums = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] str = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //2.4.nums arrayindeki ededleri strdeki adlarina uygun ekrana yazdirin
            //meselen birinci 5 verilib five ciarsin sonra four one ve s....



            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            //2.5 numbersA arrayindeki reqemlerin numbersB arrayindeki ededlerle muqayisesinden kicik olanlari ekrana cixarin
            //Ekrana cixmalidir :
            //0 kicikdir 1-den
            //0 kicikdir 3-den
            //0 kicikdir 5-den
            //0 kicikdir 7-den
            //0 kicikdir 8-den
            //2 kicikdir 3-den .....

            int[] ededler = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //2.6 ededler arrayindeki reqemlerin duzgun indexde olub olmadigini yoxlayin
            //Ekrana cixmalidir:
            //5:false ...
            //3:true...

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //2.7 digits arrayindeki reqemlerden ikinci herfi 'i' olanlari sondan evvele dogru ekrana cixaran sorgu yazin

            int[] numbersC = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersD = { 1, 3, 5, 7, 8 };

            //2.8 numbersC ve numbersD arraylerindeki ortaq reqemleri ekrana cixaran sorgu yazin

            string[] words = { "cherry", "apple", "blueberry" };

            //2.9 words arrayindeki sozlerin uzunluqlarinin cemini tapin

            int[] arr = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //2.10 arr arrayindeki ededlerin tekrarlanma sayini ekrana cixaran sorgu yazin
            
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            //2.11 ekrandan ilk ve son herf daxil olunacaq ilk herfle baslayib son herfle biten seherleri (cities arrayinin icinden)
            //ekrana cixaran sorgu yazin.  


        }
        
    }
}
