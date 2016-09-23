---
title: "Reference: Query Designer Properties"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - queries [Visual Studio LightSwitch], Properties window
  - queries [Visual Studio LightSwitch], properties
  - queries [Visual Studio LightSwitch], configuring
ms.assetid: dcfbc0ee-2cd3-4e5c-acd3-41f91d47fc28
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Reference: Query Designer Properties
You can modify the appearance and behavior of a query by setting the value of properties in the **Properties** window. The following tables describe each property.  
  
## General  
  
|Name|Description|  
|----------|-----------------|  
|**Number of Results Returned**|Indicates whether the query returns one row or multiple rows. Select one of the following values:<br /><br /> -   **Many** if you intend for this query to return a collection of rows (For example: a collection of customers).<br />-   **One** if you intend for this query to return only one row (For example: a customer). If no data matches the conditions of the query, the query returns `null` or `Nothing` in Visual Basic. If more than one row of data matches the conditions of the query, an `InvalidOperationException` is thrown.|  
|**Name**|The name of the query.|  
|**Is Optional**|Indicates whether a parameter value is required or optional. Select one of the following values:<br /><br /> -   `True` if you want the query to exclude filter conditions that use the parameter when the value of the parameter is null.<br />-   `False` if you want the query to include filter conditions that use the parameter when the value of the parameter is null. Each row of data will be tested for the presence of a null value.<br /><br /> Applies to query parameters only.|  
|**Source**|The data source of the query (For example: the `Customers` entity set).|  
|**Return Type**|The entity that the query returns when the query is executed.|  
  
## Appearance  
  
|Name|Description|  
|----------|-----------------|  
|**Description**|The text that appears as a tooltip.|  
|**Display Name**|The name that appears on the screen.|  
  
## See Also  
 [Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md)   
 [Reference: Data Designer Properties](../vs140/reference--data-designer-properties.md)   
 [Queries: Retrieving Information from a Data Source](../vs140/queries--retrieving-information-from-a-data-source.md)