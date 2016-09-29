---
title: "IConvertTypeImpl Class"
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
  - "ATL.IConvertTypeImpl<T>"
  - "IConvertTypeImpl"
  - "ATL.IConvertTypeImpl"
  - "ATL::IConvertTypeImpl"
  - "ATL::IConvertTypeImpl<T>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IConvertTypeImpl class"
ms.assetid: 7f81e79e-7d3f-4cbe-b93c-d632a94b15f6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IConvertTypeImpl Class
Provides an implementation of the [IConvertType](https://msdn.microsoft.com/en-us/library/ms715926.aspx) interface.  
  
## Syntax  
  
```  
template <class T>  
class ATL_NO_VTABLE IConvertTypeImpl   
   : public IConvertType, public CConvertHelper  
```  
  
#### Parameters  
 `T`  
 Your class, derived from `IConvertTypeImpl`.  
  
## Members  
  
### Interface Methods  
  
|||  
|-|-|  
|[CanConvert](../vs140/iconverttypeimpl--canconvert.md)|Gives information on the availability of type conversions on a command or on a rowset.|  
  
## Remarks  
 This interface is mandatory on commands, rowsets, and index rowsets. **IConvertTypeImpl** implements the interface by delegating to the conversion object supplied by OLE DB.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)