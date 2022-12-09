
class RepositoryFilter
{
    private int? minAge;
    private int? maxAge;
    private List<JobCategory> requiredSkills = new List<JobCategory>();

    private Location? location;


    public RepositoryFilter withMinAge(int minAge)
    {
        throw new NotImplementedException();
    }

    public RepositoryFilter withMaxAge(int maxAge)
    {
        throw new NotImplementedException();
    }

    public RepositoryFilter withSkill(JobCategory skill)
    {
        throw new NotImplementedException();
    }

    public RepositoryFilter atLocation(Location location)
    {
        throw new NotImplementedException();
    }
    
}