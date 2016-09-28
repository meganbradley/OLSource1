---
title: "CDaoQueryDef::GetODBCTimeout"
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
  - "GetODBCTimeout"
  - "CDaoQueryDef::GetODBCTimeout"
  - "CDaoQueryDef.GetODBCTimeout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, getting information"
  - "time-out values"
  - "time-out values, ODBC"
  - "GetODBCTimeout method"
  - "QueryDef objects, getting time-out values"
  - "ODBC, time-out values"
ms.assetid: e0595012-631c-4837-a768-3c51cd0ba51d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetODBCTimeout
Call this member function to retrieve the current time limit before a query to an ODBC data source times out.  
  
## Syntax  
  
```  
  
short GetODBCTimeout( );  
  
```  
  
## Return Value  
 The number of seconds before a query times out.  
  
## Remarks  
 For information about this time limit, see the topic "ODBCTimeout Property" in DAO Help.  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to a Microsoft Jet (.MDB) database. For more information, see the topic "Accessing External Databases with DAO" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::SetODBCTimeout](../vs140/cdaoquerydef--setodbctimeout.md)   
 [CDaoQueryDef::GetName](../vs140/cdaoquerydef--getname.md)   
 [CDaoQueryDef::GetSQL](../vs140/cdaoquerydef--getsql.md)   
 [CDaoQueryDef::GetReturnsRecords](../vs140/cdaoquerydef--getreturnsrecords.md)