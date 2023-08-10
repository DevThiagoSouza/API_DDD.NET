using Domain.Interfaces;
using Entites.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Repositories;

public class RepositotyMessage : RepositoryGenerics<Message> , IMessage
{
    private readonly DbContextOptions<ContextBase> ContextOptions;

    public RepositotyMessage()
    {
        ContextOptions = new DbContextOptions<ContextBase>();
    }
    
 
}