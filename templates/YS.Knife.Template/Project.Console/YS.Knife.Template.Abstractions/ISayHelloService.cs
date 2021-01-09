using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using YS.Knife.Aop;

namespace YS.Knife.Template
{
    [ParameterValidation]
    public interface ISayHelloService
    {
        void SayHello([Required(AllowEmptyStrings = false)][StringLength(5)] string name);
    }
}
