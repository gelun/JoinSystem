using System;
using System.Collections.Generic;
using System.Reflection;

namespace Basic.TypeFinder
{
    public interface ITypeFinder
    {
        IList<Assembly> GetFilteredAssemblyList();
    }
}
