using Puts.Domain.Puts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puts.Domain.Puts.Entities
{
    public class Activity
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        public TimeSpan WorkAmount { get; set; }
        public Collaborator Owner { get; set; }
        public DateTime? DueDate { get; set; }
        public ActivityStatus Status { get; set; }

        public bool Done { get; set; }

        public List<Activity> _previousTasks;
        public List<Activity> _nextTasks;


    }
}
