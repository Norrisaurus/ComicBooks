using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComicBooks.Startup))]
namespace ComicBooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
