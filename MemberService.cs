namespace AndrewDemo.MinimalAPI;

public class MemberService {

    public MemberService(MemberRepo repo)
    {
        throw new NotImplementedException();
    }


    public MemberModel Register(string email, string password)
    {
        throw new NotImplementedException();
    }

    public string CreateVerifyCode(string email)
    {
        throw new NotImplementedException();
    }

    public string CreateResetPassowrdCode(string email)
    {
        throw new NotImplementedException();
    }

    public MemberModel VerifyEmail(string code)
    {
        throw new NotImplementedException();
    }

    public MemberModel ResetPassword(string code, string newPassword)
    {
        throw new NotImplementedException();
    }

    public string Login(string email, string password)
    {
        throw new NotImplementedException();
    }

    public MemberModel Ban(string email, string bannedNotes)
    {
        throw new NotImplementedException();
    }

    public MemberModel Remove(string email)
    {
        throw new NotImplementedException();
    }
}



internal class MemberRepo
{
    public Dictionary<int, MemberModel> Members = null;

    public Dictionary<int, (string code, DateTime expireAt)> ResetPasswordCodes = null;

    public Dictionary<int, (string code, DateTime expireAt)> VerifyEmailCodes = null;

    //public IQueryable<MemberModel> Members { get { return this._members.Values.AsQueryable<MemberModel>(); } }
}