using CourseTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTask
{
    internal class Course
    {
        Group[] _groups = new Group[0];
        public Group[] Groups { get; set; }
        public int Limit { get; set; } = 5;
        public void AddGroup(Group group)
        {
            if (_groups.Length < Limit)
            {
                Array.Resize(ref _groups, _groups.Length + 1);
                _groups[_groups.Length - 1] = group;
            }
            else
            {
                throw new CourseLimitOverflowException("Limit dasib!");
            }
        }

        public Group[] GetAllGroupsByType(GroupType type)
        {
            Group[] groups = new Group[0];

            foreach (var gr in _groups)
            {
                if(gr.Type == type)
                {
                    Array.Resize(ref groups, groups.Length + 1);
                    groups[groups.Length - 1] = gr;
                }
            }

            return groups;
        }
    }
}
