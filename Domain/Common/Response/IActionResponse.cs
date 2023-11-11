using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Response
{
    public interface IActionResponse
    {
        ResponseStateEnum State { get; set; }
        List<string> Errors { get; set; }
    }
}
