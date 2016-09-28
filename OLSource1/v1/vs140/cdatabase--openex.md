---
title: "CDatabase::OpenEx"
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
  - "CDatabase.OpenEx"
  - "OpenEx"
  - "CDatabase::OpenEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "connection strings [C++], Open function"
  - "connection strings [C++], ODBC"
  - "OpenEx method"
  - "connection strings [C++], definition"
  - "connection strings [C++], getting"
ms.assetid: 46a5b892-5534-47b5-9679-08c342073681
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::OpenEx
Call this member function to initialize a newly constructed `CDatabase` object.  
  
## Syntax  
  
```  
  
      virtual BOOL OpenEx(   
   LPCTSTR lpszConnectString,   
   DWORD dwOptions = 0    
);  
```  
  
#### Parameters  
 `lpszConnectString`  
 Specifies an ODBC connection string. This includes the data source name as well as other optional information, such as a user ID and password. For example, "DSN=SQLServer_Source;UID=SA;PWD=abc123" is a possible connection string. Note that if you pass **NULL** for `lpszConnectString`, a Data Source dialog box will prompt the user to select a data source.  
  
 `dwOptions`  
 A bitmask which specifies a combination of the following values. The default value is 0, meaning that the database will be opened as shared with write access, the ODBC Cursor Library DLL will not be loaded, and the ODBC connection dialog box will display only if there is not enough information to make the connection.  
  
-   **CDatabase::openExclusive** Not supported in this version of the class library. A data source is always opened as shared (not exclusive). Currently, an assertion fails if you specify this option.  
  
-   **CDatabase::openReadOnly** Open the data source as read-only.  
  
-   **CDatabase::useCursorLib** Load the ODBC Cursor Library DLL. The cursor library masks some functionality of the underlying ODBC driver, effectively preventing the use of dynasets (if the driver supports them). The only cursors supported if the cursor library is loaded are static snapshots and forward-only cursors. If you plan to create a recordset object directly from `CRecordset` without deriving from it, you should not load the cursor library.  
  
-   **CDatabase::noOdbcDialog** Do not display the ODBC connection dialog box, regardless of whether enough connection information is supplied.  
  
-   **CDatabase::forceOdbcDialog** Always display the ODBC connection dialog box.  
  
## Return Value  
 Nonzero if the connection is successfully made; otherwise 0 if the user chooses Cancel when presented a dialog box asking for more connection information. In all other cases, the framework throws an exception.  
  
## Remarks  
 Your database object must be initialized before you can use it to construct a recordset object.  
  
 If the `lpszConnectString` parameter in your `OpenEx` call does not contain enough information to make the connection, the ODBC driver opens a dialog box to obtain the necessary information from the user, provided you have not set **CDatabase::noOdbcDialog** or **CDatabase::forceOdbcDialog** in the `dwOptions` parameter. When you call `OpenEx`, your connection string, `lpszConnectString`, is stored privately in the `CDatabase` object and is available by calling the [GetConnect](../vs140/cdatabase--getconnect.md) member function.  
  
 If you wish, you can open your own dialog box before you call `OpenEx` to get information from the user, such as a password, and then add that information to the connection string you pass to `OpenEx`. Or you might want to save the connection string you pass so you can reuse it the next time your application calls `OpenEx` on a `CDatabase` object.  
  
 You can also use the connection string for multiple levels of login authorization (each for a different `CDatabase` object) or to convey other data source-specific information. For more information about connection strings, see Chapter 6 in the *ODBC Programmer's Reference*.  
  
 It is possible for a connection attempt to time out if, for example, the DBMS host is unavailable. If the connection attempt fails, `OpenEx` throws a `CDBException`.  
  
## Example  
 [!code[NVC_MFCDatabase#11](../vs140/codesnippet/CPP/cdatabase--openex_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::Open](../vs140/cdatabase--open.md)   
 [CDatabase::CDatabase](../vs140/cdatabase--cdatabase.md)   
 [CDatabase::Close](../vs140/cdatabase--close.md)   
 [CDBException Class](../vs140/cdbexception-class.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)