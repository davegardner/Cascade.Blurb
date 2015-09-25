using Orchard.UI.Resources;

namespace Cascade.Blurb {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("BlurbWidget").SetUrl("blurb-widget.js").SetDependencies("jQuery");

            manifest.DefineStyle("BlurbWidget").SetUrl("blurb-widget.css");
        }
    }
}