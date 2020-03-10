using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infrastructure
{
    using ViewModels;
    class InstanceLocator
    {
        #region
        public MainViewModel Main { get; set; }
        #endregion
        #region constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();

        }
        #endregion
    }
}
