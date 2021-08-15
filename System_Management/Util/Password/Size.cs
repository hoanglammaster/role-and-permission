using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System_Management.Util
{
    public abstract class Size
    {
        protected int SALT = 24;
        protected int HASH = 24;
        protected int MIN_COST = 15;
        protected int MAX_COST = 22;
        protected static Random random = new Random();
    }
}