
class User
{
    private List<PaymentProvider> paymentProviders = new List<PaymentProvider>();
    private ResponderProfile? responderProfile;

    public List<PaymentProvider> getPaymentProviders()
    {
        return paymentProviders;
    }

    public ResponderProfile? getResponderProfile()
    {
        return responderProfile;
    }
}