---
title: Specifying Paths to External Items (Report Builder and SSRS)
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4fe513da-f3c5-479c-9fec-8662b91a0d6d
manager: mblythe
---
# Specifying Paths to External Items (Report Builder and SSRS)
You specify paths in report item properties to reference items such as drillthrough reports, subreports, and image files that are external to the report definition file and are stored on a report server.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
> [!NOTE]  
>  In Report Builder, paths to items must specify items on a report server. Paths to items on a file system are not supported. You can preview a report that uses these items only if you are connected to the report server where the items are located.  
  
 When you specify a path for an external item in a dialog box for actions, subreports, or images, you can browse directly to the report server and select the item. Browsing to an item and selecting it directly is the recommended way to specify a drillthrough report or subreport. That way the correct parameter names will be available in a drop-down list when you specify report or subreport parameters. When you change an item path to point to a different item, you must manually update the correct parameter names and values as needed.  
  
 On a report server configured in native mode, specify a drillthrough report name without the file extension .rdl.  
  
 On a report server configured in SharePoint integrated mode, you must include the file extension .rdl. The path can be one of the following:  
  
-   **A relative path to the item from the main report.** For example, ../AllSubreports/Subreport1. In this example, the **..** indicates the folder above the folder where the main report is located.  
  
    > [!NOTE]  
    >  Relative paths are not supported when the report is run inside Report Builder. To view a report that uses relative paths to external items, save the report to the report server, and run the report from there  
  
-   **A full path to the item.**  
  
    -   **On a report server:** The path starts from **/**, the Home folder. For example, /Reports/AllSubreports/Subreport1.  
  
    -   **On a SharePoint site:** You must specify the report name in an expression, with the full URL of the item and the file extension .rdl. For example, `="http://server/site/library/folder/Report1.rdl"`.  
  
## See Also  
 [Add an External Image (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-an-External-Image--Report-Builder-and-SSRS-.md)   
 [Add a Subreport and Parameters (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Subreport-and-Parameters--Report-Builder-and-SSRS-.md)   
 [Add a Drillthrough Action on a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Add-a-Drillthrough-Action-on-a-Report--Report-Builder-and-SSRS-.md)