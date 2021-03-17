using Commander.Models;
using System;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Windows" },
                new Command { Id = 1, HowTo = "Fly", Line = "Jump and move", Platform = "Windows" },
                new Command { Id = 2, HowTo = "Drink Nutrimilk", Line = "Open it and buy it", Platform = "Human Being" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Windows" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}