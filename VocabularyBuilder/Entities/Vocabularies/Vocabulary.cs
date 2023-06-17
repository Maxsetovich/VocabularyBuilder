using System.ComponentModel.DataAnnotations;

namespace VocabularyBuilder.Entities.Vocabularies;

public sealed class Vocabulary: BaseEntity
{
    public int TopicId { get; set; }

    [MaxLength(50)]
    public string EngWord { get; set; } = string.Empty;

    [MaxLength(50)]
    public string UzbWord { get; set; } = string.Empty;
}
