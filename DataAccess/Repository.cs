namespace Pricing;

public class Repository
{
    public static Write<Pricing.Tier> Tier
    {
        get
        {
            return new Write<Pricing.Tier>(new PricingContext());
        }
    }
}
