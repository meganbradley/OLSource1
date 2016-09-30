---
title: "CDaoDatabase::GetConnect"
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
  - "CDaoDatabase::GetConnect"
  - "CDaoDatabase.GetConnect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetConnect method"
  - "database connections [C++], getting connection information"
  - "ODBC connections [C++], getting connection information"
  - "Jet databases [C++]"
  - "Jet databases [C++], connection strings"
  - "DAO [C++], getting connection information"
  - "connection strings [C++], getting"
ms.assetid: 76e9c148-4616-4494-9508-e402058a6ed3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetConnect
Call this member function to retrieve the connection string used to connect the `CDaoDatabase` object to an ODBC or ISAM database.  
  
## Syntax  
  
```  
  
CString GetConnect( );  
  
```  
  
## Return Value  
 The connection string if [Open](../vs140/cdaodatabase--open.md) has been called successfully on an ODBC data source; otherwise, an empty string. For a Microsoft Jet (.MDB) database, the string is always empty unless you set it for use with the **dbSQLPassThrough** option used with the [Execute](../vs140/cdaodatabase--execute.md) member function or used in opening a recordset.  
  
## Remarks  
 The string provides information about the source of an open database or a database used in a pass-through query. The connection string is composed of a database type specifier and zero or more parameters separated by semicolons.  
  
> [!NOTE]
>  Using the MFC DAO classes to connect to a data source via ODBC is less efficient than connecting via an attached table.  
  
> [!NOTE]
>  The connection string is used to pass additional information to ODBC and certain ISAM drivers as needed. It is not used for .MDB databases. For Microsoft Jet database base tables, the connection string is an empty string ("") except when you use it for a SQL pass-through query as described under Return Value above.  
  
 See the [Open](../vs140/cdaodatabase--open.md) member function for a description of how the connection string is created. Once the connection string has been set in the **Open** call, you can later use it to check the setting to determine the type, path, user ID, Password, or ODBC data source of the database.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)