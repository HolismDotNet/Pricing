namespace Pricing;

public class Tier : IEntity, IKey
{
    public Tier()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Key { get; set; }

    public dynamic RelatedItems { get; set; }
}
