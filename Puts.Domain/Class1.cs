using Puts.Domain.Puts.Entities;

namespace Puts.Domain
{
    public class Class1
    {
        public void teste()
        {
            var project = new Project("Nome");

            project.AddTask(new Puts.Entities.Activity());

            Console.WriteLine();
        }
    }
}
