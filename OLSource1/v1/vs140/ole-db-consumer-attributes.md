---
title: "OLE DB Consumer Attributes"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - attributes [C++], database
  - attributes [C++], data access
  - databases [C++], attributes
  - OLE DB consumers [C++], attributes
  - database attributes [C++]
  - attributes [C++], OLE DB consumer
ms.assetid: 017b591f-8f9a-42b4-84d5-cc42a21ab0cc
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# OLE DB Consumer Attributes
The OLE DB consumer attributes inject code, based on the [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates-reference.md), to create a working OLE DB consumer that performs tasks such as opening tables, executing commands, and accessing data.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[db_accessor](../vs140/db_accessor.md)|Binds columns in a rowset and binds them to the corresponding accessor maps.|  
|[db_column](../vs140/db_column.md)|Binds a specified column to the rowset.|  
|[db_command](../vs140/db_command.md)|Executes an OLE DB command.|  
|[db_param](../vs140/db_param.md)|Associates the specified member variable with an input or output parameter.|  
|[db_source](../vs140/db_source.md)|Creates and encapsulates a connection, through a provider, to a data source.|  
|[db_table](../vs140/db_table.md)|Opens an OLE DB table.|  
  
## See Also  
 [Attributes by Group](../vs140/attributes-by-group.md)