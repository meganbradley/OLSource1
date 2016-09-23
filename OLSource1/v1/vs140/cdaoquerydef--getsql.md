---
title: "CDaoQueryDef::GetSQL"
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
  - GetSQL
  - CDaoQueryDef::GetSQL
  - CDaoQueryDef.GetSQL
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoQueryDef class, getting information
  - GetSQL method
  - SQL strings
  - QueryDef objects, getting SQL strings
  - SQL strings, querydef
ms.assetid: 9869adb1-1c62-42d8-b23f-b7b2a63d33dc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoQueryDef::GetSQL
Call this member function to retrieve the SQL statement that defines the query on which the querydef is based.  
  
## Syntax  
  
```  
  
CString GetSQL( );  
  
```  
  
## Return Value  
 The SQL statement that defines the query on which the querydef is based.  
  
## Remarks  
 You will then probably parse the string for keywords, table names, and so on.  
  
 For related information, see the topics "SQL Property", "Comparison of Microsoft Jet Database Engine SQL and ANSI SQL", and "Querying a Database with SQL in Code" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::SetSQL](../vs140/cdaoquerydef--setsql.md)   
 [CDaoQueryDef::GetName](../vs140/cdaoquerydef--getname.md)   
 [CDaoQueryDef::GetReturnsRecords](../vs140/cdaoquerydef--getreturnsrecords.md)   
 [CDaoQueryDef::GetODBCTimeout](../vs140/cdaoquerydef--getodbctimeout.md)