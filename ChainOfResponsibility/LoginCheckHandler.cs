using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class LoginCheckHandler : BaseHandler
    {
        public override void HandleInternal(IRequest request)
        {
            if(request.Login != null)
            {
                throw new Exception();
            }
        }
    }
}
