---
title: "CDatabase Class"
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
  - "CDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "database classes [C++], ODBC"
  - "MFC [C++], ODBC"
  - "ODBC [C++], CDatabase class"
  - "ODBC database class"
  - "database connections [C++], CDatabase class"
  - "CDatabase class"
ms.assetid: bd0de70a-e3c3-4441-bcaa-bbf434426ca8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase Class
Represents a connection to a data source, through which you can operate on the data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDatabase::CDatabase](#cdatabase__cdatabase)|Constructs a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. You must initialize the object by calling <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or **Open**.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDatabase::BeginTrans](#cdatabase__begintrans)|Starts a "transaction" — a series of reversible calls to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, **Edit**, **Delete**, and **Update** member functions of class <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> — on the connected data source. The data source must support transactions for **BeginTrans** to have any effect.|  
|[CDatabase::BindParameters](#cdatabase__bindparameters)|Allows you to bind parameters before calling <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[CDatabase::Cancel](#cdatabase__cancel)|Cancels an asynchronous operation or a process from a second thread.|  
|[CDatabase::CanTransact](#cdatabase__cantransact)|Returns nonzero if the data source supports transactions.|  
|[CDatabase::CanUpdate](#cdatabase__canupdate)|Returns nonzero if the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is updatable (not read-only).|  
|[CDatabase::Close](#cdatabase__close)|Closes the data source connection.|  
|[CDatabase::CommitTrans](#cdatabase__committrans)|Completes a transaction begun by **BeginTrans**. Commands in the transaction that alter the data source are carried out.|  
|[CDatabase::ExecuteSQL](#cdatabase__executesql)|Executes a SQL statement. No data records are returned.|  
|[CDatabase::GetBookmarkPersistence](#cdatabase__getbookmarkpersistence)|Identifies the operations through which bookmarks persist on recordset objects.|  
|[CDatabase::GetConnect](#cdatabase__getconnect)|Returns the ODBC connection string used to connect the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object to a data source.|  
|[CDatabase::GetCursorCommitBehavior](#cdatabase__getcursorcommitbehavior)|Identifies the effect of committing a transaction on an open recordset object.|  
|[CDatabase::GetCursorRollbackBehavior](#cdatabase__getcursorrollbackbehavior)|Identifies the effect of rolling back a transaction on an open recordset object.|  
|[CDatabase::GetDatabaseName](#cdatabase__getdatabasename)|Returns the name of the database currently in use.|  
|[CDatabase::IsOpen](#cdatabase__isopen)|Returns nonzero if the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object is currently connected to a data source.|  
|[CDatabase::OnSetOptions](#cdatabase__onsetoptions)|Called by the framework to set standard connection options. The default implementation sets the query timeout value. You can establish these options ahead of time by calling <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.|  
|[CDatabase::Open](#cdatabase__open)|Establishes a connection to a data source (through an ODBC driver).|  
|[CDatabase::OpenEx](#cdatabase__openex)|Establishes a connection to a data source (through an ODBC driver).|  
|[CDatabase::Rollback](#cdatabase__rollback)|Reverses changes made during the current transaction. The data source returns to its previous state, as defined at the **BeginTrans** call, unaltered.|  
|[CDatabase::SetLoginTimeout](#cdatabase__setlogintimeout)|Sets the number of seconds after which a data source connection attempt will time out.|  
|[CDatabase::SetQueryTimeout](#cdatabase__setquerytimeout)|Sets the number of seconds after which database query operations will time out. Affects all subsequent recordset **Open**, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, **Edit**, and **Delete** calls.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDatabase::m_hdbc](#cdatabase__m_hdbc)|Open Database Connectivity (ODBC) connection handle to a data source. Type **HDBC**.|  
  
## Remarks  
 A data source is a specific instance of data hosted by some database management system (DBMS). Examples include Microsoft SQL Server, Microsoft Access, Borland dBASE, and xBASE. You can have one or more <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects active at a time in your application.  
  
> [!NOTE]
>  If you are working with the Data Access Objects (DAO) classes rather than the Open Database Connectivity (ODBC) classes, use class [CDaoDatabase](../vs140/cdaodatabase-class.md) instead. For more information, see the article [Overview: Database Programming](../vs140/data-access-programming--mfc-atl-.md).  
  
 To use <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, construct a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object and call its <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> member function. This opens a connection. When you then construct <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects for operating on the connected data source, pass the recordset constructor a pointer to your <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object. When you finish using the connection, call the **Close** member function and destroy the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object. **Close** closes any recordsets you have not closed previously.  
  
 For more information about <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, see the articles [Data Source (ODBC)](../vs140/data-source--odbc-.md) and [Overview: Database Programming](../vs140/data-access-programming--mfc-atl-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdb.h  
  
##  \<a name="cdatabase__begintrans">\</a>  CDatabase::BeginTrans  
 Call this member function to begin a transaction with the connected data source.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the call was successful and changes are committed only manually; otherwise 0.  
  
### Remarks  
 A transaction consists of one or more calls to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, **Edit**, **Delete**, and **Update** member functions of a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object. Before beginning a transaction, the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object must already have been connected to the data source by calling its <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or **Open** member function. To end the transaction, call [CommitTrans](#cdatabase__committrans) to accept all changes to the data source (and carry them out) or call [Rollback](#cdatabase__rollback) to abort the entire transaction. Call **BeginTrans** after you open any recordsets involved in the transaction and as close to the actual update operations as possible.  
  
> [!CAUTION]
>  Depending on your ODBC driver, opening a recordset before calling **BeginTrans** may cause problems when calling **Rollback**. You should check the specific driver you are using. For example, when using the Microsoft Access driver included in the Microsoft ODBC Desktop Driver Pack 3.0, you must account for the Jet database engine's requirement that you should not begin a transaction on any database that has an open cursor. In the MFC database classes, an open cursor means an open <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object. For more information, see [Technical Note 68](../vs140/tn068--performing-transactions-with-the-microsoft-access-7-odbc-driver.md).  
  
 **BeginTrans** may also lock data records on the server, depending on the requested concurrency and the capabilities of the data source. For information about locking data, see the article [Recordset: Locking Records (ODBC)](../vs140/recordset--locking-records--odbc-.md).  
  
 User-defined transactions are explained in the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
 **BeginTrans** establishes the state to which the sequence of transactions can be rolled back (reversed). To establish a new state for rollbacks, commit any current transaction, then call **BeginTrans** again.  
  
> [!CAUTION]
>  Calling **BeginTrans** again without calling **CommitTrans** or **Rollback** is an error.  
  
 Call the [CanTransact](#cdatabase__cantransact) member function to determine whether your driver supports transactions for a given database. You should also call [GetCursorCommitBehavior](#cdatabase__getcursorcommitbehavior) and [GetCursorRollbackBehavior](#cdatabase__getcursorrollbackbehavior) to determine the support for cursor preservation.  
  
 For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
### Example  
  See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
##  \<a name="cdatabase__bindparameters">\</a>  CDatabase::BindParameters  
 Override <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> when you need to bind parameters before calling [CDatabase::ExecuteSQL](#cdatabase__executesql).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The ODBC statement handle for which you want to bind parameters.  
  
### Remarks  
 This approach is useful when you do not need the result set from a stored procedure.  
  
 In your override, call **SQLBindParameters** and related ODBC functions to bind the parameters. MFC calls your override before your call to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. You do not need to call **SQLPrepare**; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> calls **SQLExecDirect** and destroys the **hstmt**, which is used only once.  
  
##  \<a name="cdatabase__cancel">\</a>  CDatabase::Cancel  
 Call this member function to request that the data source cancel either an asynchronous operation in progress or a process from a second thread.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Note that the MFC ODBC classes no longer use asynchronous processing; to perform an asychronous operation, you must directly call the ODBC API function                         [SQLSetConnectOption](https://msdn.microsoft.com/en-us/library/ms713564.aspx). For more information, see                         [Asynchronous Execution](https://msdn.microsoft.com/en-us/library/ms713563.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdatabase__cantransact">\</a>  CDatabase::CanTransact  
 Call this member function to determine whether the database allows transactions.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if recordsets using this <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object allow transactions; otherwise 0.  
  
### Remarks  
 For information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
##  \<a name="cdatabase__canupdate">\</a>  CDatabase::CanUpdate  
 Call this member function to determine whether the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object allows updates.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object allows updates; otherwise 0, indicating either that you passed **TRUE** in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> when you opened the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object or that the data source itself is read-only. The data source is read-only if a call to the ODBC API function **SQLGetInfo** for **SQL_DATASOURCE_READ_ONLY** returns "y".  
  
### Remarks  
 Not all drivers support updates.  
  
##  \<a name="cdatabase__cdatabase">\</a>  CDatabase::CDatabase  
 Constructs a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 After constructing the object, you must call its <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or **Open** member function to establish a connection to a specified data source.  
  
 You may find it convenient to embed the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object in your document class.  
  
### Example  
 This example illustrates using <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>-derived class.  
  
 [!code[NVC_MFCDatabase#9](../vs140/codesnippet/CPP/cdatabase-class_1.h)]  
  
 [!code[NVC_MFCDatabase#10](../vs140/codesnippet/CPP/cdatabase-class_2.cpp)]  
  
##  \<a name="cdatabase__close">\</a>  CDatabase::Close  
 Call this member function if you want to disconnect from a data source.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 You must close any recordsets associated with the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object before you call this member function. Because **Close** does not destroy the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object, you can reuse the object by opening a new connection to the same data source or a different data source.  
  
 All pending <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> or **Edit** statements of recordsets using the database are canceled, and all pending transactions are rolled back. Any recordsets dependent on the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object are left in an undefined state.  
  
### Example  
 [!code[NVC_MFCDatabase#12](../vs140/codesnippet/CPP/cdatabase-class_3.cpp)]  
  
##  \<a name="cdatabase__committrans">\</a>  CDatabase::CommitTrans  
 Call this member function upon completing transactions.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the updates were successfully committed; otherwise 0. If **CommitTrans** fails, the state of the data source is undefined. You must check the data to determine its state.  
  
### Remarks  
 A transaction consists of a series of calls to the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, **Edit**, **Delete**, and **Update** member functions of a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object that began with a call to the [BeginTrans](#cdatabase__begintrans) member function. **CommitTrans** commits the transaction. By default, updates are committed immediately; calling **BeginTrans** causes commitment of updates to be delayed until **CommitTrans** is called.  
  
 Until you call **CommitTrans** to end a transaction, you can call the [Rollback](#cdatabase__rollback) member function to abort the transaction and leave the data source in its original state. To begin a new transaction, call **BeginTrans** again.  
  
 For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
### Example  
  See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
##  \<a name="cdatabase__executesql">\</a>  CDatabase::ExecuteSQL  
 Call this member function when you need to execute a SQL command directly.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string containing a valid SQL command to execute. You can pass a [CString](../vs140/cstringt-class.md).  
  
### Remarks  
 Create the command as a null-terminated string. <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> does not return data records. If you want to operate on records, use a recordset object instead.  
  
 Most of your commands for a data source are issued through recordset objects, which support commands for selecting data, inserting new records, deleting records, and editing records. However, not all ODBC functionality is directly supported by the database classes, so you may at times need to make a direct SQL call with <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDatabase#13](../vs140/codesnippet/CPP/cdatabase-class_4.cpp)]  
  
##  \<a name="cdatabase__getbookmarkpersistence">\</a>  CDatabase::GetBookmarkPersistence  
 Call this member function to determine the persistence of bookmarks on a recordset object after certain operations.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A bitmask that identifies the operations through which bookmarks persist on a recordset object. For details, see Remarks.  
  
### Remarks  
 For example, if you call <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> and then call <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, the bookmark obtained from <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> may no longer be valid. You should call <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 The following table lists the bitmask values that can be combined for the return value of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
|Bitmask value|Bookmark persistence|  
|-------------------|--------------------------|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Bookmarks are valid after a **Requery** operation.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|The bookmark for a row is valid after a **Delete** operation on that row.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Bookmarks are valid after a **Close** operation.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Bookmarks are valid after any **Move** operation. This simply identifies if bookmarks are supported on the recordset, as returned by <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|Bookmarks are valid after a transaction is committed or rolled back.|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|The bookmark for a row is valid after an **Update** operation on that row.|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|Bookmarks associated with one recordset object are valid on a second recordset.|  
  
 For more information about this return value, see the ODBC API function **SQLGetInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bookmarks, see the article [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md).  
  
##  \<a name="cdatabase__getconnect">\</a>  CDatabase::GetConnect  
 Call this member function to retrieve the connection string used during the call to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> that connected the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object to a data source.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>[CString](../vs140/cstringt-class.md) containing the connection string if <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> has been called; otherwise, an empty string.  
  
### Remarks  
 See [CDatabase::Open](#cdatabase__open) for a description of how the connection string is created.  
  
##  \<a name="cdatabase__getcursorcommitbehavior">\</a>  CDatabase::GetCursorCommitBehavior  
 Call this member function to determine how a [CommitTrans](#cdatabase__committrans) operation affects cursors on open recordset objects.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 A value indicating the effect of transactions on open recordset objects. For details, see Remarks.  
  
### Remarks  
 The following table lists the possible return values for <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> and the corresponding effect on the open recordset.  
  
|Return value|Effect on CRecordset objects|  
|------------------|----------------------------------|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Call <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> immediately following the transaction commit.|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Call <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> immediately following the transaction commit.|  
|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Proceed normally with <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> operations.|  
  
 For more information about this return value, see the ODBC API function **SQLGetInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
##  \<a name="cdatabase__getcursorrollbackbehavior">\</a>  CDatabase::GetCursorRollbackBehavior  
 Call this member function to determine how a [Rollback](#cdatabase__rollback) operation affects cursors on open recordset objects.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A value indicating the effect of transactions on open recordset objects. For details, see Remarks.  
  
### Remarks  
 The following table lists the possible return values for <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> and the corresponding effect on the open recordset.  
  
|Return value|Effect on CRecordset objects|  
|------------------|----------------------------------|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Call <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> immediately following the transaction rollback.|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|Call <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> immediately following the transaction rollback.|  
|<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>|Proceed normally with <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> operations.|  
  
 For more information about this return value, see the ODBC API function **SQLGetInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
##  \<a name="cdatabase__getdatabasename">\</a>  CDatabase::GetDatabaseName  
 Call this member function to retrieve the name of the currently connected database (provided that the data source defines a named object called "database").  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) containing the database name if successful; otherwise, an empty <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
### Remarks  
 This is not the same as the data source name (DSN) specified in the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> or **Open** call. What <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> returns depends on ODBC. In general, a database is a collection of tables. If this entity has a name, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> returns it.  
  
 You might, for example, want to display this name in a heading. If an error occurs while retrieving the name from ODBC, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> returns an empty **Cstring**.  
  
##  \<a name="cdatabase__isopen">\</a>  CDatabase::IsOpen  
 Call this member function to determine whether the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object is currently connected to a data source.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object is currently connected; otherwise 0.  
  
##  \<a name="cdatabase__m_hdbc">\</a>  CDatabase::m_hdbc  
 Contains a public handle to an ODBC data source connection — a "connection handle."  
  
### Remarks  
 Normally, you will have no need to access this member variable directly. Instead, the framework allocates the handle when you call <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> or **Open**. The framework deallocates the handle when you call the **delete** operator on the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object. Note that the **Close** member function does not deallocate the handle.  
  
 Under some circumstances, however, you may need to use the handle directly. For example, if you need to call ODBC API functions directly rather than through class <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>, you may need a connection handle to pass as a parameter. See the code example below.  
  
### Example  
 [!code[NVC_MFCDatabase#15](../vs140/codesnippet/CPP/cdatabase-class_5.cpp)]  
  
##  \<a name="cdatabase__onsetoptions">\</a>  CDatabase::OnSetOptions  
 The framework calls this member function when directly executing a SQL statement with the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 The ODBC statement handle for which options are being set.  
  
### Remarks  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> also calls this member function.  
  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> sets the login timeout value. If there have been previous calls to the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> and member function, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> reflects the current values; otherwise, it sets default values.  
  
> [!NOTE]
>  Prior to MFC 4.2, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> also set the processing mode to either snychronous or asynchronous. Beginning with MFC 4.2, all operations are synchronous. To perform an asynchronous operation, you must make a direct call to the ODBC API function **SQLSetPos**.  
  
 You do not need to override <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> to change the timeout value. Instead, to customize the query timeout value, call <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> before creating a recordset; <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> will use the new value. The values set apply to subsequent operations on all recordsets or direct SQL calls.  
  
 Override <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if you want to set additional options. Your override should call the base class <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> either before or after you call the ODBC API function **SQLSetStmtOption**. Follow the method illustrated in the framework's default implementation of <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
##  \<a name="cdatabase__open">\</a>  CDatabase::Open  
 Call this member function to initialize a newly constructed <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Specifies a data source name — a name registered with ODBC through the ODBC Administrator program. If a DSN value is specified in <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> (in the form "DSN=\<data-source>"), it must not be specified again in <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>. In this case, <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> should be **NULL**. Otherwise, you can pass **NULL** if you want to present the user with a Data Source dialog box in which the user can select a data source. For further information, see Remarks.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Not supported in this version of the class library. Currently, an assertion fails if this parameter is **TRUE**. The data source is always opened as shared (not exclusive).  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 **TRUE** if you intend the connection to be read-only and to prohibit updates to the data source. All dependent recordsets inherit this attribute. The default value is **FALSE**.  
  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 Specifies a connection string. The connection string concatenates information, possibly including a data source name, a user ID valid on the data source, a user authentication string (password, if the data source requires one), and other information. The whole connection string must be prefixed by the string "ODBC;" (uppercase or lowercase). The "ODBC;" string is used to indicate that the connection is to an ODBC data source; this is for upward compatibility when future versions of the class library might support non-ODBC data sources.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 **TRUE** if you want the ODBC Cursor Library DLL to be loaded. The cursor library masks some functionality of the underlying ODBC driver, effectively preventing the use of dynasets (if the driver supports them). The only cursors supported if the cursor library is loaded are static snapshots and forward-only cursors. The default value is **TRUE**. If you plan to create a recordset object directly from <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> without deriving from it, you should not load the cursor library.  
  
### Return Value  
 Nonzero if the connection is successfully made; otherwise 0 if the user chooses Cancel when presented a dialog box asking for more connection information. In all other cases, the framework throws an exception.  
  
### Remarks  
 Your database object must be initialized before you can use it to construct a recordset object.  
  
> [!NOTE]
>  Calling the [OpenEx](#cdatabase__openex) member function is the preferred way to connect to a data source and initialize your database object.  
  
 If the parameters in your **Open** call do not contain enough information to make the connection, the ODBC driver opens a dialog box to obtain the necessary information from the user. When you call **Open**, your connection string, <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>, is stored privately in the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object and is available by calling the [GetConnect](#cdatabase__getconnect) member function.  
  
 If you wish, you can open your own dialog box before you call **Open** to get information from the user, such as a password, then add that information to the connection string you pass to **Open**. Or you might want to save the connection string you pass so you can reuse it the next time your application calls **Open** on a <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object.  
  
 You can also use the connection string for multiple levels of login authorization (each for a different <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object) or to convey other data source-specific information. For more information about connection strings, see Chapter 5 in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 It is possible for a connection attempt to time out if, for example, the DBMS host is unavailable. If the connection attempt fails, **Open** throws a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDatabase#14](../vs140/codesnippet/CPP/cdatabase-class_6.cpp)]  
  
##  \<a name="cdatabase__openex">\</a>  CDatabase::OpenEx  
 Call this member function to initialize a newly constructed <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 Specifies an ODBC connection string. This includes the data source name as well as other optional information, such as a user ID and password. For example, "DSN=SQLServer_Source;UID=SA;PWD=abc123" is a possible connection string. Note that if you pass **NULL** for <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, a Data Source dialog box will prompt the user to select a data source.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 A bitmask which specifies a combination of the following values. The default value is 0, meaning that the database will be opened as shared with write access, the ODBC Cursor Library DLL will not be loaded, and the ODBC connection dialog box will display only if there is not enough information to make the connection.  
  
-   **CDatabase::openExclusive** Not supported in this version of the class library. A data source is always opened as shared (not exclusive). Currently, an assertion fails if you specify this option.  
  
-   **CDatabase::openReadOnly** Open the data source as read-only.  
  
-   **CDatabase::useCursorLib** Load the ODBC Cursor Library DLL. The cursor library masks some functionality of the underlying ODBC driver, effectively preventing the use of dynasets (if the driver supports them). The only cursors supported if the cursor library is loaded are static snapshots and forward-only cursors. If you plan to create a recordset object directly from <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> without deriving from it, you should not load the cursor library.  
  
-   **CDatabase::noOdbcDialog** Do not display the ODBC connection dialog box, regardless of whether enough connection information is supplied.  
  
-   **CDatabase::forceOdbcDialog** Always display the ODBC connection dialog box.  
  
### Return Value  
 Nonzero if the connection is successfully made; otherwise 0 if the user chooses Cancel when presented a dialog box asking for more connection information. In all other cases, the framework throws an exception.  
  
### Remarks  
 Your database object must be initialized before you can use it to construct a recordset object.  
  
 If the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> parameter in your <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> call does not contain enough information to make the connection, the ODBC driver opens a dialog box to obtain the necessary information from the user, provided you have not set **CDatabase::noOdbcDialog** or **CDatabase::forceOdbcDialog** in the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> parameter. When you call <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, your connection string, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, is stored privately in the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object and is available by calling the [GetConnect](#cdatabase__getconnect) member function.  
  
 If you wish, you can open your own dialog box before you call <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> to get information from the user, such as a password, and then add that information to the connection string you pass to <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>. Or you might want to save the connection string you pass so you can reuse it the next time your application calls <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> on a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> object.  
  
 You can also use the connection string for multiple levels of login authorization (each for a different <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> object) or to convey other data source-specific information. For more information about connection strings, see Chapter 6 in the                         *ODBC Programmer's Reference*.  
  
 It is possible for a connection attempt to time out if, for example, the DBMS host is unavailable. If the connection attempt fails, <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> throws a <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDatabase#11](../vs140/codesnippet/CPP/cdatabase-class_7.cpp)]  
  
##  \<a name="cdatabase__rollback">\</a>  CDatabase::Rollback  
 Call this member function to reverse the changes made during a transaction.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the transaction was successfully reversed; otherwise 0. If a **Rollback** call fails, the data source and transaction states are undefined. If **Rollback** returns 0, you must check the data source to determine its state.  
  
### Remarks  
 All <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>, **Edit**, **Delete**, and **Update** calls executed since the last [BeginTrans](#cdatabase__begintrans) are rolled back to the state that existed at the time of that call.  
  
 After a call to **Rollback**, the transaction is over, and you must call **BeginTrans** again for another transaction. The record that was current before you called **BeginTrans** becomes the current record again after **Rollback**.  
  
 After a rollback, the record that was current before the rollback remains current. For details about the state of the recordset and the data source after a rollback, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
### Example  
  See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
##  \<a name="cdatabase__setlogintimeout">\</a>  CDatabase::SetLoginTimeout  
 Call this member function — before you call <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> or **Open** — to override the default number of seconds allowed before an attempted data source connection times out.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 The number of seconds to allow before a connection attempt times out.  
  
### Remarks  
 A connection attempt might time out if, for example, the DBMS is not available. Call **SetLoginTimeout** after you construct the uninitialized <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> object but before you call <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> or **Open**.  
  
 The default value for login timeouts is 15 seconds. Not all data sources support the ability to specify a login timeout value. If the data source does not support timeout, you get trace output but not an exception. A value of 0 means "infinite."  
  
##  \<a name="cdatabase__setquerytimeout">\</a>  CDatabase::SetQueryTimeout  
 Call this member function to override the default number of seconds to allow before subsequent operations on the connected data source time out.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 The number of seconds to allow before a query attempt times out.  
  
### Remarks  
 An operation might time out due to network access problems, excessive query processing time, and so on. Call <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> prior to opening your recordset or prior to calling the recordset's <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>, **Update** or **Delete** member functions if you want to change the query timeout value. The setting affects all subsequent **Open**, <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>, **Update**, and **Delete** calls to any recordsets associated with this <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> object. Changing the query timeout value for a recordset after opening does not change the value for the recordset. For example, subsequent **Move** operations do not use the new value.  
  
 The default value for query timeouts is 15 seconds. Not all data sources support the ability to set a query timeout value. If you set a query timeout value of 0, no timeout occurs; the communication with the data source may stop responding. This behavior may be useful during development. If the data source does not support timeout, you get trace output but not an exception.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset](../vs140/crecordset-class.md)