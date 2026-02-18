using AZ204Notes.Application.Interfaces;
using AZ204Notes.Domain.Entities;

namespace AZ204Notes.Application.UseCases
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers() => _userRepository.GetAll();

        public User GetUser(int id) => _userRepository.GetById(id);
    }
}
