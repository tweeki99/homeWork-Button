using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwButton
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button(10,5,3,3);

            button.ReadButton();
        }
    }
}
