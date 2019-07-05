using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplicationAPI.Controllers
{
    public class StaticConstants
    {
        public static Dictionary<string, string[]> jobMappings = new Dictionary<string, string[]> {
            ["Undergraduate"] = new string[] { " 'Internship' ", " 'Graduate Job' " },
            ["Postgraduate"] = new string[] { " 'Graduate Job' ", " 'Full Time' " },
            ["Professional"] = new string[] { " 'Full Time' " }
        };
    }
}
