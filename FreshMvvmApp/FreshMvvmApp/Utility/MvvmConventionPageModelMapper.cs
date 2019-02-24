using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshMvvmApp.Utility
{
    public class MvvmConventionPageModelMapper : IFreshPageModelMapper
    {
        public string GetPageTypeName(Type pageModelType)
        {
            return pageModelType.AssemblyQualifiedName.Replace("PageViewModel", "PageView").Replace("ViewModel", "View");
        }
    }
}
