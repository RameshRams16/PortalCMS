﻿using Portal.CMS.Entities.Entities.PageBuilder;
using System.Collections.Generic;
using System.Linq;

namespace Portal.CMS.Entities.Seed
{
    public static class PageSectionTypeSeed
    {
        public static void Seed(PortalEntityModel context)
        {
            var sectionList = context.PageSectionTypes.ToList();

            var newSections = new List<PageSectionType>();

            if (!sectionList.Any(x => x.PageSectionTypeName == "Basic Introduction"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Basic Introduction", PageSectionTypeCategory = PageSectionTypeCategory.Header, PageSectionTypeOrder = 1, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"header background-parallax height-medium\"><div class=\"overlay-medium\"></div><div id=\"component-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container container\"><div id=\"freestyle-<componentStamp>-<sectionId>\" class=\"freestyle\"><h1 id=\"mce_0\" class=\"\" style=\"position: relative;\">Lorem Ipsum&nbsp;</h1><p style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum.&nbsp;</p></div><a id=\"component-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn square\" target=\"\">Lorem Ipsum</a></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Split Introduction"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Split Introduction", PageSectionTypeCategory = PageSectionTypeCategory.Header, PageSectionTypeOrder = 1, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"header-split background-static height-medium background-picture\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/sample-2.jpg');background-size: cover;\"><div id=\"details-wrapper-<componentStamp>-<sectionId>\" class=\"details-wrapper component-container\"><div id=\"details-<componentStamp>-<sectionId>\" class=\"details vertical-alignment component-container\"><div id=\"freestyle-<componentStamp>-<sectionId>\" class=\"freestyle\"><h1 style=\"position: relative; text-align: right;\">Lorem Ipsum</h1><p style=\"position: relative; text-align: right;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</p></div><a id=\"button-1-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn square\" target=\"\">Lorem Ipsum</a><a id=\"button-2-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn square\" target=\"\">Lorem Ipsum</a></div></div><div id=\"component-<componentStamp>-<sectionId>\" class=\"overlay overlay-light component-container ui-droppable\"></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Blank Section"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Blank Section", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Content Layout (4 Sections)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Content Layout (4 Sections)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 1, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"component-1487530603387-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"freestyle-1487530606675-<sectionId>\" class=\"freestyle\"><h2 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h2><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</p></div></div><div id=\"component-1487530612893-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"component-1487530614023-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"component-1487530616728-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-3 component-container ui-droppable\"><img id=\"component-1487530626529-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530632501-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530637642-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div><div id=\"component-1487530617998-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-3 component-container ui-droppable\"><img id=\"component-1487530625287-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530631281-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530636490-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div><div id=\"component-1487530618801-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-3 component-container ui-droppable\"><img id=\"component-1487530624149-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530630281-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530635379-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div><div id=\"component-1487530619538-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-3 component-container ui-droppable\"><img id=\"component-1487530623000-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530629041-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530633895-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Content Layout (3 Sections)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Content Layout (3 Sections)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 2, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"component-1487529967574-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"freestyle-1487529971147-<sectionId>\" class=\"freestyle\"><h2 id=\"mce_0\" class=\"\" style=\"position: relative;\">Lorem Ipsum</h2><p id=\"mce_1\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</p></div></div><div id=\"component-1487529975103-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"component-1487529985425-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"component-1487529988426-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><img id=\"component-1487530006570-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530018230-<sectionId>\" class=\"freestyle\"><h4>Lorem Ipsum</h4><p>Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530023018-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div><div id=\"component-1487529989922-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><img id=\"component-1487530005275-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530016949-<sectionId>\" class=\"freestyle\"><h4>Lorem Ipsum</h4><p>Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530021677-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div><div id=\"component-1487529991373-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><img id=\"component-1487530003819-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530015766-<sectionId>\" class=\"freestyle\"><h4>Lorem Ipsum</h4><p>Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530020655-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Content Layout (2 Sections)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Content Layout (2 Sections)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 3, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"component-1487530465004-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"freestyle-1487530469120-<sectionId>\" class=\"freestyle\"><h2 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h2><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</p></div></div><div id=\"component-1487530475649-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"component-1487530477075-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"component-1487530478663-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container ui-droppable\"><img id=\"component-1487530485753-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530490437-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530492862-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div><div id=\"component-1487530479899-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container ui-droppable\"><img id=\"component-1487530484722-<sectionId>\" alt=\"Flexible Image\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/sample-2.jpg\"><div id=\"freestyle-1487530489492-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div><a id=\"component-1487530491786-<sectionId>\" href=\"#\" class=\"btn\" target=\"\">Lorem Ipsum</a></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Icon Layout (6 Sections)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Icon Layout (6 Sections)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 4, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"component-1487530852136-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"freestyle-1487530863472-<sectionId>\" class=\"freestyle\"><h2 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h2><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</p></div></div><div id=\"component-1487530853596-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"component-1487530854788-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"component-1487530857498-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"component-1487530869036-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-6.png');\"></div><div id=\"freestyle-1487530877518-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div><div id=\"component-1487530858274-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"component-1487530867646-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-5.png');\"></div><div id=\"freestyle-1487530876494-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div><div id=\"component-1487530859144-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"component-1487530866658-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-4.png');\"></div><div id=\"freestyle-1487530875554-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div><div id=\"component-1487530883853-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"component-1487530893613-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-3.png');\"></div><div id=\"freestyle-1487530898258-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div><div id=\"component-1487530886423-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"component-1487530892556-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-2.png');\"></div><div id=\"freestyle-1487530896926-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div><div id=\"component-1487530888314-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"component-1487530891405-<sectionId>\" class=\"image image-icon\"></div><div id=\"freestyle-1487530895867-<sectionId>\" class=\"freestyle\"><h4 id=\"mce_0\" class=\"mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h4><p id=\"mce_1\" class=\"mce-content-body\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Information Block (Option 1)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Information Block (Option 1)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 5, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-small background-static background-colour\" style=\"background-color: #363583;\"><div id=\"container-190217190703-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"row-190217190703-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"left-190217190703-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"image-190217190703-<sectionId>\" class=\"image image-standard\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/sample-rocket.png');\"></div></div><div id=\"right-190217190703-<sectionId>\" class=\"col-xs-12 col-sm-8 component-container ui-droppable\" style=\"text-align: left;\"><h2 id=\"title-190217190703-<sectionId>\" class=\"\"><span style=\"color: #ffffff;\">LOREM IPSUM</span></h2><p id=\"text-190217190703-<sectionId>\" class=\"\"><span style=\"color: #ffffff;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</span></p><a id=\"component-1487531257348-<sectionId>\" href=\"#\" class=\"btn square\" target=\"\">Lorem Ipsum</a></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Information Block (Option 2)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Information Block (Option 2)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeId = 6, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-small background-static background-colour\" style=\"background-color: #FFFFFF;\"><div id=\"container-<componentStamp>-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"row-<componentStamp>-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"right-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-8 component-container ui-droppable\" style=\"text-align: left;\"><h2 id=\"title-<componentStamp>-<sectionId>\" class=\"\">Medium Title</h2><p id=\"text-<componentStamp>-<sectionId>\">Standard Paragraph: Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><p id=\"text-2-<componentStamp>-<sectionId>\">Standard Paragraph: Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"left-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><div id=\"image-<componentStamp>-<sectionId>\" class=\"image image-standard\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/sample-help.png');\"></div></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Recent Posts (Option 1)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Recent Posts (Option 1)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeId = 7, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"component-1487531442755-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"freestyle-1487531450085-<sectionId>\" class=\"freestyle\"><h1 id=\"mce_4\" class=\"\" style=\"position: relative;\">Lorem Ipsum</h1><p id=\"mce_5\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam mucius no cum. Cum ad iriure omnesque evertitur, mazim temporibus eu mei, no his erant ancillae.</p></div></div><div id=\"widget-1487531458355-<sectionId>\" class=\"widget-wrapper post-list-wrapper\" style=\"text-align: left;\"><div class=\"container-fluid post-list-wrapper\"><div class=\"row\"><a class=\"col-xs-12 col-sm-6 col-lg-4\" href=\"/Blog/Index/1\"><div class=\"box article-item float-container\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/sample-1.jpg'); color: white;\"><div class=\"inner\"><div title=\"Category\" class=\"category-item\"><span class=\"fa fa-tag\"></span>General</div><div title=\"Views\" class=\"hidden-xs category-item\"><span class=\"fa fa-users\"></span>0</div><div title=\"Comments\" class=\"hidden-xs category-item\"><span class=\"fa fa-comment\"></span>0</div><h3>My First Post</h3><p>This is just an example post to get you started, why not change it or create a new post?</p></div><div class=\"overlay-medium\"></div></div></a></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "FAQ Block (Option 1)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "FAQ Block (Option 1)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeId = 8, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static background-colour\" style=\"background-color: #ffffff;\"><div id=\"component-1487533931414-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"freestyle-1487533936617-<sectionId>\" class=\"freestyle\"><h1 id=\"mce_0\" class=\"tour-edit-element mce-content-body\" style=\"position: relative;\">Lorem Ipsum</h1><p id=\"mce_1\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div><div id=\"component-1487533940498-<sectionId>\" class=\"container component-container ui-droppable\"><div id=\"component-1487533942919-<sectionId>\" class=\"row component-container ui-droppable\"><div id=\"component-1487533948275-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><h3 id=\"component-1487533954558-<sectionId>\" class=\"\">Lorem Ipsum</h3><p id=\"component-1487533960481-<sectionId>\" class=\"\"><span style=\"text-align: left;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</span></p><div id=\"component-1487533965270-<sectionId>\" class=\"component-expand component-container ui-droppable\"><div id=\"component-title-1487533965271-<sectionId>\" class=\"component-expand-header ui-draggable ui-draggable-handle\"><h3 id=\"title-1487533965271-<sectionId>\" class=\"ui-draggable ui-draggable-handle\">Lorem Ipsum</h3></div><div id=\"component-expand-body-1487533965271-<sectionId>\" class=\"component-body component-container ui-droppable ui-draggable ui-draggable-handle\"><div id=\"freestyle-1487533965271-<sectionId>\" class=\"freestyle mce-content-body ui-draggable ui-draggable-handle\"><p id=\"mce_2\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div><div id=\"component-1487533970225-<sectionId>\" class=\"component-expand component-container ui-droppable\"><div id=\"component-title-1487533970225-<sectionId>\" class=\"component-expand-header ui-draggable ui-draggable-handle\"><h3 id=\"title-1487533970225-<sectionId>\" class=\"ui-draggable ui-draggable-handle\">Lorem Ipsum</h3></div><div id=\"component-expand-body-1487533970225-<sectionId>\" class=\"component-body component-container ui-droppable ui-draggable ui-draggable-handle\"><div id=\"freestyle-1487533970225-<sectionId>\" class=\"freestyle mce-content-body ui-draggable ui-draggable-handle\"><p id=\"mce_3\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div></div><div id=\"component-1487533949100-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><h3 id=\"component-1487533956035-<sectionId>\" class=\"\">Lorem Ipsum</h3><p id=\"component-1487533959356-<sectionId>\" class=\"\"><span style=\"text-align: left;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</span></p><div id=\"component-1487533964121-<sectionId>\" class=\"component-expand component-container ui-droppable\"><div id=\"component-title-1487533964121-<sectionId>\" class=\"component-expand-header ui-draggable ui-draggable-handle\"><h3 id=\"title-1487533964121-<sectionId>\" class=\"ui-draggable ui-draggable-handle\">Lorem Ipsum</h3></div><div id=\"component-expand-body-1487533964121-<sectionId>\" class=\"component-body component-container ui-droppable ui-draggable ui-draggable-handle\"><div id=\"freestyle-1487533964121-<sectionId>\" class=\"freestyle mce-content-body ui-draggable ui-draggable-handle\"><p id=\"mce_4\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div><div id=\"component-1487533969209-<sectionId>\" class=\"component-expand component-container ui-droppable\"><div id=\"component-title-1487533969209-<sectionId>\" class=\"component-expand-header ui-draggable ui-draggable-handle\"><h3 id=\"title-1487533969209-<sectionId>\" class=\"ui-draggable ui-draggable-handle\">Lorem Ipsum</h3></div><div id=\"component-expand-body-1487533969209-<sectionId>\" class=\"component-body component-container ui-droppable ui-draggable ui-draggable-handle\"><div id=\"freestyle-1487533969209-<sectionId>\" class=\"freestyle mce-content-body ui-draggable ui-draggable-handle\"><p id=\"mce_5\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div></div><div id=\"component-1487533950046-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container ui-droppable\"><h3 id=\"component-1487533957166-<sectionId>\" class=\"\">Lorem Ipsum</h3><p id=\"component-1487533958067-<sectionId>\" class=\"\"><span style=\"text-align: left;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</span></p><div id=\"component-1487533963125-<sectionId>\" class=\"component-expand component-container ui-droppable\"><div id=\"component-title-1487533963125-<sectionId>\" class=\"component-expand-header ui-draggable ui-draggable-handle\"><h3 id=\"title-1487533963125-<sectionId>\" class=\"ui-draggable ui-draggable-handle\">Lorem Ipsum</h3></div><div id=\"component-expand-body-1487533963125-<sectionId>\" class=\"component-body component-container ui-droppable ui-draggable ui-draggable-handle\"><div id=\"freestyle-1487533963125-<sectionId>\" class=\"freestyle mce-content-body ui-draggable ui-draggable-handle\"><p id=\"mce_6\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div><div id=\"component-1487533968204-<sectionId>\" class=\"component-expand component-container ui-droppable\"><div id=\"component-title-1487533968204-<sectionId>\" class=\"component-expand-header ui-draggable ui-draggable-handle\"><h3 id=\"title-1487533968204-<sectionId>\" class=\"ui-draggable ui-draggable-handle\">Lorem Ipsum</h3></div><div id=\"component-expand-body-1487533968204-<sectionId>\" class=\"component-body component-container ui-droppable ui-draggable ui-draggable-handle\"><div id=\"freestyle-1487533968204-<sectionId>\" class=\"freestyle mce-content-body ui-draggable ui-draggable-handle\"><p id=\"mce_7\" class=\"\" style=\"position: relative;\">Lorem ipsum dolor sit amet, graecis consectetuer duo ad. Eu ius duis propriae mediocritatem, nullam.</p></div></div></div></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Contact Form"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Contact Form", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeOrder = 1, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"contact background-parallax height-medium\"><div class=\"overlay overlay-dark\"></div><div class=\"inner\"><div id=\"container-<componentStamp>-<sectionId>\" class=\"container component-container\"><form action=\"/Build/Contact\" method=\"post\"><h2 id=\"title-<componentStamp>-<sectionId>\">Send an Email</h2><p id=\"text-<componentStamp>-<sectionId>\">We love receiving feedback, both positive and constructive. Please send us your thoughts using the form below, we generally respond within 24 hours.</p><input id=\"pageSectionId\" name=\"pageSectionId\" style=\"display: none;\" value=\"<sectionId>\"><div class=\"row\"><div class=\"col-xs-12 col-sm-6\"><input id=\"yourName\" placeholder=\"Name (Required)\" name=\"yourName\"><input id=\"yourEmail\" placeholder=\"Email Address (Required)\" name=\"yourEmail\"><input id=\"yourSubject\" placeholder=\"Subject\" name=\"yourSubject\"></div><div class=\"col-xs-12 col-sm-6\"><textarea id=\"yourMessage\" placeholder=\"Message (Required)\" name=\"yourMessage\"></textarea></div><div class=\"col-xs-12\"><button>Send Message</button></div></div></form></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Block Text"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Block Text", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeOrder = 2, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"block block-text height-tiny\"><h2 id=\"title-<sectionId>\">Call for a Quote</h2><h2 id=\"subtitle-<sectionId>\">00000 000 000</h2></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Highlight"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Highlight", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeOrder = 3, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"highlight height-standard background-parallax\" style=\"background-size: cover;\"><div id=\"component-container-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h2 id=\"title-<componentStamp>-<sectionId>\" style=\"color: rgb(255, 255, 255);\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h2><p id=\"text-1-<componentStamp>-<sectionId>\" style=\"color: rgb(255, 255, 255);\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><p id=\"text-2-<componentStamp>-<sectionId>\" style=\"color: rgb(255, 255, 255);\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"overlay-<componentStamp>-<sectionId>\" class=\"overlay overlay-medium\"></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Quote"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Quote", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeOrder = 4, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"quote\"><div class=\"quote-image-left\"></div><div class=\"quote-image-right\"></div><div id=\"container-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h2 id=\"quote-<componentStamp>-<sectionId>\">Perfection is not attainable, but if we chase perfection we can catch.</h2><p id=\"component-<componentStamp>-<sectionId>\">Tom McClean</p></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Photo Gallery"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Photo Gallery", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeOrder = 5, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"gallery height-standard background-parallax\"><div id=\"image-1-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-1.jpg');\"></div><div id=\"image-2-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-2.jpg');\"></div><div id=\"image-3-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-3.jpg');\"></div><div id=\"image-4-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-4.jpg');\"></div></section>" });

            if (newSections.Any())
                context.PageSectionTypes.AddRange(newSections);
        }
    }
}