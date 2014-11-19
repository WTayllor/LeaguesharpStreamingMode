﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LeaguesharpStreamingMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly s = Assembly.Load(LeaguesharpStreamingMode.Properties.Resources.LeaguesharpStreamingModelib);
            s.GetType("LeaguesharpStreamingModelib.StreamingMode").GetMethod("Enable").Invoke(null, null);

            AppDomain.CurrentDomain.DomainUnload += delegate
            {
                Assembly s2 = Assembly.Load(LeaguesharpStreamingMode.Properties.Resources.LeaguesharpStreamingModelib);
                s2.GetType("LeaguesharpStreamingModelib.StreamingMode").GetMethod("Disable").Invoke(null, null);
            };

        }
    }
}
