using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication49
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            string s;
            s = Clipboard.GetText();
            var words = s.Split(' ');
            
            List<String> l = new List<String>();
            List<String> vyhodnoy_massiv = new List<String>();

            foreach (var word in words)
            {
                
                var cl = word.Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").Trim();
                l.Add(cl);

            }

            l.Sort(StringComparer.CurrentCultureIgnoreCase);
            vyhodnoy_massiv = l.Distinct().Take(1000).ToList();
           
            foreach (var item in vyhodnoy_massiv)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
