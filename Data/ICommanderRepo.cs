using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges(); // SaveChanges() method on DbContext triggers the database changes
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        // after get DTO
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);

        void DeleteCommand(Command cmd);

    }

}