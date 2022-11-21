namespace AndrewDemo.MinimalAPI;

public class MemberModel
{
    public int Id { get;set; }

    public string Email { get; set; }

    public byte[] PasswordHash { get;set;}

    public MemberStateEnum State { get; set; }
}


public enum MemberStateEnum : int
{
    UNVERIFIED = 1,
    VERIFIED = 2,
    BANNED = 3,
    ARCHIVED = 4,
}


