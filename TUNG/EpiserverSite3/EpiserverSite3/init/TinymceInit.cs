using EPiServer.Cms.TinyMce.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace EpiserverSite3.init
{
    [ModuleDependency(typeof(TinyMceInitialization))]
    public class TinymceInit : IConfigurableModule
    {
        public const string Toolbar = "styleselect | bold italic pastetext | epi-link unlink anchor image epi-image-editor | bullist numlist outdent indent | table htmlcode | searchreplace fullscreen help";
        private ServiceConfigurationContext _serviceConfigurationContext;
        public void Initialize(InitializationEngine context)
        {
            _serviceConfigurationContext.Services.Configure<TinyMceConfiguration>(config =>
            {
                // Add content CSS to the default settings.
                config.Default()
                    .ContentCss("/tinymce/tinymce.css");

                config.Default()
                .Toolbar(Toolbar)
                .StyleFormats(
                    new { title = "Paragraph", block = "p" },
                    new { title = "H1", block = "h1" },
                    new { title = "H2", block = "h2" },
                    new { title = "H3", block = "h3" },
                    new { title = "H4", block = "h4" }
                );

                config.Default()
                    .AddSetting("valid_elements", "*[*]")
                    .AddSetting("extended_valid_elements", " button[class|onclick|title], i[class], a[onclick |class|href|target=_blank],script[charset | defer | language | src | type],style,script[async | charset | defer | src | type | id]")
                    .AddSetting("valid_children", "+div[i]")
                    .AddSetting("powerpaste_word_import", "clean")
                    .AddSetting("powerpaste_html_import", "merge")
                    .AddPlugin("anchor")
                    .AddSetting("table_toolbar", "tableprops tabledelete | tableinsertrowbefore tableinsertrowafter tabledeleterow | tableinsertcolbefore tableinsertcolafter tabledeletecol")
                    .AddPlugin("table")
                    .AddPlugin("link")
                    .AddExternalPlugin("htmlcode", "/tinymce/html.js");
            });
        }
        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            _serviceConfigurationContext = context;
        }
    }
}