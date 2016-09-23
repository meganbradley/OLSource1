---
title: "BEGIN_PROPSET_MAP"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - BEGIN_PROPSET_MAP
dev_langs: 
  - C++
helpviewer_keywords: 
  - BEGIN_PROPSET_MAP macro
ms.assetid: c3a30618-6025-4d49-8688-a171294d2e93
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# BEGIN_PROPSET_MAP
Marks the beginning of the property set map entries.  
  
## Syntax  
  
```  
  
BEGIN_PROPSET_MAP(  
Class   
)  
  
```  
  
#### Parameters  
 *Class*  
 [in] The class in which this property set is specified. A property set can be specified in the following OLE DB objects:  
  
-   [Data Source Objects](https://msdn.microsoft.com/en-us/library/ms721278.aspx)  
  
-   [Session Objects](https://msdn.microsoft.com/en-us/library/ms711572.aspx)  
  
-   [Commands](https://msdn.microsoft.com/en-us/library/ms724608.aspx)  
  
## Example  
 Here is a sample property set map:  
  
 [!code[NVC_OLEDB_Provider#3](../vs140/codesnippet/CPP/begin_propset_map_1.h)]
  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../vs140/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)