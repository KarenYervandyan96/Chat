using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Dto
{
    public record MessageITem(Guid Id,
    string Name,
    string Message)
    {
        public override string ToString()
        {
            return Name + ": " + Message;
        }
    }
    public record CreatMessage(string Name,
        string Message);
 



}
