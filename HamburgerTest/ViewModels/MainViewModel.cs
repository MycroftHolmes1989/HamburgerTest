using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerTest.ViewModels
{
    [PartCreationPolicy(CreationPolicy.Shared), Export(typeof(MainViewModel))]
    class MainViewModel : Conductor<IScreen>
    {
        public void ShowFirst() => ActiveItem = new FirstViewModel();
        public void ShowSecond() => ActiveItem = new SecondViewModel();
    }
}
