﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
   public class DateModifier
    {
        public int GetDaysDiffrence(string startDateAsString, string endDateAsString)
        {
            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);

            int totalDays =(int)Math.Abs((endDate - startDate).TotalDays);
            return totalDays;

        }
    }
}
