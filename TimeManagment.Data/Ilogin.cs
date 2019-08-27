using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagment.Data
{
    interface Ilogin
    {
        Token login(User user);
    }
}
