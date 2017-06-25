using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillManagement
{
    public class NewRegistration
    {
        public string UserId { set; private get; }
        public bool CheckIfUserIdPresent(string userId)
        {
            if(userId.Contains("Test"))
                return true;
            return false;
        }
    }
}
