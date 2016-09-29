---
title: "CDaoQueryDef::GetReturnsRecords"
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
  - "CDaoQueryDef::GetReturnsRecords"
  - "CDaoQueryDef.GetReturnsRecords"
  - "GetReturnsRecords"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, determining whether returns records"
  - "ReturnsRecords property"
  - "records, querydef Returns Records property"
  - "GetReturnsRecords method"
  - "ReturnsRecords property, querydef"
  - "QueryDef objects, determining whether return records"
ms.assetid: 6d733bf9-1700-4d50-a4eb-c07df68099a1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetReturnsRecords
Call this member function to determine whether the querydef is based on a query that returns records.  
  
## Syntax  
  
```  
  
BOOL GetReturnsRecords( );  
  
```  
  
## Return Value  
 Nonzero if the querydef is based on a query that returns records; otherwise 0.  
  
## Remarks  
 This member function is only used for SQL pass-through queries. For more information about SQL queries, see the [Execute](../vs140/cdaoquerydef--execute.md) member function. For more information about working with SQL pass-through queries, see the [SetReturnsRecords](../vs140/cdaoquerydef--setreturnsrecords.md) member function.  
  
 For related information, see the topic "ReturnsRecords Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetName](../vs140/cdaoquerydef--getname.md)   
 [CDaoQueryDef::GetSQL](../vs140/cdaoquerydef--getsql.md)   
 [CDaoQueryDef::GetODBCTimeout](../vs140/cdaoquerydef--getodbctimeout.md)