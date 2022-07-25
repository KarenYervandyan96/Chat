using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMessenger.Model
{
    public record MessageITem(Guid Id,
    string Name,
    string Message);

    public record CreatMessage(string Name,
        string Message);
}
