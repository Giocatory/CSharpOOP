﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonThree
{
    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
}