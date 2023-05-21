namespace AuthenticationWithDb.Services.AuthService
{
    public interface IAuthService
    {
        Task<User> RegisterUser(UserDto request);
    }
}
