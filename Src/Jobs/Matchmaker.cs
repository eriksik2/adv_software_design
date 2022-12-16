
// TODO: add private constructor, init scorer there.
class Matchmaker
{
    private static Matchmaker? matchmaker;

    public static Matchmaker getMatchmaker()
    {
        if (matchmaker == null)
        {
            matchmaker = new Matchmaker();
        }
        return matchmaker;
    }

    private Matchmaker() {
        this.scorer = new Scorer();
    }

    private Scorer scorer;

    public List<ResponderProfile> getBestMatches(Preferences requirements, Preferences preferences, int max)
    {
        // Create filter
        var filter = new RepositoryFilter()
            .withMaxAge(requirements.getMaxAge())
            .withMinAge(requirements.getMinAge());
        foreach (var category in requirements.getCategories())
        {
            filter = filter.withSkill(category);
        }
        foreach (var sex in requirements.getSex())
        {
            filter = filter.withSex(sex);
        }

        // Get profiles
        var repository = ResponderProfileRepository.getRepository();
        var responders = repository.fetch(filter, max, 0);

        // Rank profiles
        foreach (var responder in responders)
        {
            var score = scorer.getScore(preferences, responder);
            responders.Sort((a, b) => {
                var sa = scorer.getScore(preferences, a);
                var sb = scorer.getScore(preferences, b);
                return sa.CompareTo(sb);
            });
        }
        return responders;
    }
}
