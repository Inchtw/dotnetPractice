using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {   // automapper
        public CommandsProfile()
        {
            // Source (ex. command) -> Target (dto)
            CreateMap<Command, CommandReadDto>();
            // 轉回去的
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            // before pathching 
            CreateMap<Command, CommandUpdateDto>();
        }
    }

}