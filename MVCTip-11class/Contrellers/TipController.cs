using MVCTip_11class.Models;
using MVCTip_11class.Views;

namespace MVCTip_11class.Controllers
{
    class TipController
    {
        Tip smetkaNaMasa = new Tip();
        Display display = new Display();

        public TipController()
        {
            //display->Smetka    display ---> percent
            display.Input();
            smetkaNaMasa.SumOrder = display.SumaOrderDisplay;
            smetkaNaMasa.Percent = display.PercentDisplay;

            double result=smetkaNaMasa.CalculateTotal();
            display.SumTotal = result;            
            display.TipTotal=smetkaNaMasa.CalculateTip();
            
            display.Оutput();
        }
    }
}
