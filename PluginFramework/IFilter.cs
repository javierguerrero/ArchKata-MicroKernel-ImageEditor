using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PluginFramework
{
    public interface IFilter
    {
        Image RunPlugin(Image src);
        string Name { get; }
    }
}