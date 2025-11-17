using AutoMapper;
using BaseApp.Domain.Entities;
using BaseApp.Application.Feature.ToDos.Commands.CreateToDo;
using BaseApp.Application.Feature.Users.Commands.CreateUser;
using BaseApp.Application.Feature.ToDos.Queries.GetByUserId;
using BaseApp.Application.Feature.ToDos.Commands.UpdateToDo;
using BaseApp.Application.Feature.Users.Queries.GetUserById;
using BaseApp.Application.Feature.Users.Queries.GetUserList;

namespace BaseApp.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User mapping
        CreateMap<CreateUserCommand, User>().ReverseMap();
        CreateMap<User, GetUserByIdVm>().ReverseMap();
        CreateMap<User, GetUserListVm>().ReverseMap();
        //TODO mapping
        CreateMap<CreateTodoCommand, TodoItem>().ReverseMap();
        CreateMap<TodoItem, GetByUserIdVm>().ReverseMap();
        CreateMap<TodoItem, UpdateTodoCommand>().ReverseMap();
        
    }
}

