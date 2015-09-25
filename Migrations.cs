using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace Orchard.Blurb
{
    public class Migrations : DataMigrationImpl
    {

        public int Create()
        {

            ContentDefinitionManager.AlterTypeDefinition("Blurb",
                cfg => cfg
                    .WithPart("CommonPart", p => p
                        .WithSetting("DateEditorSettings.ShowDateEditor", "true"))
                    .WithPart("PublishLaterPart")
                    .WithPart("TitlePart")
                    .WithPart("BodyPart")
                    .WithPart("TagsPart")
                    .Draftable()
                    .Creatable()
                );

            // BlurbWidgetPart is an empty part with no properties but it is needed
            // to create a Widget, as are all the other bits below:
            ContentDefinitionManager.AlterTypeDefinition("BlurbWidget", type => type
                .WithPart("BlurbWidgetPart")
                .WithPart("WidgetPart")
                .WithSetting("Stereotype", "Widget")
                .WithPart("CommonPart")
                );
            return 3;
        }

        //public int UpdateFrom1()
        //{
        //    ContentDefinitionManager.AlterTypeDefinition("Blurb",
        //        cfg => cfg.Creatable()
        //        );

        //    return 2;
        //}
        //public int UpdateFrom2()
        //{
        //    ContentDefinitionManager.AlterTypeDefinition("Blurb",
        //        cfg => cfg.WithPart("TagsPart")
        //        );

        //    return 3;
        //}

        //public int UpdateFrom3()
        //{
        //    ContentDefinitionManager.AlterTypeDefinition("BlurbWidget", type => type
        //        .WithPart("BlurbWidgetPart")
        //        .WithSetting("Stereotype", "Widget")
        //        );
        //    return 4;
        //}

        //public int UpdateFrom4()
        //{
        //    ContentDefinitionManager.AlterTypeDefinition("BlurbWidget", type => type
        //        .WithPart("BlurbWidgetPart")
        //        );
        //    return 5;
        //}
    }
}