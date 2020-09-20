using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Command.Cookie
{
    public class CookieCommand : CommandRepository<StoredCookie>, ICookieCommand
    {
        public CookieCommand(VejledningsContext context) : base(context)
        {

        }
    }
}
