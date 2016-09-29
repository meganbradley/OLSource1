---
title: "CUtlProps Class"
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
  - "CUtlProps"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CUtlProps class"
ms.assetid: bb525178-765c-4e23-a110-c0fd70c05437
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUtlProps Class
Implements properties for a variety of OLE DB property interfaces (for example, `IDBProperties`, `IDBProperties`, and `IRowsetInfo`).  
  
## Syntax  
  
```  
template < class T >  
class ATL_NO_VTABLE CUtlProps : public CUtlPropsBase  
```  
  
#### Parameters  
 `T`  
 The class that contains the `BEGIN_PROPSET_MAP`.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[GetPropValue](../vs140/cutlprops--getpropvalue.md)|Gets a property from a property set.|  
|[IsValidValue](../vs140/cutlprops--isvalidvalue.md)|Used to validate a value before setting a property.|  
|[OnInterfaceRequested](../vs140/cutlprops--oninterfacerequested.md)|Handles requests for an optional interface when a consumer calls a method on an object creation interface.|  
|[OnPropertyChanged](../vs140/cutlprops--onpropertychanged.md)|Called after setting a property to handle chained properties.|  
|[SetPropValue](../vs140/cutlprops--setpropvalue.md)|Sets a property in a property set.|  
  
## Remarks  
 Most of this class is an implementation detail.  
  
 `CUtlProps` contains two members for setting properties internally: [GetPropValue](../vs140/cutlprops--getpropvalue.md) and [SetPropValue](../vs140/cutlprops--setpropvalue.md).  
  
 For more information on the macros used in a property set map, see [BEGIN_PROPSET_MAP](../vs140/begin_propset_map.md) and [END_PROPSET_MAP](../vs140/end_propset_map.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)