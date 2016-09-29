---
title: "How to: Add a Table to the LightSwitch Internal Database"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "data [Visual Studio LightSwitch], tables"
  - "table [Visual Studio LightSwitch]"
  - "intrinsic database [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], intrinsic database"
ms.assetid: 683db6db-4349-4920-80c9-942eeec896ce
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Table to the LightSwitch Internal Database
You can add tables to the [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] internal database. Conversely, you cannot add tables or other abstractions to external data sources such as a SQL Server database, SharePoint list, or WCF RIA Service by using [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)]. For those data sources, [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] generates entities that match the structure of the data source.  
  
 For more information, see [Data and Entities: The Information Behind your Application](../VS_csharp/data--the-information-behind-your-application.md).  
  
 ![link to video](../VS_csharp/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Define My Data in a LightSwitch Application?](http://go.microsoft.com/fwlink/?LinkID=205102).  
  
### To add a table to the LightSwitch Internal Database  
  
1.  In **Solution Explorer**, click the **Data Sources** node.  
  
2.  On the **Project** menu, click **Add Table**.  
  
     A new table is opened in the data designer.  
  
     In **Solution Explorer**, [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] creates a node that represents the [!INCLUDE[smb_current_short](../VS_csharp/includes/smb_current_short_md.md)] internal database. By default, the name of the node is **ApplicationData**. The following illustration shows the **ApplicationData** node in **Solution Explorer**.  
  
     ![Intrinsic database](../VS_csharp/media/ls_intrinsic_data_source.png "LS_Intrinsic_Data_Source")  
  
3.  In the **Data Designer**, at the top of the new table, double-click the name of the table, and then type a new name.  
  
4.  Define the fields of the table. For more information, [How to: Define the Fields of an Entity](../VS_csharp/how-to--define-data-fields-in-a-lightswitch-database.md).  
  
## See Also  
 [Data and Entities: The Information Behind Your Application](../VS_csharp/data--the-information-behind-your-application.md)   
 [How to: Define the Fields of an Entity](../VS_csharp/how-to--define-data-fields-in-a-lightswitch-database.md)   
 [How to: Connect to Data](../VS_csharp/how-to--connect-to-data.md)   
 [How to: Add a Computed Field](../VS_csharp/how-to--add-a-computed-field-in-a-lightswitch-database.md)   
 [How to: Create a Choice List for an Entity Field](../VS_csharp/how-to--create-a-list-of-values-for-a-field-in-a-lightswitch-application.md)   
 [How to: Define Data Relationships in LightSwitch](../VS_csharp/how-to--define-data-relationships-in-lightswitch.md)   
 [How to: Validate Entities](../VS_csharp/how-to--validate-data-in-a-lightswitch-application.md)