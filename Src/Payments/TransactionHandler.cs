

class TransactionHandler
{
    private float amount;

    public TransactionHandler(float amount)
    {
        this.amount = amount;
    }

    public void connectPaymentAccount(PaymentProvider provider)
    {
        throw new NotImplementedException();
    }

    public void connectPayoutAccount(PaymentProvider provider)
    {
        throw new NotImplementedException();
    }

    public bool executePayment()
    {
        throw new NotImplementedException();
    }
}