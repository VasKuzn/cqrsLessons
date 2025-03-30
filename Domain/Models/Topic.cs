using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstructions;
using Domain.ValueObjects;

namespace Domain.Models
{
    public class Topic : Entity<TopicId>
    {
        public string Title { get; set; } = default!;
        public DateTime? EventStart { get; set; } = default!;
        public string Summary { get; set; } = default!;
        public string TopicType { get; set; } = default!;
        public Location Location { get; set; } = default!;

        public static Topic Create(TopicId id, string title, string summary, Location location, string topicType, DateTime eventStart)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(title);
            ArgumentException.ThrowIfNullOrWhiteSpace(summary);
            ArgumentException.ThrowIfNullOrWhiteSpace(topicType);
            Topic topic = new()
            {
                Id = id,
                Title = title,
                Summary = summary,
                TopicType = topicType,
                Location = location,
                EventStart = eventStart
            };
            return topic;
        }
    }
}