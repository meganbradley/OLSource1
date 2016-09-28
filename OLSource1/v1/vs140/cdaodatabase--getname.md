---
title: "CDaoDatabase::GetName"
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
  - "GetName"
  - "CDaoDatabase.GetName"
  - "CDaoDatabase::GetName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "databases [C++], names and paths"
  - "CDaoDatabase class, getting database names"
  - "GetName method"
  - "DAO [C++], getting database information"
  - "names [C++], database"
  - "database names [C++]"
ms.assetid: 53e78276-93d3-4540-99de-bf9c53269489
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::GetName
Call this member function to retrieve the name of the currently open database, which is the name of an existing database file or the name of a registered ODBC data source.  
  
## Syntax  
  
```  
  
CString GetName( );  
  
```  
  
## Return Value  
 The full path and file name of the database if successful; otherwise, an empty [CString](../vs140/cstringt-class.md).  
  
## Remarks  
 If your network supports the uniform naming convention (UNC), you can also specify a network path—for example, "\\\\\\\MYSERVER\\\MYSHARE\\\MYDIR\\\MYDB.MDB". (Double backslashes are required in string literals because "\\" is the C++ escape character.)  
  
 You might, for example, want to display this name in a heading. If an error occurs while the name is being retrieved, MFC throws an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
> [!NOTE]
>  For better performance when external databases are being accessed, we recommend that you attach external database tables to a Microsoft Jet database (.MDB) rather than connecting directly to the data source.  
  
 The database type is indicated by the file or directory that the path points to, as follows:  
  
|Pathname points to..|Database type|  
|--------------------------|-------------------|  
|.MDB file|Microsoft Jet database (Microsoft Access)|  
|Directory that contains .DBF file(s)|dBASE database|  
|Directory that contains .XLS file|Microsoft Excel database|  
|Directory that contains .PDX file(s)|Paradox database|  
|Directory that contains appropriately formatted text database files|Text format database|  
  
 For ODBC databases such as SQL Server and Oracle, the database's connection string identifies a data source name (DSN) that's registered by ODBC.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::Open](../vs140/cdatabase--open.md)   
 [CDatabase::GetConnect](../vs140/cdatabase--getconnect.md)