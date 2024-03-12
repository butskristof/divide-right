using ConsoleTest.Data;
using ConsoleTest.Domain;

User jos = UserRepository.GetUserById(1)!;
User fons = UserRepository.GetUserById(2)!;
User bertha = UserRepository.GetUserById(3)!;
List<Expense> expenses =
[
    new Expense
    {
        Owner = jos,
        Shares =
        [
            new ExpenseShare { Amount = 5, User = jos },
            new ExpenseShare { Amount = 5, User = fons },
            new ExpenseShare { Amount = 5, User = bertha },
        ],
    },
    new Expense
    {
        Owner = fons,
        Shares =
        [
            new ExpenseShare { Amount = 10, User = bertha },
        ],
    }
];