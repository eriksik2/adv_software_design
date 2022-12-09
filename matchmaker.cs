

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

    private Scorer scorer = new Scorer();
}

class Scorer {
    public int getScore(Preferences jobPref, ResponderProfile responder) {
        throw new NotImplementedException();
    }
}