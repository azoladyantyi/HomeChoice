﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeChoice
{

    public class HomeChoiceMasterDetailPage1MasterMenuItem
    {
        public HomeChoiceMasterDetailPage1MasterMenuItem()
        {
            TargetType = typeof(HomeChoiceMasterDetailPage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}