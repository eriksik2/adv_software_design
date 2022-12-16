
static class ClientBroker
{
    public static void makeJobRequest(User requester, string message)
    {
        //
        // [Parse message]
        //
        int minResponders = 1;
        int maxResponders = 3;
        string name = "Garden Help";
        string description = "I need help with my garden";
        Location location = new Location();
        DateTime time = DateTime.Now + new TimeSpan(days: 1, 0, 0, 0);
        Preferences requirements = new Preferences(
            sex: new List<Sex>{Sex.female, Sex.male},
            categories: new List<JobCategory>{JobCategory.physicalLabor},
            minAge: 16,
            maxAge: 60
        );
        Preferences preferences = new Preferences(
            sex: new List<Sex>{Sex.female},
            categories: new List<JobCategory>{},
            minAge: 18,
            maxAge: 30
        );
        float amount = 10.0f;
        //
        // [finished parsing message]
        //
        
        // Create job
        var jobBuilder = new JobBuilder();
        jobBuilder.setRequester(requester);
        jobBuilder.setMinResponders(minResponders);
        jobBuilder.setMaxResponders(maxResponders);
        jobBuilder.setName(name);
        jobBuilder.setDescription(description);
        jobBuilder.setLocation(location);
        jobBuilder.setPreferences(preferences);
        jobBuilder.setRequirements(requirements);
        jobBuilder.setTime(time);
        var job = jobBuilder.build();

        // Connect payment account
        var transactionHandler = new TransactionHandler(amount);
        var paymentProvider = requester.getPaymentProviders()[0];
        transactionHandler.connectPaymentAccount(paymentProvider);

        // Store job process
        var jobProcessHandler = JobProcessHandler.getJobProcessHandler();
        var jobProcess = new JobProcess(job, transactionHandler);
        jobProcessHandler.addJobProcess(jobProcess);

        // Schedule matching
        Scheduler.getScheduler().schedule(new FindRespondersForJob(jobProcess));
    }

    public static void makeParticipationRequest(User responder, Job job)
    {
        // Check availability
        var jobProcess = JobProcessHandler.getJobProcessHandler().getProcess(job);
        if (jobProcess == null || jobProcess.getResponders().Count >= job.getMaxResponders())
        {
            // Notify responder (not available)
            var notificationA = new JobFullNotification(job);
            UserNotifier.getUserNotifier().notify(responder, notificationA);
            return;
        }
        // Notify requester (new responder)
        var responderProfile = responder.getResponderProfile()!;
        var notificationB = new ResponderAvailableNotification(job, responderProfile);
        UserNotifier.getUserNotifier().notify(job.getRequester(), notificationB);
    }

    public static void makeParticipationApproval(User requester, User responder, Job job)
    {
        throw new NotImplementedException();
    }

    public static void makeCompletionRequest(User responder, Job job)
    {
        throw new NotImplementedException();
    }

    public static void makeCompletionApproval(User requester, User responder, Job job)
    {
        throw new NotImplementedException();
    }

    public static void makeFeedback(User from, User target, string feedback)
    {
        throw new NotImplementedException();
    }

    public static void makeAbuseReport(User from, User target)
    {
        throw new NotImplementedException();
    }
}