class CreditCard : PaymentProvider
{
    private string bankName;
    private string cardNumber;
    private string cvc;
    private string expiryDate;
    private string cardholderName;

    public CreditCard(string bankName, string cardNumber, string cvc, string expiryDate, string cardholderName)
    {
        this.bankName = bankName;
        this.cardNumber = cardNumber;
        this.cvc = cvc;
        this.expiryDate = expiryDate;
        this.cardholderName = cardholderName;
    }

    public override bool widthdrawal(float amount)
    {
        throw new NotImplementedException();
    }

    public override void deposit(float amount)
    {
        throw new NotImplementedException();
    }
}