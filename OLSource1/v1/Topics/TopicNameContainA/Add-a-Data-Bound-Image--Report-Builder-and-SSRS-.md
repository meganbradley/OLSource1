---
title: Add a Data-Bound Image (Report Builder and SSRS)
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
ms.assetid: df4c38d4-bfcc-41c4-aa6d-952ca6fd7a2e
manager: mblythe
---
# Add a Data-Bound Image (Report Builder and SSRS)
A report can include a reference to an image that is stored in a database. Such an image is known as a *data-bound image*. The pictures that appear alongside product names in a product list are examples of data-bound images.  
  
 Adding a data-bound image to a page header or page footer requires additional steps. For more information, see [Page Headers and Footers (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Page-Headers-and-Footers--Report-Builder-and-SSRS-.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To add a data-bound image  
  
1.  In report design view, create a table with a data source connection and a dataset with a field that contains binary image data. For more information, see [Tables (Report Builder  and SSRS)](../../Topics/TopicNameNotContainA/Tables--Report-Builder--and-SSRS-.md).  
  
2.  Insert a column in your table. For more information, see [Insert or Delete a Column (Report Builder and SSRS)](../../Topics/TopicNameContainA/Insert-or-Delete-a-Column--Report-Builder-and-SSRS-.md).  
  
3.  On the **Insert** menu, click **Image**, and then click in the data row of the new column.  
  
4.  On the General page of the **Image Properties** dialog box, type a name in the **Name** text box or accept the default.  
  
5.  (Optional) In the **Tooltip** text box, type text to display when the user hovers over the image in the report rendered for HTML.  
  
6.  In **Select the image source**, select **Database**.  
  
7.  In **Use this Field**, select the field that contains images in your report.  
  
8.  In **Use this MIME type**, select the MIME type, or file format, of the image—for example, bmp.  
  
9. [!INCLUDE[clickOK](../../Topics/TopicNameContainA/includes/clickOK_md.md)]  
  
     An image placeholder appears on the report design surface.  
  
## See Also  
 [Images (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Images--Report-Builder-and-SSRS-.md)   
 [Embed an Image in a Report (Report Builder and SSRS)](../../Topics/TopicNameContainA/Embed-an-Image-in-a-Report--Report-Builder-and-SSRS-.md)   
 [Add an External Image (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Add-an-External-Image--Report-Builder-and-SSRS-.md)   
 [Image Properties Dialog Box, General (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Image-Properties-Dialog-Box--General--Report-Builder-and-SSRS-.md)