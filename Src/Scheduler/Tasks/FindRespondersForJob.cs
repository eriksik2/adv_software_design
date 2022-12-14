
class FindRespondersForJob : Task
{
    private JobProcess jobProcess;

    public FindRespondersForJob(JobProcess jobProcess)
    {
        this.jobProcess = jobProcess;
    }

    public override void run()
    {
        var job = jobProcess.getJob();
        var requirements = job.getRequirements();
        var preferences = job.getPreferences();
        var requester = job.getRequester();

        var missing = job.getMaxResponders() - jobProcess.getResponders().Count;
        if (missing <= 0)
        {
            return;
        }

        // Begin matching
        var bestMatches = Matchmaker.getMatchmaker().getBestMatches(requirements, preferences, max: missing);

        // If has no responders
        if (bestMatches.Count == 0)
        {
            // Notify requester that no responders found
            var notification = new JobMatchResultNotification(job, new List<ResponderProfile>());
            UserNotifier.getUserNotifier().notify(requester, notification);
            return;
        }
        else
        {   
            // For top N responders
            var notification = new OfferedJobNotification(job);
            foreach (var responder in bestMatches)
            {
                // Notify responders
                var user = responder.getUser();
                UserNotifier.getUserNotifier().notify(user, notification);
            }
        }
    }
}