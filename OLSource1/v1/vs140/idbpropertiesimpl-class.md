---
title: "IDBPropertiesImpl Class"
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
  - "IDBPropertiesImpl"
  - "ATL.IDBPropertiesImpl"
  - "ATL.IDBPropertiesImpl<T>"
  - "ATL::IDBPropertiesImpl<T>"
  - "ATL::IDBPropertiesImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDBPropertiesImpl class"
ms.assetid: a7f15a8b-95b2-4316-b944-d5d03f8d74ab
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBPropertiesImpl Class
Provides an implementation for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[GetProperties](../vs140/idbpropertiesimpl--getproperties.md)|Returns the values of properties in the Data Source, Data Source Information, and Initialization property groups that are currently set on the data source object or the values of properties in the Initialization property group that are currently set on the enumerator.|  
|[GetPropertyInfo](../vs140/idbpropertiesimpl--getpropertyinfo.md)|Returns information about all properties supported by the provider.|  
|[SetProperties](../vs140/idbpropertiesimpl--setproperties.md)|Sets properties in the Data Source and Initialization property groups, for data source objects, or the Initialization property group, for enumerators.|  
  
## Remarks  
 [IDBProperties](https://msdn.microsoft.com/en-us/library/ms719607.aspx) is a mandatory interface for data source objects and an optional interface for enumerators. However, if an enumerator exposes [IDBInitialize](https://msdn.microsoft.com/en-us/library/ms713706.aspx), it must expose <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> implements <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> by using a static function defined by [BEGIN_PROPSET_MAP](../vs140/begin_propset_map.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)