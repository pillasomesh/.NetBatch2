﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI.Core.ConfigModel
{
    public class GlobalConfig
    {
        public TextRequestConfig TextRequestApi { get; set; } = null!;
    }
}
