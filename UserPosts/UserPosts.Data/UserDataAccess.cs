using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class UserDataAccess : BaseDataAccess<User>, IUserRepository
    {
        protected override string GetFile()
        {
            return @"C:\Users\Robert\source\repos\Homework_11_1\UserPosts\UserPosts.Data\Files\users.json";
        }
    }
}
