using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        public string Name { get; set; }

        public string Content { get; set; }
    }
}