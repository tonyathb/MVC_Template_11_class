

namespace MVCTip_11class.Models
{
    class Tip
    {
        private double sumOrder;
        public double SumOrder
        {
            get { return sumOrder; }
            set { sumOrder = value; }
        }

        private double percent;
        public double Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.0;
                }
                else
                {
                    percent = value;
                }
            }
        }
        public double CalculateTip()
        {
            return this.Percent * this.SumOrder;
        }
        public double CalculateTotal()
        {
            return this.SumOrder + CalculateTip();
        }

        public Tip():this(0,0)
        {
            
        }
        public Tip(double suma, double percent)
        {
            this.SumOrder = suma;
            this.Percent = percent;
        }

    }
}
