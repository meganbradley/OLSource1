---
title: "ICommandPropertiesImpl Class"
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
  - "ICommandPropertiesImpl"
  - "ATL.ICommandPropertiesImpl"
  - "ATL::ICommandPropertiesImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ICommandPropertiesImpl class"
ms.assetid: b3cf6aea-527e-4f0d-96e0-669178b021a2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ICommandPropertiesImpl Class
Provides an implementation of the [ICommandProperties](https://msdn.microsoft.com/en-us/library/ms723044.aspx) interface.  
  
## Syntax  
  
```  
template <class T, class PropClass = T>  
class ATL_NO_VTABLE ICommandPropertiesImpl   
   : public ICommandProperties, public CUtlProps<PropClass>  
```  
  
#### Parameters  
 `T`  
 Your class, derived from  
  
 `PropClass`  
 Your properties class.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[GetProperties](../vs140/icommandpropertiesimpl--getproperties.md)|Returns the list of properties in the Rowset property group that are currently requested for the rowset.|  
|[SetProperties](../vs140/icommandpropertiesimpl--setproperties.md)|Sets properties in the Rowset property group.|  
  
## Remarks  
 This is mandatory on commands. The implementation is provided by a static function defined by the [BEGIN_PROPSET_MAP](../vs140/begin_propset_map.md) macro.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)