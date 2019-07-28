using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagHealper.models;

namespace TagHealper.Controllers.ViewComponents
{
    public class adViewComponent : ViewComponent
    {
        //public ViewComponentResult Invoke()
        public ViewViewComponentResult Invoke()
        {
            List<News> model = new List<News>
            {
                new News{Title="خبر اول",Text="فروش لوازم داخلی برای ایران بهترین راه خروج از بحران",ImagePath="car4.jpg"},
                new News{Title="خبر دوم",Text="میوه فروشان برای افزایش قیمت با صنف خود همکاری نمیکنند",ImagePath="car5.jpg"},
                new News{Title="خبر سوم",Text="مبلغ وام ازدواج به ازای هر نفر به 30 میلیون شد ازدواج افزایش نیافت...",ImagePath="car7.jpg"}
            };

            return View(model);
        }
    }
}
