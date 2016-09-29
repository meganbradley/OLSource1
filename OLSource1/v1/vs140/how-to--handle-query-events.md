---
title: "How to: Handle Query Events"
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
  - "handling events of a query [Visual Studio LightSwitch]"
  - "queries [Visual Studio LightSwitch], partial methods"
  - "queries [Visual Studio LightSwitch], events"
  - "queries [Visual Studio LightSwitch], handling events"
ms.assetid: 6867d55c-8a3a-4b5e-9e81-fa209ad63a38
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Handle Query Events
You can customize your application by writing code that runs when certain query-related events occur. For example, you can extend a query by adding code to an event that occurs when the query is being processed by [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)].  
  
### To handle a query event  
  
1.  Open a query by double clicking it in the **Solution Explorer**.  
  
     The query designer opens.  
  
2.  Click the arrow next to the **Write Code** button at the top of the **Query Designer** and select the method that you want to override. The methods that can be handled by your application appear in the table below.  
  
     The Code Editor opens.  
  
3.  Place your cursor in the method that was just created and type the code that you want to run when the event occurs.  
  
## List of Query Events  
 The following table lists the query events that can be handled by your application:  
  
|**General Methods**|Description|  
|-------------------------|-----------------|  
|<QueryName\>_PreProcessQuery()|Called when the query is being formed. Enables you to further customize a query. Runs on the server.|  
|Query_Executing()|Called just before executing the query. Runs on the server.|  
|Query_Executed()|Called just after successfully executing the query. Runs on the server.|  
|Query_ExecuteFailed()|Called after a query fails to run. Runs on the server.|  
  
|Security Methods|Description|  
|----------------------|-----------------|  
|<QueryName\>_CanExecute()|Called prior to executing the query in order to check permissions for the current user. Runs on the server.|  
  
## See Also  
 [Queries: Retrieving Information from a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)   
 [How to: Handle Data Entity Events](../vs140/how-to--handle-data-events.md)   
 [How to: Handle Screen Events](../vs140/how-to--handle-silverlight-screen-events.md)