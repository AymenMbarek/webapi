using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_test.Models;

namespace webapi_test.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            return new List<Command>
        {
           new Command{Id=0,HowTo="boil an egg",Line="boil water",Platform="zoirgehg" },
                      new Command{Id=0,HowTo="boil aqsqn egg",Line="boil water",Platform="zoirgehg" },
           new Command{Id=0,HowTo="boil ansdds egg",Line="boil water",Platform="zoirgehg" },
           new Command{Id=0,HowTo="boil anhioh egg",Line="boil water",Platform="zoirgehg" }

           };
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "boil an egg", Line = "boil water", Platform = "zoirgehg" };
        }
    }
}
