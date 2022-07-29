namespace Ugresha
{
    public class Authorization
    {
        private UserAuth _userAuth;

        public Authorization()
        {
            _userAuth = new UserAuth();
            _userAuth.Aid = 0;
            _userAuth.Guest = true;
            _userAuth.Hash = "1234567890abcdef"; // 16 chars
        }
        public UserAuth VerifyAuth() => _userAuth;
    }
}
