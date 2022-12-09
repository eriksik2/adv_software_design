class JobBuilder
{
    private int minResponders;
    private int maxResponders;
    private string description;
    private Location location;
    private string name;
    private RequestPreferences preferences;
    private RequestPreferences requirements;
    private User requester;

    public setRequester(User requester)
    {
        this.requester = requester;
    }

    public setMinResponders(int minResponders)
    {
        this.minResponders = minResponders;
    }

    public setMaxResponders(int maxResponders)
    {
        this.maxResponders = maxResponders;
    }

    public setDescription(string description)
    {
        this.description = description;
    }

    public setLocation(Location location)
    {
        this.location = location;
    }

    public setName(string name)
    {
        this.name = name;
    }
    
    public setPreferences(RequestPreferences preferences)
    {
        this.preferences = preferences;
    }

    public setRequirements(RequestPreferences requirements)
    {
        this.requirements = requirements;
    }

    public Job build()
    {
        return new Job(minResponders, maxResponders, description, location, name, preferences, requirements, requester);
    }
}