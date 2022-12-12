
class UserNotifier
{
    private static UserNotifier? userNotifier;

    public static UserNotifier getUserNotifier()
    {
        if (userNotifier == null)
        {
            userNotifier = new UserNotifier();
        }
        return userNotifier;
    }

    public void notify(User user, Notification notification)
    {
        throw new NotImplementedException();
    }
}