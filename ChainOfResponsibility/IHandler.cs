using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(IRequest request);
    }
}
