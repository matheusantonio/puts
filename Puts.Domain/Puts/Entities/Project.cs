using Puts.Domain.Puts.Enums;

namespace Puts.Domain.Puts.Entities
{
    public class Project
    {
        public string Name { get; }

        public DateTime DateCreated { get; private set; }
        public ProjectStatus Status { get; set; }

        private List<Activity> _tasks;
        public IReadOnlyCollection<Activity> Tasks => this._tasks;

        private List<Collaborator> _collaborators;
        public IReadOnlyCollection<Collaborator> Collaborators => this._collaborators;

        public DateTime? Deadline { get; set; }
        public DateTime? PredictedDate => CalculatePredictedDate();

        public Project(string name)
        {
            this.Name = name;
            this.DateCreated = DateTime.Now;
            this.Status = ProjectStatus.Active;

            this._tasks = new List<Activity>();
            this._collaborators = new List<Collaborator>();
        }

        public void AddTask(Activity task)
        {
            this._tasks.Add(task);
        }

        public DateTime CalculatePredictedDate()
        {
            return DateTime.Now; // Calcular em função das tasks
        }
    }
}
