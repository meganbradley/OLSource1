---
title: "Add Custom Locations to a Map (Report Builder and SSRS)"
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
ms.assetid: 7d36faae-5bcc-446a-9eba-f42349cafacb
caps.latest.revision: 11
manager: mblythe
---
# Add Custom Locations to a Map (Report Builder and SSRS)
After you add a map to a report, you can add your own point locations.  
  
 Display properties for all points on a layer are controlled by setting options for the point properties for the layer. For a selected embedded point, you can override the display properties.  
  
> [!NOTE]  
>  When you override the layer display properties for the embedded point, the changes that you make are not reversible.  
  
 For more information, see [Vary Polygon, Line, and Point Display by Rules and Analytical Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Vary-Polygon--Line--and-Point-Display-by-Rules-and-Analytical-Data--Report-Builder-and-SSRS-.md).  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
### To add a point layer  
  
1.  On the report design surface, click the map to select it and display the Map pane.  
  
2.  On the toolbar, click **Add Layer**.  
  
3.  From the drop-down list, click **Add Point Layer**. A point layer with no points is added to the map. By default, the point layer is ready for embedded points.  
  
### To add a custom point  
  
1.  On the report design surface, click the map to select it and display the Map pane.  
  
2.  In the Map pane, right-click a point layer that has type **Embedded**, and then click **Add Point**. The cursor changes to crosshairs.  
  
3.  To add a point, click a location on the map. An embedded point is added to the selected layer at the location where you click.  
  
### To customize the display for an embedded point  
  
1.  Right-click the point, and then click **Point Properties**. The **Map Embedded Point Properties** dialog box opens.  
  
2.  Click **Override point options for this layer**. Multiple property pages appear in the left pane.  
  
3.  Click the pages and set the display properties that you want to apply to this point.  
  
## See Also  
 [Maps (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Maps--Report-Builder-and-SSRS-.md)   
 [Vary Polygon, Line, and Point Display by Rules and Analytical Data (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Vary-Polygon--Line--and-Point-Display-by-Rules-and-Analytical-Data--Report-Builder-and-SSRS-.md)