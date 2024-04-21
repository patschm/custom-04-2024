using ACME.Domain.Abstractions;
using ACME.Domain.Abstractions.ValueObjects;

namespace ACME.Domain.Reviews.Reviewers;

public class Reviewer : Entity
{
    private Reviewer(long id, Name name, Name userName, Email email, string? password) : base(id) 
    {
        Name = name;
        UserName = userName;
        Email = email;
        Password = password;
    }       
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Name UserName { get; private set; }
    public string? Password { get; private set; }

    public static Reviewer Create(long id, Name name, Name userName, Email email, string? password)
    {
        var reviewer =  new Reviewer(id, name, userName, email, password);
        return reviewer;
    }
}
