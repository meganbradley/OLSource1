---
title: "How to: Implement Row Tracking"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ebddb41e-be3b-4d3a-b77b-79de979ac2d9
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement Row Tracking
If you implement row tracking in your LightSwitch database, you can track who added or modified row-level data and when. If the **Enable Created/Modified properties** check box is selected, **Created**, **CreatedBy**, **Modified**, and **ModifiedBy** fields are automatically added to a table when a user changes data.  
  
> [!NOTE]
>  This property is available for tables in the intrinsic database only. For attached data sources, you must implement row tracking in the data source.  
  
 The **Created** and **Modified** fields use the **DateTimeOffset** custom data type, which stores the date and time relative to Coordinated Universal Time (UTC). The **CreatedBy** and **ModifiedBy** fields use the **Person** custom data type. These four fields are hidden in the Data Designer, but they appear in the Screen Designer so that you can display them on a screen if you want.  
  
 If you implement row tracking, you can filter data based on a specific user by using the **Current User** global value. For example, you can allow users to display only those records that they created.  
  
### To implement row tracking  
  
1.  In **Solution Explorer**, open the shortcut menu for an entity or table, and then choose **Open**.  
  
2.  In the Data Designer, on the **Perspective** bar, choose the **Server** tab.  
  
3.  In the Properties window, select the **Enable Created/Modified properties** check box.  
  
    > [!NOTE]
    >  For new tables, that check box is selected by default.  
  
### To filter rows based on the current user  
  
1.  In the Data Designer, on the **Perspective** bar, choose the **Server** tab.  
  
2.  On the toolbar, choose the **Query** button.  
  
3.  In the Query Designer, choose the **Add Filter** link.  
  
4.  In the second list, choose **CreatedBy**.  
  
5.  In the fourth list, choose **Global**.  
  
6.  In the fifth list, choose **Current User**.  
  
## See Also  
 [How to: Add a Table to the LightSwitch Internal Database](../VS_csharp/how-to--add-a-table-to-the-lightswitch-internal-database.md)   
 [Queries: Retrieving Information from a Data Source](../VS_csharp/queries--retrieving-information-from-a-data-source.md)   
 [Working with the Person Data Type](../VS_csharp/working-with-the-person-data-type.md)   
 [Data: The Information Behind Your Application](../VS_csharp/data--the-information-behind-your-application.md)