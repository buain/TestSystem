using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestSystem.BLL.Interfaces;
using TestSystem.BLL.Services;

namespace MVCInterface.Util
{
    public class TestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITestLogic>().To<TestService>();
        }
    }
}