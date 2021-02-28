using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0,HowTo="Give me a break",Line="Whatever",Platform="Hansel & Gratel"},
                new Command{Id=1,HowTo="Give me a sandwich",Line="Dont care",Platform="Harry Potter"},
                new Command{Id=2,HowTo="Give me an umbrella",Line="Whoever",Platform="Big Bad Wolf"}
            };
            return commands; 
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id=0,HowTo="Give me a break",Line="Whatever",Platform="Hansel & Gratel"};
        }
    }
}