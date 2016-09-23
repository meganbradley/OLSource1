---
title: "CDaoDatabase::Open"
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
  - CDaoDatabase::Open
  - CDaoDatabase.Open
dev_langs: 
  - C++
helpviewer_keywords: 
  - connection strings [C++], Open function
  - open databases [C++], initializing
  - opening database objects
  - databases [C++], opening
  - read-only databases [C++]
  - open files, notifying user of exclusive access
  - databases [C++], initializing
  - opening databases
  - Open method
  - initializing databases
  - DAO [C++], initialization
  - open databases [C++]
  - exclusive access [C++], opening databases for
  - DAO [C++], opening databases
  - databases [C++], exclusive use
  - DAO [C++], termination
  - exclusive access [C++]
  - databases [C++], read-only use
ms.assetid: 252783bf-cb71-4667-9537-cec35afe75db
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoDatabase::Open
You must call this member function to initialize a newly constructed `CDaoDatabase` object that represents an existing database.  
  
## Syntax  
  
```  
  
      virtual void Open(   
   LPCTSTR lpszName,   
   BOOL bExclusive = FALSE,   
   BOOL bReadOnly = FALSE,   
   LPCTSTR lpszConnect = _T(   
   "" )   
);  
```  
  
#### Parameters  
 `lpszName`  
 A string expression that is the name of an existing Microsoft Jet (.MDB) database file. If the filename has an extension, it is required. If your network supports the uniform naming convention (UNC), you can also specify a network path, such as "\\\\\\\MYSERVER\\\MYSHARE\\\MYDIR\\\MYDB.MDB". (Double backslashes are required in string literals because "\\" is the C++ escape character.)  
  
 Some considerations apply when using `lpszName`. If it:  
  
-   Refers to a database that is already open for exclusive access by another user, MFC throws an exception of type [CDaoException](../vs140/cdaoexception-class.md). Trap that exception to let your user know that the database is unavailable.  
  
-   Is an empty string ("") and *lpszConnect* is "ODBC;", a dialog box listing all registered ODBC data source names is displayed so the user can select a database. You should avoid direct connections to ODBC data sources; use an attached table instead.  
  
-   Otherwise does not refer to an existing database or valid ODBC data source name, MFC throws an exception of type `CDaoException`.  
  
> [!NOTE]
>  For details about DAO error codes, see the DAOERR.H file. For related information, see the topic "Trappable Data Access Errors" in DAO Help.  
  
 `bExclusive`  
 A Boolean value that is **TRUE** if the database is to be opened for exclusive (nonshared) access and **FALSE** if the database is to be opened for shared access. If you omit this argument, the database is opened for shared access.  
  
 `bReadOnly`  
 A Boolean value that is **TRUE** if the database is to be opened for read-only access and **FALSE** if the database is to be opened for read/write access. If you omit this argument, the database is opened for read/write access. All dependent recordsets inherit this attribute.  
  
 `lpszConnect`  
 A string expression used for opening the database. This string constitutes the ODBC connect arguments. You must supply the exclusive and read-only arguments to supply a source string. If the database is a Microsoft Jet database (.MDB), this string is empty (""). The syntax for the default value — **_T**("") — provides portability for Unicode as well as ANSI builds of your application.  
  
## Remarks  
 **Open** associates the database with the underlying DAO object. You cannot use the database object to construct recordset, tabledef, or querydef objects until it is initialized. **Open** appends the database object to the associated workspace's Databases collection.  
  
 Use the parameters as follows:  
  
-   If you are opening a Microsoft Jet (.MDB) database, use the `lpszName` parameter and pass an empty string for the `lpszConnect` parameter or pass a password string of the form ";PWD=password" if the database is password-protected (.MDB databases only).  
  
-   If you are opening an ODBC data source, pass a valid ODBC connection string in `lpszConnect` and an empty string in `lpszName`.  
  
 For related information, see the topic "OpenDatabase Method" in DAO Help.  
  
> [!NOTE]
>  For better performance when accessing external databases, including ISAM databases and ODBC data sources, it is recommended that you attach external database tables to a Microsoft Jet engine database (.MDB) rather than connecting directly to the data source.  
  
 It is possible for a connection attempt to time out if, for example, the DBMS host is unavailable. If the connection attempt fails, **Open** throws an exception of type [CDaoException](../vs140/cdaoexception-class.md).  
  
 The remaining remarks apply only to ODBC databases:  
  
 If the database is an ODBC database and the parameters in your **Open** call do not contain enough information to make the connection, the ODBC driver opens a dialog box to obtain the necessary information from the user. When you call **Open**, your connection string, `lpszConnect`, is stored privately and is available by calling the [GetConnect](../vs140/cdaodatabase--getconnect.md) member function.  
  
 If you wish, you can open your own dialog box before you call **Open** to get information from the user, such as a password, then add that information to the connection string you pass to **Open**. Or you might want to save the connection string you pass (perhaps in the Windows registry) so you can reuse it the next time your application calls **Open** on a `CDaoDatabase` object.  
  
 You can also use the connection string for multiple levels of login authorization (each for a different `CDaoDatabase` object) or to convey other database-specific information.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::CDatabase](../vs140/cdatabase--cdatabase.md)   
 [CDatabase::Close](../vs140/cdatabase--close.md)