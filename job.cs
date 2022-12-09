class Job
{
    private List<User> responders;
    private int minResponders;
    private int maxResponders;
    private User requester;
    private string description;
    private Location location;
    private string name;
    private RequestPreferences preferences;
    private RequestPreferences requirements;

    public getRequester()
    {
        return requester;
    }

    public getResponders()
    {
        return responders;
    }

    public getName()
    {
        return name;
    }
}