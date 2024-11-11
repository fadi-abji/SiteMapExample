using DotnetSitemapGenerator;

namespace SiteMapExample.Sitemap.Providers;

public interface ISitemapUrlProvider
{
    Task<IReadOnlyCollection<SitemapNode>> GetNodes();
}