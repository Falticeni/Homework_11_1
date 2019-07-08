using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public class UserCommentService
    {
        private readonly IUserRepository userRepository;
        //private readonly IPostRepository postRepository;
        private readonly ICommentRepository commentRepository;

        public UserCommentService(IUserRepository userRepository, ICommentRepository commentRepository) //IPostRepository postRepository
        {
            this.userRepository = userRepository;
            this.commentRepository = commentRepository;
        }

        public UserComments UserComments(int id)
        {
            var user = this.userRepository.GetById(id);  // user
            var comments = this.commentRepository.GetAll(); //lista cu toate comentariile

            return new UserComments
            {
                User = user,
                Comments = comments.Where(x => x.UserId == id).ToList()   // am folosit metoda ToList pt a pastra tipul IList; by default returns IEnumerable
            };
        }
    }

    public class UserComments
    {
        public User User { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
