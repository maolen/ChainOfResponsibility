using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;
        
        public bool CanHandle(IRequest request)
        {
            
        }
        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void HandleInternal(IRequest request);
        public void Handle(IRequest request)
        {
            HandleInternal(request);
            if(_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }

    }
}
