using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zemzem.IntefaceClasses
{
    public interface ISliderService
    {
        bool editslider(TbSlider slider);
        bool addslider(TbSlider slider);
        bool DeleteSlider(int id);
        public TbSlider GetSliderById(int id);
        public List<TbSlider> _slider();
        //banner
        



    }
}
