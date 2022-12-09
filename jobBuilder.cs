class JobBuilder
{
    private int? minResponders;
    private int? maxResponders;
    private string? description;
    private Location? location;
    private string? name;
    private Preferences? preferences;
    private Preferences? requirements;
    private User? requester;

    public void setRequester(User requester)
    {
        this.requester = requester;
    }

    public void setMinResponders(int minResponders)
    {
        this.minResponders = minResponders;
    }

    public void setMaxResponders(int maxResponders)
    {
        this.maxResponders = maxResponders;
    }

    public void setDescription(string description)
    {
        this.description = description;
    }

    public void setLocation(Location location)
    {
        this.location = location;
    }

    public void setName(string name)
    {
        this.name = name;
    }
    
    public void setPreferences(Preferences preferences)
    {
        this.preferences = preferences;
    }

    public void setRequirements(Preferences requirements)
    {
        this.requirements = requirements;
    }

    public Job build()
    {
        throw new NotImplementedException();
    }
}