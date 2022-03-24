﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexCl.Models
{
    public class MyRegex
    {

        public static string? FindRegexInText(string text, string pattern)
        {
            string result = "";
            if (pattern == null) { return null; }
            else
            {
                Regex r = new Regex(pattern);
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                {
                    result += (x.Value + "\n");
                }
            }
            return result;
        }
    }
}