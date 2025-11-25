using AutoMapper;
using ClothesShop.Domain.Entities;
using ClothesShop.Application.Feature.ToDos.Commands.CreateToDo;
using ClothesShop.Application.Feature.Users.Commands.CreateUser;
using ClothesShop.Application.Feature.ToDos.Queries.GetByUserId;
using ClothesShop.Application.Feature.ToDos.Commands.UpdateToDo;
using ClothesShop.Application.Feature.Users.Queries.GetUserById;
using ClothesShop.Application.Feature.Users.Queries.GetUserList;

namespace ClothesShop.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //// User mapping
        //CreateMap<CreateUserCommand, User>().ReverseMap();
        //CreateMap<User, GetUserByIdVm>().ReverseMap();
        //CreateMap<User, GetUserListVm>().ReverseMap();
        ////TODO mapping
        //CreateMap<CreateTodoCommand, TodoItem>().ReverseMap();
        //CreateMap<TodoItem, GetByUserIdVm>().ReverseMap();
        //CreateMap<TodoItem, UpdateTodoCommand>().ReverseMap();
        
    }
}

