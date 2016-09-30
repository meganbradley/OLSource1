---
title: "IRowsetInfoImpl Class"
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
  - "ATL.IRowsetInfoImpl"
  - "IRowsetInfoImpl"
  - "ATL::IRowsetInfoImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IRowsetInfoImpl class"
ms.assetid: 9c654155-7727-464e-bd31-143e68391a47
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetInfoImpl Class
Provides an implementation for the [IRowsetInfo](https://msdn.microsoft.com/en-us/library/ms724541.aspx) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A user-definable property class that defaults to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[GetProperties](../vs140/irowsetinfoimpl--getproperties.md)|Returns the current settings of all properties supported by the rowset.|  
|[GetReferencedRowset](../vs140/irowsetinfoimpl--getreferencedrowset.md)|Returns an interface pointer to the rowset to which a bookmark applies.|  
|[GetSpecification](../vs140/irowsetinfoimpl--getspecification.md)|Returns an interface pointer on the object (command or session) that created this rowset.|  
  
## Remarks  
 A mandatory interface on rowsets. This class implements the rowset properties by using the [property set map](../vs140/begin_propset_map.md) defined in your command class. Although the rowset class appears to be using the command class' property sets, the rowset is supplied with its own copy of the run-time properties, when it is created by a command or session object.  
  
## Requirements  
 **Header:** altdb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)