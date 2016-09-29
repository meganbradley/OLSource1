---
title: "CDatabase::GetDatabaseName"
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
  - "GetDatabaseName"
  - "CDatabase::GetDatabaseName"
  - "CDatabase.GetDatabaseName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDatabase class, database attributes"
  - "GetDatabaseName method"
ms.assetid: cbeae8de-8a20-4d4f-a4b9-36eb071ef00a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::GetDatabaseName
Call this member function to retrieve the name of the currently connected database (provided that the data source defines a named object called "database").  
  
## Syntax  
  
```  
  
CString GetDatabaseName( ) const;  
```  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) containing the database name if successful; otherwise, an empty `CString`.  
  
## Remarks  
 This is not the same as the data source name (DSN) specified in the `OpenEx` or **Open** call. What `GetDatabaseName` returns depends on ODBC. In general, a database is a collection of tables. If this entity has a name, `GetDatabaseName` returns it.  
  
 You might, for example, want to display this name in a heading. If an error occurs while retrieving the name from ODBC, `GetDatabaseName` returns an empty **Cstring**.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OpenEx](../vs140/cdatabase--openex.md)   
 [CDatabase::Open](../vs140/cdatabase--open.md)   
 [CDatabase::GetConnect](../vs140/cdatabase--getconnect.md)