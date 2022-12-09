
class UserNotifier
{
    private UserNotifier? userNotifier;

    public UserNotifier getUserNotifier()
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