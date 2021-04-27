namespace AddressBook.Core
{
    public class ServicesConfig
    {
        public static IUserRepository userRepository;
        public static IAuthRepository authRepository;

        public static void Initialize()
        {
            userRepository = new UserRepository();
            authRepository = new AuthRepository();
        }
    }
}
