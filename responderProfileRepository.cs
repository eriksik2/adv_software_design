
class ResponderProfileRepository
{
    static private ResponderProfileRepository? repository;

    static public ResponderProfileRepository getRepository()
    {
        if (repository == null)
        {
            repository = new ResponderProfileRepository();
        }
        return repository;
    }

    public List<ResponderProfile> fetch(RepositoryFilter filter, int limit, int page)
    {
        throw new NotImplementedException();
    }

    public void registerResponder(ResponderProfileBuilder builder)
    {
        throw new NotImplementedException();
    }
}