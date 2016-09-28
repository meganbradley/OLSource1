---
title: "CDaoQueryDef::SetReturnsRecords"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "SetReturnsRecords"
  - "CDaoQueryDef.SetReturnsRecords"
  - "CDaoQueryDef::SetReturnsRecords"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryDef objects, setting whether return records"
  - "SetReturnsRecords method"
  - "ReturnsRecords property"
  - "ReturnsRecords property, querydef"
  - "CDaoQueryDef class, setting whether returns records"
ms.assetid: 9feab1fb-d3f0-40d9-ae99-9955aceefd8a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::SetReturnsRecords
Call this member function as part of the process of setting up a SQL pass-through query to an external database.  
  
## Syntax  
  
```  
  
      void SetReturnsRecords(   
   BOOL bReturnsRecords    
);  
```  
  
#### Parameters  
 *bReturnsRecords*  
 Pass **TRUE** if the query on an external database returns records; otherwise, **FALSE**.  
  
## Remarks  
 In such a case, you must create the querydef and set its properties using other `CDaoQueryDef` member functions. For a description of external databases, see [SetConnect](../vs140/cdaoquerydef--setconnect.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetReturnsRecords](../vs140/cdaoquerydef--getreturnsrecords.md)   
 [CDaoQueryDef::SetName](../vs140/cdaoquerydef--setname.md)   
 [CDaoQueryDef::SetSQL](../vs140/cdaoquerydef--setsql.md)   
 [CDaoQueryDef::SetConnect](../vs140/cdaoquerydef--setconnect.md)   
 [CDaoQueryDef::SetODBCTimeout](../vs140/cdaoquerydef--setodbctimeout.md)