using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
