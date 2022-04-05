using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTask
{
    internal class Group
    {
        static int _totalCount;
        public Group()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No { get; set; }
        public GroupType Type { get; set; }

        public override string ToString()
        {
            return $"No: {No} - Type: {Type}";
        }

    }
}
