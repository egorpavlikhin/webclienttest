﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebClientTest
{
    public interface IWebCrawler
    {
        Task<IHtmlDocument> Get(string url);
    }
}
