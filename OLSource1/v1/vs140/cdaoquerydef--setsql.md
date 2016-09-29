---
title: "CDaoQueryDef::SetSQL"
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
  - "CDaoQueryDef::SetSQL"
  - "CDaoQueryDef.SetSQL"
  - "SetSQL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, setting SQL strings"
  - "SQL strings, setting querydef"
  - "QueryDef objects, setting SQL strings"
  - "SetSQL method"
  - "SQL strings"
ms.assetid: a803727e-7604-47e9-9899-1b7d57201122
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::SetSQL
Call this member function to set the SQL statement that the querydef executes.  
  
## Syntax  
  
```  
  
      void SetSQL(   
   LPCTSTR lpszSQL    
);  
```  
  
#### Parameters  
 `lpszSQL`  
 A string containing a complete SQL statement, suitable for execution. The syntax of this string depends on the DBMS that your query targets. For a discussion of syntax used in the Microsoft Jet database engine, see the topic "Building SQL Statements in Code" in DAO Help.  
  
## Remarks  
 A typical use of `SetSQL` is setting up a querydef object for use in a SQL pass-through query. (For the syntax of SQL pass-through queries on your target DBMS, see the documentation for your DBMS.)  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetSQL](../vs140/cdaoquerydef--getsql.md)   
 [CDaoQueryDef::SetName](../vs140/cdaoquerydef--setname.md)   
 [CDaoQueryDef::SetConnect](../vs140/cdaoquerydef--setconnect.md)   
 [CDaoQueryDef::SetODBCTimeout](../vs140/cdaoquerydef--setodbctimeout.md)   
 [CDaoQueryDef::SetReturnsRecords](../vs140/cdaoquerydef--setreturnsrecords.md)