---
title: "CDaoQueryDef::SetName"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDaoQueryDef.SetName
  - SetName
  - CDaoQueryDef::SetName
dev_langs: 
  - C++
helpviewer_keywords: 
  - stored queries, naming
  - saved queries
  - SetName method
  - names [C++], querydef object
  - QueryDef objects, setting names
  - saved queries, naming
  - stored queries
  - CDaoQueryDef class, setting names
ms.assetid: 60cda5c0-0b47-467b-8b0a-95becd79d243
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoQueryDef::SetName
Call this member function if you want to change the name of a querydef that is not temporary.  
  
## Syntax  
  
```  
  
      void SetName(   
   LPCTSTR lpszName    
);  
```  
  
#### Parameters  
 `lpszName`  
 A string that contains the new name for a nontemporary query in the associated [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
## Remarks  
 Querydef names are unique, user-defined names. You can call `SetName` before the querydef object is appended to the QueryDefs collection.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetName](../vs140/cdaoquerydef--getname.md)   
 [CDaoQueryDef::SetSQL](../vs140/cdaoquerydef--setsql.md)   
 [CDaoQueryDef::SetConnect](../vs140/cdaoquerydef--setconnect.md)   
 [CDaoQueryDef::SetODBCTimeout](../vs140/cdaoquerydef--setodbctimeout.md)   
 [CDaoQueryDef::SetReturnsRecords](../vs140/cdaoquerydef--setreturnsrecords.md)