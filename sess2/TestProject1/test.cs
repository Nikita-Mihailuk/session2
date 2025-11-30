namespace TestProject1;

public class test
{
    public static bool IsValidEmail(string email)
    {
        var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }
    public static bool IsValidPhone(string phone)
    {
        var pattern = @"^[\d+\-()\s]+$";
        return Regex.IsMatch(phone, pattern);
    }
}