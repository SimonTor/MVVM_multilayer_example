﻿using BM.MultiLayer.CrossCutting.Logging.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.MultiLayer.CrossCutting.Logging
{
    public class Logger : ILogger
    {
        public void Write(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
