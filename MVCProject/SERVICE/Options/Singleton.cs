﻿using MODEL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Options
{
    public class Singleton
    {
        private static AppDbContext _context;

        public static AppDbContext Context
        {
            get
            {

                if (_context == null)
                {
                    _context = new AppDbContext();
                }
                return _context;
            }

        }
    }
}
