using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTask.Exceptions
{
    internal class CourseLimitOverflowException:Exception
    {

        public CourseLimitOverflowException(string msg):base(msg)
        {
           
        }
    }
}
