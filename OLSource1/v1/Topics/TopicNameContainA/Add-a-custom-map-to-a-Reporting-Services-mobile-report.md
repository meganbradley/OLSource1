---
title: Add a custom map to a Reporting Services mobile report
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fd259b95-bb58-4eb1-a436-6aa12fc6f5f2
manager: mblythe
---
# Add a custom map to a Reporting Services mobile report
Custom maps require two files:  
* An .SHP file for shape geometries  
* A .DBF file for metadata  
  
Read more about [custom maps in Reporting Services mobile reports](../../Topics/TopicNameNotContainA/Custom-maps-in-Reporting-Services-mobile-reports.md).  
  
Store the two files in the same folder. The file names of the two must match (e.g., canada.shp and canada.dbf). The metadata (DBF file) must include the field "NAME" with the value of the corresponding shape's name (key), to be used when populating the map with data.   
  
## Load a custom map  
  
1. On the **Layout** tab, select a map type: **Gradient Heat Map**, **Range Stop Heat Map**, or **Bubble Map**, drag it to the design surface, and make it the size you want.  
  
   ![SSMRP_MapsGallery](../../Topics/TopicNameContainA/media/SSMRP_MapsGallery.png)  
  
2. In **Layout** view > **Visual Properties** panel > **Map**, select **Custom Map From File**.   
  
   ![SSMRP_SelectCustomMap](../../Topics/TopicNameContainA/media/SSMRP_SelectCustomMap.png)  
  
3. In the **Open** dialog box, browse to the location of the SHP and DBF files and select both of them.   
  
   ![SSMRP_SelectDBFandSHP](../../Topics/TopicNameContainA/media/SSMRP_SelectDBFandSHP.png)  
  
## Connect data to a custom map  
When you first add the custom map to your report, [!INCLUDE[SS_MobileReptPub_Short](../../Topics/TopicNameContainA/includes/SS_MobileReptPub_Short.md)] populates it with simulated geography data.  
  
![SSMRP_MapsData](../../Topics/TopicNameContainA/media/SSMRP_MapsData.png)  
  
Displaying real data in your custom map is the same as displaying data in the built-in maps. Follow the steps in [Maps in Reporting Services mobile reports](../../Topics/TopicNameNotContainA/Maps-in-Reporting-Services-mobile-reports.md) to display your data.  
  
### See also  
- [Custom maps in Reporting Services mobile reports](../../Topics/TopicNameNotContainA/Custom-maps-in-Reporting-Services-mobile-reports.md)  
- [Maps in Reporting Services mobile reports](../../Topics/TopicNameNotContainA/Maps-in-Reporting-Services-mobile-reports.md)  
- [Create and publish mobile reports with SQL Server Mobile Report Publisher](../../Topics/TopicNameNotContainA/Create-mobile-reports-with-SQL-Server-Mobile-Report-Publisher.md)   
  
  
  
  
