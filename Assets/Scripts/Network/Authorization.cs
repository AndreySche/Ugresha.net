namespace Ugresha
{
    public class Authorization
    {
        private UserAuth _userAuth;

        public Authorization()
        {
            _userAuth = new UserAuth();
            _userAuth.Aid = 1; // Aid <= 0 => Demo
            _userAuth.Hash = "1234567890abcdef";
        }
        public UserAuth VerifyAuth() => _userAuth;
    }
}
