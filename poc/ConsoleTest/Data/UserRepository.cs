using ConsoleTest.Domain;

namespace ConsoleTest.Data;

internal static class UserRepository
{
    private static readonly List<User> Users =
    [
        new User { Id = 1, Name = "Jos" },
        new User { Id = 2, Name = "Fons" },
        new User { Id = 3, Name = "Bertha" },
    ];

    public static User? GetUserById(int id) => Users.SingleOrDefault(u => u.Id == id);
}