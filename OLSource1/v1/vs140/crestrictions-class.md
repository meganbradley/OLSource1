---
title: "CRestrictions Class"
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
  - "ATL::CRestrictions"
  - "CRestrictions"
  - "ATL.CRestrictions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRestrictions class"
ms.assetid: 0aaa2364-641c-4318-b110-7446aada4b4f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRestrictions Class
A generic class that allows you to specify restrictions for schema rowsets.  
  
## Syntax  
  
```  
template <   
   class T,   
   short nRestrictions,   
   const GUID* pguid   
>  
class CRestrictions : public CSchemaRowset <   
   T,   
   nRestrictions   
>  
```  
  
#### Parameters  
 `T`  
 The class used for the accessor.  
  
 `nRestrictions`  
 The number of restriction columns for the schema rowset.  
  
 `pguid`  
 A pointer to the GUID for the schema.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Open](../vs140/crestrictions--open.md)|Returns a result set according to the user-supplied restrictions.|  
  
## Requirements  
 **Header:** atldbsch.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)