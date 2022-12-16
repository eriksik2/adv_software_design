
class Scorer {
    public int getScore(Preferences jobPref, ResponderProfile responder) {
        var rnd = new Random();
        return rnd.Next(0, 100);
    }
}