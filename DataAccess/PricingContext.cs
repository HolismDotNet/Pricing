namespace Pricing;

public class PricingContext : DatabaseContext
{
    public override string ConnectionStringName => "Pricing";

    public DbSet<Pricing.Tier> Tiers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
