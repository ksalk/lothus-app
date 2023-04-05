using System;

namespace Lothus.Features.Users.Domain.Users;

// TODO: to inherit from base entity and aggregate classes/interfaces
public class User
{
    protected User(string username)
    {
        Id = Guid.NewGuid();
        UserName = username;
    }

    public Guid Id { get; private set; }

    public string UserName { get; private set; }

    public byte[] PasswordHash { get; private set; }

    public byte[] PasswordSalt { get; private set; }

    
    public static User Create(string username)
    {
        return new User(username);
    }
}