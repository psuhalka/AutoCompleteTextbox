using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoCompleteTextbox.Startup))]
namespace AutoCompleteTextbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
