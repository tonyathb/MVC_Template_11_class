using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTip_11class.Views
{
    class Display
    {
        public double SumaOrderDisplay { get; set; } //input
        public double PercentDisplay { get; set; } //input
        public double SumTotal { get; set; } //za print
        public double TipTotal { get; set; } //za print

        public void Input()
        {
            Console.Write("Дай ми сумата на поръчката: ");
            this.SumaOrderDisplay = double.Parse(Console.ReadLine());

            Console.Write("Дай ми процента бакшиш: ");
            this.PercentDisplay = double.Parse(Console.ReadLine());
        }

        public void Оutput()
        {
            Console.WriteLine($"Сумата за плащане е: {this.SumTotal:c}");
            Console.WriteLine($"Бакшишът е: {this.TipTotal:c}");
        }
    }
}
