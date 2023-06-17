using System.ComponentModel.DataAnnotations;

namespace VocabularyBuilder.Entities.Topics;

public sealed class Topic: BaseEntity
{
    [MaxLength(50)]
    public string TopicName { get; set; } = string.Empty;

}
