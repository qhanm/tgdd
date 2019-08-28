namespace TGDD.Data.Interfaces
{
    public interface IHasSeoMetadata
    {
        string SeoPageTitle { get; set; }

        string SeoAlias { get; set; }

        string SeoKeyWords { get; set; }

        string SeoDescription { get; set; }
    }
}