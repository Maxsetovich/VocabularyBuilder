using System.ComponentModel.DataAnnotations;

namespace VocabularyBuilder.Entities.Results;

public sealed class Result: BaseEntity
{
    public int TopicId { get; set; }

    public short ResultTopic { get; set; }

}
