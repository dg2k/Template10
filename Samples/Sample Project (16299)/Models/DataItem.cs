﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Models
{
    public class DataGroup
    {
        public string Title { get; set; }
        public IEnumerable<DataItem> Items { get; set; }
    }

    public class DataItem
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public int Index { get; set; }
    }
}
