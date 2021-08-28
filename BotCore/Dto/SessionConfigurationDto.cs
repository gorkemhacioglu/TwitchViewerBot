﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BotCore.Dto
{
    public class SessionConfigurationDto
    {
        public string Url { get; set; }

        public int Count { get; set; }

        public string PreferredQuality { get; set; }

        public LoginDto LoginInfo { get; set; }
    }
}