namespace Domain.ValueObjects;

public record TopicId
{
    public Guid Value { get; }

    private TopicId(Guid value)
    {
        this.Value = value;
    }

    public static TopicId Of(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new DomainException("Топик должен быть не пустой");
        }
        return new TopicId(value);
    }
}