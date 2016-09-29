---
title: "CDaoQueryDef::SetConnect"
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
  - "CDaoQueryDef::SetConnect"
  - "SetConnect"
  - "CDaoQueryDef.SetConnect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetConnect method"
  - "connection strings [C++], querydef"
  - "QueryDef objects, setting connection strings"
  - "CDaoQueryDef class, setting connection strings"
ms.assetid: 3b21f237-4162-4756-b12e-a8b7a72b9ae1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::SetConnect
Call this member function to set the querydef object's connection string.  
  
## Syntax  
  
```  
  
      void SetConnect(   
   LPCTSTR lpszConnect    
);  
```  
  
#### Parameters  
 `lpszConnect`  
 A string that contains a connection string for the associated [CDaoDatabase](../vs140/cdaodatabase-class.md) object.  
  
## Remarks  
 The connection string is used to pass additional information to ODBC and certain ISAM drivers as needed. It is not used for Microsoft Jet (.MDB) databases.  
  
> [!TIP]
>  The preferred way to work with ODBC tables is to attach them to an .MDB database.  
  
 Before executing a querydef that represents a SQL pass-through query to an ODBC data source, set the connection string with `SetConnect` and call [SetReturnsRecords](../vs140/cdaoquerydef--setreturnsrecords.md) to specify whether the query returns records.  
  
 For more information about the connection string's structure and examples of connection string components, see the topic "Connect Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)