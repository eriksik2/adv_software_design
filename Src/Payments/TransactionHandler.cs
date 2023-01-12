

class TransactionHandler
{
    private float amount;
    private PaymentProvider? paymentAccount;
    private List<PaymentProvider> payoutAccounts = new List<PaymentProvider>();

    public TransactionHandler(float amount)
    {
        this.amount = amount;
    }

    public void setPaymentAccount(PaymentProvider provider)
    {
        this.paymentAccount = provider;
    }

    public void addPayoutAccount(PaymentProvider provider)
    {
        this.payoutAccounts.Add(provider);
    }

    public bool executePayment()
    {
        if (this.paymentAccount == null)
        {
            return false;
        }
        float fee = this.amount * 0.10f;
        float amount = this.amount - fee;
        float amountEach = amount / this.payoutAccounts.Count;
        paymentAccount.widthdrawal(this.amount);
        foreach (var payoutAccount in this.payoutAccounts)
        {
            payoutAccount.deposit(amountEach);
        }
        return true;
    }
}