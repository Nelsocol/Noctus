using System;
using System.Collections.Generic;
using System.Text;

namespace NoctusEngine
{
    public interface IInputChannel
    {
        Link SelectLink(List<Link> links);
    }
}
