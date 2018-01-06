using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerTest.ViewModels
{
    class SecondViewModel :Screen
    {
        public SecondViewModel()
        {
            DisplayName = "Second";
            MyLabel = "THIS IS THE SECOND VM!";
        }

        private string _label;

        public string MyLabel
        {
            get
            {
                return _label;
            }
            set
            {
                if (_label == value)
                {
                    return;
                }
                _label = value;
                NotifyOfPropertyChange();
            }
        }
    }
}
