---
title: "CDBPropIDSet Class"
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
  - "CDBPropIDSet"
  - "ATL.CDBPropIDSet"
  - "ATL::CDBPropIDSet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDBPropIDSet class"
ms.assetid: 52bb806c-9581-494d-9af7-50d8a4834805
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBPropIDSet Class
Inherits from the **DBPROPIDSET** structure and adds a constructor that initializes key fields as well as the [AddPropertyID](../vs140/cdbpropidset--addpropertyid.md) access method.  
  
## Syntax  
  
```  
class CDBPropIDSet : public tagDBPROPIDSET  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AddPropertyID](../vs140/cdbpropidset--addpropertyid.md)|Adds a property to the property ID set.|  
|[CDBPropIDSet](../vs140/cdbpropidset--cdbpropidset.md)|Constructor.|  
|[SetGUID](../vs140/cdbpropidset--setguid.md)|Sets the GUID of the property ID set.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/cdbpropidset--operator-=.md)|Assigns the contents of one property ID set to another.|  
  
## Remarks  
 OLE DB consumers use **DBPROPIDSET** structures to pass an array of property IDs for which the consumer wants to get property information. The properties identified in a single [DBPROPIDSET](https://msdn.microsoft.com/en-us/library/ms717981.aspx) structure belong to one property set.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)