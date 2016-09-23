---
title: "CDatabase::Open"
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
  - CDatabase.Open
  - CDatabase::Open
dev_langs: 
  - C++
helpviewer_keywords: 
  - connection strings [C++], Open function
  - CDatabase class, construction
  - connection strings [C++], ODBC
  - Open method
  - connection strings [C++], definition
  - connection strings [C++], getting
ms.assetid: b4881066-daef-4aff-9190-6fc51e58612d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDatabase::Open
Call this member function to initialize a newly constructed `CDatabase` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Open(  
   LPCTSTR lpszDSN,  
   BOOL bExclusive = FALSE,  
   BOOL bReadOnly = FALSE,  
   LPCTSTR lpszConnect = _T("ODBC;"),  
   BOOL bUseCursorLib = TRUE   
);  
```  
  
#### Parameters  
 `lpszDSN`  
 Specifies a data source name — a name registered with ODBC through the ODBC Administrator program. If a DSN value is specified in `lpszConnect` (in the form "DSN=<data-source>"), it must not be specified again in `lpszDSN`. In this case, `lpszDSN` should be **NULL**. Otherwise, you can pass **NULL** if you want to present the user with a Data Source dialog box in which the user can select a data source. For further information, see Remarks.  
  
 `bExclusive`  
 Not supported in this version of the class library. Currently, an assertion fails if this parameter is **TRUE**. The data source is always opened as shared (not exclusive).  
  
 `bReadOnly`  
 **TRUE** if you intend the connection to be read-only and to prohibit updates to the data source. All dependent recordsets inherit this attribute. The default value is **FALSE**.  
  
 `lpszConnect`  
 Specifies a connection string. The connection string concatenates information, possibly including a data source name, a user ID valid on the data source, a user authentication string (password, if the data source requires one), and other information. The whole connection string must be prefixed by the string "ODBC;" (uppercase or lowercase). The "ODBC;" string is used to indicate that the connection is to an ODBC data source; this is for upward compatibility when future versions of the class library might support non-ODBC data sources.  
  
 `bUseCursorLib`  
 **TRUE** if you want the ODBC Cursor Library DLL to be loaded. The cursor library masks some functionality of the underlying ODBC driver, effectively preventing the use of dynasets (if the driver supports them). The only cursors supported if the cursor library is loaded are static snapshots and forward-only cursors. The default value is **TRUE**. If you plan to create a recordset object directly from `CRecordset` without deriving from it, you should not load the cursor library.  
  
## Return Value  
 Nonzero if the connection is successfully made; otherwise 0 if the user chooses Cancel when presented a dialog box asking for more connection information. In all other cases, the framework throws an exception.  
  
## Remarks  
 Your database object must be initialized before you can use it to construct a recordset object.  
  
> [!NOTE]
>  Calling the [OpenEx](../vs140/cdatabase--openex.md) member function is the preferred way to connect to a data source and initialize your database object.  
  
 If the parameters in your **Open** call do not contain enough information to make the connection, the ODBC driver opens a dialog box to obtain the necessary information from the user. When you call **Open**, your connection string, `lpszConnect`, is stored privately in the `CDatabase` object and is available by calling the [GetConnect](../vs140/cdatabase--getconnect.md) member function.  
  
 If you wish, you can open your own dialog box before you call **Open** to get information from the user, such as a password, then add that information to the connection string you pass to **Open**. Or you might want to save the connection string you pass so you can reuse it the next time your application calls **Open** on a `CDatabase` object.  
  
 You can also use the connection string for multiple levels of login authorization (each for a different `CDatabase` object) or to convey other data source-specific information. For more information about connection strings, see Chapter 5 in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 It is possible for a connection attempt to time out if, for example, the DBMS host is unavailable. If the connection attempt fails, **Open** throws a `CDBException`.  
  
## Example  
 [!code[NVC_MFCDatabase#14](../vs140/codesnippet/CPP/cdatabase--open_1.cpp)]
  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::OpenEx](../vs140/cdatabase--openex.md)   
 [CDatabase::CDatabase](../vs140/cdatabase--cdatabase.md)   
 [CDatabase::Close](../vs140/cdatabase--close.md)   
 [CDBException Class](../vs140/cdbexception-class.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)