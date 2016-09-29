---
title: "How to: Handle Data Events"
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
  - "partial methods [Visual Studio LightSwitch]"
  - "events [Visual Studio LightSwitch]"
  - "handling events [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], adding code"
  - "data [Visual Studio LightSwitch], partial methods"
  - "data [Visual Studio LightSwitch], events"
ms.assetid: 63f2ec8d-ba3d-4c3a-9d70-9b1581f6934c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Handle Data Events
You can customize your application by writing code that runs when certain data events happen. For example, you can write code that will run when rows of data in a table are created, accessed, modified, or deleted. You can also write code to verify that a user has permission to modify the data source.  
  
 The events you can handle can be grouped into six categories:  
  
-   General methods that are run when data is created, deleted, or modified.  
  
-   Access control methods that are run when data is created, deleted, or modified.  
  
-   Query methods that are run when a data source is queried.  
  
-   Data source methods that are run when a data source is saved to.  
  
-   Property methods that are run when a property is modified.  
  
 A description of these methods appears in the tables at the end of this topic.  
  
### To handle a data-related event  
  
1.  In **Solution Explorer**, double-click an entity or table.  
  
     The entity or table opens in the **Data Designer**.  
  
2.  On the command bar in the **Data Designer**, click the arrow next to the **Write Code** button, and then select a method that you want to override. The methods that can be handled by your application appear in the tables below.  
  
    > [!NOTE]
    >  The **Property Methods** will only appear in the **Write Code** dropdown list if a property is selected in the **Data Designer.**  
  
     The **Code Editor** opens.  
  
3.  Place your cursor in the method that was just created and type the code that you want to run when the event occurs.  
  
## List of Data-Related Events  
 The following tables list the data events that can be handled by your application:  
  
|**General Methods**|Description|  
|-------------------------|-----------------|  
|<TableName\>_AllowSaveWithErrors|Indicates whether the item should be saved if the item has validation errors. Save will abort by default if the item has validation errors. Runs on the calling tier.|  
|<TableName\>_Created|Called after the item is created. Runs on the tier where the item was created.|  
|<TableSetName\>_Deleted|Called just after the item has been deleted from the data store. Runs on the server.|  
|<TableSetName\>_Deleting|Called just before the item is deleted from the data store. Runs on the server.|  
|<TableSetName\>_Inserted|Called just after the item has been inserted into the data store. Runs on the server.|  
|<TableSetName\>_Inserting|Called just before the item is inserted into the data store. Runs on the server.|  
|<TableSetName\>_Updated|Called just after the item has been updated in the data store. Runs on the server.|  
|<TableSetName\>_Updating|Called just before the item is updated in the data store. Runs on the server.|  
|<TableSetName\>_Validate|Called when an item is validated on the server.|  
  
|**Access Control Methods**|Description|  
|--------------------------------|-----------------|  
|SaveChanges_CanExecute|Called prior to saving changes in the data source to check the permission level of the current user.  Runs on the server.|  
|<TableSetName\>_CanDelete|Called prior to deleting an item to check permission level of the current user. Runs on the server.|  
|<TableSetName\>_CanInsert|Called prior to inserting an item to check the permission level of the current user. Runs on the server.|  
|<TableSetName\>_CanRead|Called prior to reading an item to check the permission level of the current user. Runs on the server.|  
|<TableSetName\>_CanUpdate|Called prior to updating an item to check the permission level of the current user. Runs on the server.|  
  
|**Query Methods**|Description|  
|-----------------------|-----------------|  
|Query_ExecuteFailed|Called after the query fails to execute. Runs on the server.|  
|Query_Executed|Called just after executing the query. This method is not called if the query fails to execute. Runs on the server.|  
|Query_Executing|Called just before executing the query. Runs on the server.|  
|<TableSetName\>_Filter|Called before the query runs, allowing for additional query customization. Runs on the server.|  
  
|**Data Source Methods**|Description|  
|-----------------------------|-----------------|  
|SaveChanges_ExecuteFailed|Called just after failing to save on the data source. Runs on the server.|  
|SaveChanges_Executed|Called just after successfully saving changes in the data source. Runs on the server.|  
|SaveChanges_Executing|Called just before saving changes in the data source. Runs on the server.|  
  
|**Property Methods**||  
|--------------------------|-|  
|<PropertyName\>_Changed|Called just after the property value for an item has changed. Runs on the tier where the property was changed.|  
|<PropertyName\>_IsReadOnly|Returns whether the property is read-only. Runs on the tier where the property is accessed.|  
|<PropertyName\>_Validate|Called when the property is validated. Runs on the tier where the property is validated.|  
  
## See Also  
 [Data and Entities: The Information Behind Your Application](../VS_csharp/data--the-information-behind-your-application.md)   
 [How to: Handle Screen Events](../VS_csharp/how-to--handle-silverlight-screen-events.md)   
 [How to: Handle Query Events](../VS_csharp/how-to--handle-query-events.md)