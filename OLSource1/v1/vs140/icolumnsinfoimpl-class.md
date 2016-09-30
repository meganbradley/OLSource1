---
title: "IColumnsInfoImpl Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL.IColumnsInfoImpl<T>"
  - "ATL::IColumnsInfoImpl"
  - "IColumnsInfoImpl"
  - "ATL.IColumnsInfoImpl"
  - "ATL::IColumnsInfoImpl<T>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IColumnsInfoImpl class"
ms.assetid: ba74c1c5-2eda-4452-8b57-84919fa0d066
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IColumnsInfoImpl Class
Provides an implementation of the [IColumnsInfo](https://msdn.microsoft.com/en-us/library/ms724541.aspx) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetColumnInfo](../vs140/icolumnsinfoimpl--getcolumninfo.md)|Returns the column metadata needed by most consumers.|  
|[MapColumnIDs](../vs140/icolumnsinfoimpl--mapcolumnids.md)|Returns an array of ordinals of the columns in a rowset that are identified by the specified column IDs.|  
  
## Remarks  
 A mandatory interface on rowsets and commands. To modify the behavior of your provider's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> implementation, you need to modify the provider column map.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)