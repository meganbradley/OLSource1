---
title: "CRecordset Class"
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
  - "CRecordset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "database records [C++]"
  - "CRecordset class"
  - "ODBC recordsets [C++], CRecordset objects"
  - "sets of records [C++]"
ms.assetid: dd89a21d-ef39-4aab-891b-1e373d67c855
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset Class
Represents a set of records selected from a data source.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRecordset::CRecordset](#crecordset__crecordset)|Constructs a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object. Your derived class must provide a constructor that calls this one.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRecordset::AddNew](#crecordset__addnew)|Prepares for adding a new record. Call <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to complete the addition.|  
|[CRecordset::CanAppend](#crecordset__canappend)|Returns nonzero if new records can be added to the recordset via the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> member function.|  
|[CRecordset::CanBookmark](#crecordset__canbookmark)|Returns nonzero if the recordset supports bookmarks.|  
|[CRecordset::Cancel](#crecordset__cancel)|Cancels an asynchronous operation or a process from a second thread.|  
|[CRecordset::CancelUpdate](#crecordset__cancelupdate)|Cancels any pending updates due to an <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> operation.|  
|[CRecordset::CanRestart](#crecordset__canrestart)|Returns nonzero if <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> can be called to run the recordset's query again.|  
|[CRecordset::CanScroll](#crecordset__canscroll)|Returns nonzero if you can scroll through the records.|  
|[CRecordset::CanTransact](#crecordset__cantransact)|Returns nonzero if the data source supports transactions.|  
|[CRecordset::CanUpdate](#crecordset__canupdate)|Returns nonzero if the recordset can be updated (you can add, update, or delete records).|  
|[CRecordset::CheckRowsetError](#crecordset__checkrowseterror)|Called to handle errors generated during record fetching.|  
|[CRecordset::Close](#crecordset__close)|Closes the recordset and the ODBC **HSTMT** associated with it.|  
|[CRecordset::Delete](#crecordset__delete)|Deletes the current record from the recordset. You must explicitly scroll to another record after the deletion.|  
|[CRecordset::DoBulkFieldExchange](#crecordset__dobulkfieldexchange)|Called to exchange bulk rows of data from the data source to the recordset. Implements bulk record field exchange (Bulk RFX).|  
|[CRecordset::DoFieldExchange](#crecordset__dofieldexchange)|Called to exchange data (in both directions) between the field data members of the recordset and the corresponding record on the data source. Implements record field exchange (RFX).|  
|[CRecordset::Edit](#crecordset__edit)|Prepares for changes to the current record. Call <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to complete the edit.|  
|[CRecordset::FlushResultSet](#crecordset__flushresultset)|Returns nonzero if there is another result set to be retrieved, when using a predefined query.|  
|[CRecordset::GetBookmark](#crecordset__getbookmark)|Assigns the bookmark value of a record to the parameter object.|  
|[CRecordset::GetDefaultConnect](#crecordset__getdefaultconnect)|Called to get the default connection string.|  
|[CRecordset::GetDefaultSQL](#crecordset__getdefaultsql)|Called to get the default SQL string to execute.|  
|[CRecordset::GetFieldValue](#crecordset__getfieldvalue)|Returns the value of a field in a recordset.|  
|[CRecordset::GetODBCFieldCount](#crecordset__getodbcfieldcount)|Returns the number of fields in the recordset.|  
|[CRecordset::GetODBCFieldInfo](#crecordset__getodbcfieldinfo)|Returns specific kinds of information about the fields in a recordset.|  
|[CRecordset::GetRecordCount](#crecordset__getrecordcount)|Returns the number of records in the recordset.|  
|[CRecordset::GetRowsetSize](#crecordset__getrowsetsize)|Returns the number of records you wish to retrieve during a single fetch.|  
|[CRecordset::GetRowsFetched](#crecordset__getrowsfetched)|Returns the actual number of rows retrieved during a fetch.|  
|[CRecordset::GetRowStatus](#crecordset__getrowstatus)|Returns the status of the row after a fetch.|  
|[CRecordset::GetSQL](#crecordset__getsql)|Gets the SQL string used to select records for the recordset.|  
|[CRecordset::GetStatus](#crecordset__getstatus)|Gets the status of the recordset: the index of the current record and whether a final count of the records has been obtained.|  
|[CRecordset::GetTableName](#crecordset__gettablename)|Gets the name of the table on which the recordset is based.|  
|[CRecordset::IsBOF](#crecordset__isbof)|Returns nonzero if the recordset has been positioned before the first record. There is no current record.|  
|[CRecordset::IsDeleted](#crecordset__isdeleted)|Returns nonzero if the recordset is positioned on a deleted record.|  
|[CRecordset::IsEOF](#crecordset__iseof)|Returns nonzero if the recordset has been positioned after the last record. There is no current record.|  
|[CRecordset::IsFieldDirty](#crecordset__isfielddirty)|Returns nonzero if the specified field in the current record has been changed.|  
|[CRecordset::IsFieldNull](#crecordset__isfieldnull)|Returns nonzero if the specified field in the current record is null (has no value).|  
|[CRecordset::IsFieldNullable](#crecordset__isfieldnullable)|Returns nonzero if the specified field in the current record can be set to null (having no value).|  
|[CRecordset::IsOpen](#crecordset__isopen)|Returns nonzero if <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> has been called previously.|  
|[CRecordset::Move](#crecordset__move)|Positions the recordset to a specified number of records from the current record in either direction.|  
|[CRecordset::MoveFirst](#crecordset__movefirst)|Positions the current record on the first record in the recordset. Test for <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> first.|  
|[CRecordset::MoveLast](#crecordset__movelast)|Positions the current record on the last record or on the last rowset. Test for <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> first.|  
|[CRecordset::MoveNext](#crecordset__movenext)|Positions the current record on the next record or on the next rowset. Test for <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> first.|  
|[CRecordset::MovePrev](#crecordset__moveprev)|Positions the current record on the previous record or on the previous rowset. Test for <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> first.|  
|[CRecordset::OnSetOptions](#crecordset__onsetoptions)|Called to set options (used on selection) for the specified ODBC statement.|  
|[CRecordset::OnSetUpdateOptions](#crecordset__onsetupdateoptions)|Called to set options (used on update) for the specified ODBC statement.|  
|[CRecordset::Open](#crecordset__open)|Opens the recordset by retrieving the table or performing the query that the recordset represents.|  
|[CRecordset::RefreshRowset](#crecordset__refreshrowset)|Refreshes the data and status of the specified row(s).|  
|[CRecordset::Requery](#crecordset__requery)|Runs the recordset's query again to refresh the selected records.|  
|[CRecordset::SetAbsolutePosition](#crecordset__setabsoluteposition)|Positions the recordset on the record corresponding to the specified record number.|  
|[CRecordset::SetBookmark](#crecordset__setbookmark)|Positions the recordset on the record specified by the bookmark.|  
|[CRecordset::SetFieldDirty](#crecordset__setfielddirty)|Marks the specified field in the current record as changed.|  
|[CRecordset::SetFieldNull](#crecordset__setfieldnull)|Sets the value of the specified field in the current record to null (having no value).|  
|[CRecordset::SetLockingMode](#crecordset__setlockingmode)|Sets the locking mode to "optimistic" locking (the default) or "pessimistic" locking. Determines how records are locked for updates.|  
|[CRecordset::SetParamNull](#crecordset__setparamnull)|Sets the specified parameter to null (having no value).|  
|[CRecordset::SetRowsetCursorPosition](#crecordset__setrowsetcursorposition)|Positions the cursor on the specified row within the rowset.|  
|[CRecordset::SetRowsetSize](#crecordset__setrowsetsize)|Specifies the number of records you wish to retrieve during a fetch.|  
|[CRecordset::Update](#crecordset__update)|Completes an <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> operation by saving the new or edited data on the data source.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRecordset::m_hstmt](#crecordset__m_hstmt)|Contains the ODBC statement handle for the recordset. Type <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.|  
|[CRecordset::m_nFields](#crecordset__m_nfields)|Contains the number of field data members in the recordset. Type <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.|  
|[CRecordset::m_nParams](#crecordset__m_nparams)|Contains the number of parameter data members in the recordset. Type <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.|  
|[CRecordset::m_pDatabase](#crecordset__m_pdatabase)|Contains a pointer to the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object through which the recordset is connected to a data source.|  
|[CRecordset::m_strFilter](#crecordset__m_strfilter)|Contains a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> that specifies a Structured Query Language (SQL) <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> clause. Used as a filter to select only those records that meet certain criteria.|  
|[CRecordset::m_strSort](#crecordset__m_strsort)|Contains a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> that specifies a SQL <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> clause. Used to control how the records are sorted.|  
  
## Remarks  
 Known as "recordsets," <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> objects are typically used in two forms: dynasets and snapshots. A dynaset stays synchronized with data updates made by other users. A snapshot is a static view of the data. Each form represents a set of records fixed at the time the recordset is opened, but when you scroll to a record in a dynaset, it reflects changes subsequently made to the record, either by other users or by other recordsets in your application.  
  
> [!NOTE]
>  If you are working with the Data Access Objects (DAO) classes rather than the Open Database Connectivity (ODBC) classes, use class [CDaoRecordset](../vs140/cdaorecordset-class.md) instead. For more information, see the article [Overview: Database Programming](../vs140/data-access-programming--mfc-atl-.md).  
  
 To work with either kind of recordset, you typically derive an application-specific recordset class from <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>. Recordsets select records from a data source, and you can then:  
  
-   Scroll through the records.  
  
-   Update the records and specify a locking mode.  
  
-   Filter the recordset to constrain which records it selects from those available on the data source.  
  
-   Sort the recordset.  
  
-   Parameterize the recordset to customize its selection with information not known until run time.  
  
 To use your class, open a database and construct a recordset object, passing the constructor a pointer to your <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object. Then call the recordset's **Open** member function, where you can specify whether the object is a dynaset or a snapshot. Calling **Open** selects data from the data source. After the recordset object is opened, use its member functions and data members to scroll through the records and operate on them. The operations available depend on whether the object is a dynaset or a snapshot, whether it is updatable or read-only (this depends on the capability of the Open Database Connectivity (ODBC) data source), and whether you have implemented bulk row fetching. To refresh records that may have been changed or added since the **Open** call, call the object's **Requery** member function. Call the object's **Close** member function and destroy the object when you finish with it.  
  
 In a derived <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> class, record field exchange (RFX) or bulk record field exchange (Bulk RFX) is used to support reading and updating of record fields.  
  
 For more information about recordsets and record field exchange, see the articles [Overview: Database Programming](../vs140/data-access-programming--mfc-atl-.md), [Recordset (ODBC)](../vs140/recordset--odbc-.md), [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md), and [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md). For a focus on dynasets and snapshots, see the articles [Dynaset](../vs140/dynaset.md) and [Snapshot](../vs140/snapshot.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdb.h  
  
##  \<a name="crecordset__addnew">\</a>  CRecordset::AddNew  
 Prepares for adding a new record to the table.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 You must call the [Requery](#crecordset__requery) member function to see the newly added record. The record's fields are initially Null. (In database terminology, Null means "having no value" and is not the same as **NULL** in C++.) To complete the operation, you must call the [Update](#crecordset__update) member function. **Update** saves your changes to the data source.  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. This will result in a failed assertion. Although class <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> does not provide a mechanism for updating bulk rows of data, you can write your own functions by using the ODBC API function **SQLSetPos**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> prepares a new, empty record using the recordset's field data members. After you call <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, set the values you want in the recordset's field data members. (You do not have to call the [Edit](#crecordset__edit) member function for this purpose; use **Edit** only for existing records.) When you subsequently call **Update**, changed values in the field data members are saved on the data source.  
  
> [!CAUTION]
>  If you scroll to a new record before you call **Update**, the new record is lost, and no warning is given.  
  
 If the data source supports transactions, you can make your <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> call part of a transaction. For more information about transactions, see class [CDatabase](../vs140/cdatabase-class.md). Note that you should call [CDatabase::BeginTrans](../vs140/cdatabase-class.md#cdatabase__begintrans) before calling <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  For dynasets, new records are added to the recordset as the last record. Added records are not added to snapshots; you must call **Requery** to refresh the recordset.  
  
 It is illegal to call <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> for a recordset whose **Open** member function has not been called. A <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is thrown if you call <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> for a recordset that cannot be appended to. You can determine whether the recordset is updatable by calling [CanAppend](#crecordset__canappend).  
  
 For more information, see the following articles: [Recordset: How Recordsets Update Records (ODBC)](../vs140/recordset--how-recordsets-update-records--odbc-.md), [Recordset: Adding, Updating, and Deleting Records (ODBC)](../vs140/recordset--adding--updating--and-deleting-records--odbc-.md), and [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
### Example  
 See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
##  \<a name="crecordset__canappend">\</a>  CRecordset::CanAppend  
 Determines whether the previously opened recordset allows you to add new records.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset allows adding new records; otherwise 0. <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> will return 0 if you opened the recordset as read-only.  
  
##  \<a name="crecordset__canbookmark">\</a>  CRecordset::CanBookmark  
 Determines whether the recordset allows you to mark records using bookmarks.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset supports bookmarks; otherwise 0.  
  
### Remarks  
 This function is independent of the **CRecordset::useBookmarks** option in the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function. <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> indicates whether the given ODBC driver and cursor type support bookmarks. **CRecordset::useBookmarks** indicates whether bookmarks will be available, provided they are supported.  
  
> [!NOTE]
>  Bookmarks are not supported on forward-only recordsets.  
  
 For more information about bookmarks and recordset navigation, see the articles [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md) and [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
##  \<a name="crecordset__cancel">\</a>  CRecordset::Cancel  
 Requests that the data source cancel either an asynchronous operation in progress or a process from a second thread.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Note that the MFC ODBC classes no longer use asynchronous processing; to perform an asychronous operation, you must directly call the ODBC API function **SQLSetConnectOption**. For more information, see the topic "Executing Functions Asynchronously" in the                         *ODBC SDK Programmer's Guide*.  
  
##  \<a name="crecordset__cancelupdate">\</a>  CRecordset::CancelUpdate  
 Cancels any pending updates, caused by an [Edit](#crecordset__edit) or [AddNew](#crecordset__addnew) operation, before [Update](#crecordset__update) is called.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
  
> [!NOTE]
>  This member function is not applicable on recordsets that are using bulk row fetching, since such recordsets cannot call **Edit**, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, or **Update**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 If automatic dirty field checking is enabled, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> will restore the member variables to the values they had before **Edit** or <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> was called; otherwise, any value changes will remain. By default, automatic field checking is enabled when the recordset is opened. To disable it, you must specify the **CRecordset::noDirtyFieldCheck** in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function.  
  
 For more information about updating data, see the article [Recordset: Adding, Updating, and Deleting Records (ODBC)](../vs140/recordset--adding--updating--and-deleting-records--odbc-.md).  
  
##  \<a name="crecordset__canrestart">\</a>  CRecordset::CanRestart  
 Determines whether the recordset allows restarting its query (to refresh its records) by calling the **Requery** member function.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if requery is allowed; otherwise 0.  
  
##  \<a name="crecordset__canscroll">\</a>  CRecordset::CanScroll  
 Determines whether the recordset allows scrolling.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset allows scrolling; otherwise 0.  
  
### Remarks  
 For more information about scrolling, see the article [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
##  \<a name="crecordset__cantransact">\</a>  CRecordset::CanTransact  
 Determines whether the recordset allows transactions.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset allows transactions; otherwise 0.  
  
### Remarks  
 For more information, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
##  \<a name="crecordset__canupdate">\</a>  CRecordset::CanUpdate  
 Determines whether the recordset can be updated.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset can be updated; otherwise 0.  
  
### Remarks  
 A recordset might be read-only if the underlying data source is read-only or if you specified **CRecordset::readOnly** in the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> parameter when you opened the recordset.  
  
##  \<a name="crecordset__checkrowseterror">\</a>  CRecordset::CheckRowsetError  
 Called to handle errors generated during record fetching.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 An ODBC API function return code. For details, see Remarks.  
  
### Remarks  
 This virtual member function handles errors that occur when records are fetched, and is useful during bulk row fetching. You may want to consider overriding <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> to implement your own error handling.  
  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> is called automatically in a cursor navigation operation, such as **Open**, **Requery**, or any **Move** operation. It is passed the return value of the ODBC API function **SQLExtendedFetch**. The following table lists the possible values for the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> parameter.  
  
|nRetCode|Description|  
|--------------|-----------------|  
|**SQL_SUCCESS**|Function completed successfully; no additional information is available.|  
|**SQL_SUCCESS_WITH_INFO**|Function completed successfully, possibly with a nonfatal error. Additional information can be obtained by calling **SQLError**.|  
|**SQL_NO_DATA_FOUND**|All rows from the result set have been fetched.|  
|**SQL_ERROR**|Function failed. Additional information can be obtained by calling **SQLError**.|  
|**SQL_INVALID_HANDLE**|Function failed due to an invalid environment handle, connection handle, or statement handle. This indicates a programming error. No additional information is available from **SQLError**.|  
|<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>|A function that was started asynchronously is still executing. Note that by default, MFC will never pass this value to <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>; MFC will continue calling **SQLExtendedFetch** until it no longer returns <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.|  
  
 For more information about **SQLError**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__close">\</a>  CRecordset::Close  
 Closes the recordset.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The ODBC **HSTMT** and all memory the framework allocated for the recordset are deallocated. Usually after calling **Close**, you delete the C++ recordset object if it was allocated with **new**.  
  
 You can call **Open** again after calling **Close**. This lets you reuse the recordset object. The alternative is to call **Requery**.  
  
### Example  
 [!code[NVC_MFCDatabase#17](../vs140/codesnippet/CPP/crecordset-class_1.cpp)]  
  
##  \<a name="crecordset__crecordset">\</a>  CRecordset::CRecordset  
 Constructs a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 Contains a pointer to a <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> object or the value **NULL**. If not **NULL** and the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object's **Open** member function has not been called to connect it to the data source, the recordset attempts to open it for you during its own **Open** call. If you pass **NULL**, a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object is constructed and connected for you using the data source information you specified when you derived your recordset class with ClassWizard.  
  
### Remarks  
 You can either use <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> directly or derive an application-specific class from <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>. You can use ClassWizard to derive your recordset classes.  
  
> [!NOTE]
>  A derived class                             *must* supply its own constructor. In the constructor of your derived class, call the constructor <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, passing the appropriate parameters along to it.  
  
 Pass **NULL** to your recordset constructor to have a <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object constructed and connected for you automatically. This is a useful shorthand that does not require you to construct and connect a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object prior to constructing your recordset.  
  
### Example  
 For more information, see the article [Recordset: Declaring a Class for a Table (ODBC)](../vs140/recordset--declaring-a-class-for-a-table--odbc-.md).  
  
##  \<a name="crecordset__delete">\</a>  CRecordset::Delete  
 Deletes the current record.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 After a successful deletion, the recordset's field data members are set to a Null value, and you must explicitly call one of the **Move** functions in order to move off the deleted record. Once you move off the deleted record, it is not possible to return to it. If the data source supports transactions, you can make the **Delete** call part of a transaction. For more information, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call **Delete**. This will result in a failed assertion. Although class <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> does not provide a mechanism for updating bulk rows of data, you can write your own functions by using the ODBC API function **SQLSetPos**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
> [!CAUTION]
>  The recordset must be updatable and there must be a valid record current in the recordset when you call **Delete**; otherwise, an error occurs. For example, if you delete a record but do not scroll to a new record before you call **Delete** again, **Delete** throws a [CDBException](../vs140/cdbexception-class.md).  
  
 Unlike [AddNew](#crecordset__addnew) and [Edit](#crecordset__edit), a call to **Delete** is not followed by a call to [Update](#crecordset__update). If a **Delete** call fails, the field data members are left unchanged.  
  
### Example  
 This example shows a recordset created on the frame of a function. The example assumes the existence of <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, a member variable of type <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> already connected to the data source.  
  
 [!code[NVC_MFCDatabase#18](../vs140/codesnippet/CPP/crecordset-class_2.cpp)]  
  
##  \<a name="crecordset__dobulkfieldexchange">\</a>  CRecordset::DoBulkFieldExchange  
 Called to exchange bulk rows of data from the data source to the recordset. Implements bulk record field exchange (Bulk RFX).  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 A pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object. The framework will already have set up this object to specify a context for the field exchange operation.  
  
### Remarks  
 When bulk row fetching is implemented, the framework calls this member function to automatically transfer data from the data source to your recordset object. <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> also binds your parameter data members, if any, to parameter placeholders in the SQL statement string for the recordset's selection.  
  
 If bulk row fetching is not implemented, the framework calls [DoFieldExchange](#crecordset__dofieldexchange). To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> parameter in the [Open](#crecordset__open) member function.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> is available only if you are using a class derived from <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>. If you have created a recordset object directly from <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>, you must call the [GetFieldValue](#crecordset__getfieldvalue) member function to retrieve data.  
  
 Bulk record field exchange (Bulk RFX) is similar to record field exchange (RFX). Data is automatically transferred from the data source to the recordset object. However, you cannot call <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>, **Edit**, **Delete**, or **Update** to transfer changes back to the data source. Class <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> currently does not provide a mechanism for updating bulk rows of data; however, you can write your own functions by using the ODBC API function **SQLSetPos**.  
  
 Note that ClassWizard does not support bulk record field exchange; therefore, you must override <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> manually by writing calls to the Bulk RFX functions. For more information about these functions, see the topic [Record Field Exchange Functions](../vs140/record-field-exchange-functions.md).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). For related information, see the article [Record Field Exchange (RFX)](../vs140/record-field-exchange--rfx-.md).  
  
##  \<a name="crecordset__dofieldexchange">\</a>  CRecordset::DoFieldExchange  
 Called to exchange data (in both directions) between the field data members of the recordset and the corresponding record on the data source. Implements record field exchange (RFX).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 A pointer to a [CFieldExchange](../vs140/cfieldexchange-class.md) object. The framework will already have set up this object to specify a context for the field exchange operation.  
  
### Remarks  
 When bulk row fetching is not implemented, the framework calls this member function to automatically exchange data between the field data members of your recordset object and the corresponding columns of the current record on the data source. <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> also binds your parameter data members, if any, to parameter placeholders in the SQL statement string for the recordset's selection.  
  
 If bulk row fetching is implemented, the framework calls [DoBulkFieldExchange](#crecordset__dobulkfieldexchange). To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> parameter in the [Open](#crecordset__open) member function.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> is available only if you are using a class derived from <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>. If you have created a recordset object directly from <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, you must call the [GetFieldValue](#crecordset__getfieldvalue) member function to retrieve data.  
  
 The exchange of field data, called record field exchange (RFX), works in both directions: from the recordset object's field data members to the fields of the record on the data source, and from the record on the data source to the recordset object.  
  
 The only action you must normally take to implement <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> for your derived recordset class is to create the class with ClassWizard and specify the names and data types of the field data members. You might also add code to what ClassWizard writes to specify parameter data members or to deal with any columns you bind dynamically. For more information, see the article [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md).  
  
 When you declare your derived recordset class with ClassWizard, the wizard writes an override of <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> for you, which resembles the following example:  
  
 [!code[NVC_MFCDatabase#19](../vs140/codesnippet/CPP/crecordset-class_3.cpp)]  
  
 For more information about the RFX functions, see the topic [Record Field Exchange Functions](../vs140/record-field-exchange-functions.md).  
  
 For further examples and details about <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, see the article [Record Field Exchange: How RFX Works](../vs140/record-field-exchange--how-rfx-works.md). For general information about RFX, see the article [Record Field Exchange](../vs140/record-field-exchange--rfx-.md).  
  
##  \<a name="crecordset__edit">\</a>  CRecordset::Edit  
 Allows changes to the current record.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 After you call **Edit**, you can change the field data members by directly resetting their values. The operation is completed when you subsequently call the [Update](#crecordset__update) member function to save your changes on the data source.  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call **Edit**. This will result in a failed assertion. Although class <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> does not provide a mechanism for updating bulk rows of data, you can write your own functions by using the ODBC API function **SQLSetPos**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 **Edit** saves the values of the recordset's data members. If you call **Edit**, make changes, then call **Edit** again, the record's values are restored to what they were before the first **Edit** call.  
  
 In some cases, you may want to update a column by making it Null (containing no data). To do so, call [SetFieldNull](#crecordset__setfieldnull) with a parameter of **TRUE** to mark the field Null; this also causes the column to be updated. If you want a field to be written to the data source even though its value has not changed, call [SetFieldDirty](#crecordset__setfielddirty) with a parameter of **TRUE**. This works even if the field had the value Null.  
  
 If the data source supports transactions, you can make the **Edit** call part of a transaction. Note that you should call [CDatabase::BeginTrans](../vs140/cdatabase-class.md#cdatabase__begintrans) before calling **Edit** and after the recordset has been opened. Also note that calling [CDatabase::CommitTrans](../vs140/cdatabase-class.md#cdatabase__committrans) is not a substitute for calling **Update** to complete the **Edit** operation. For more information about transactions, see class [CDatabase](../vs140/cdatabase-class.md).  
  
 Depending on the current locking mode, the record being updated may be locked by **Edit** until you call **Update** or scroll to another record, or it may be locked only during the **Edit** call. You can change the locking mode with [SetLockingMode](#crecordset__setlockingmode).  
  
 The previous value of the current record is restored if you scroll to a new record before calling **Update**. A <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> is thrown if you call **Edit** for a recordset that cannot be updated or if there is no current record.  
  
 For more information, see the articles [Transaction (ODBC)](../vs140/transaction--odbc-.md) and [Recordset: Locking Records (ODBC)](../vs140/recordset--locking-records--odbc-.md).  
  
### Example  
 [!code[NVC_MFCDatabase#20](../vs140/codesnippet/CPP/crecordset-class_4.cpp)]  
  
##  \<a name="crecordset__flushresultset">\</a>  CRecordset::FlushResultSet  
 Retrieves the next result set of a predefined query (stored procedure), if there are multiple result sets.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if there are more result sets to be retrieved; otherwise 0.  
  
### Remarks  
 You should call <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> only when you are completely finished with the cursor on the current result set. Note that when you retrieve the next result set by calling <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>, your cursor is not valid on that result set; you should call the [MoveNext](#crecordset__movenext) member function after calling <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>.  
  
 If a predefined query uses an output parameter or input/output parameters, you must call <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> until it returns <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> (the value 0), in order to obtain these parameter values.  
  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> calls the ODBC API function <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> will throw an exception. For more information about <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Your stored procedure needs to have bound fields if you want to call <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
### Example  
 The following code assumes that <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>-derived object based on a predefined query with an input parameter and an output parameter, and having multiple result sets. Note the structure of the [DoFieldExchange](#crecordset__dofieldexchange) override.  
  
 [!code[NVC_MFCDatabase#21](../vs140/codesnippet/CPP/crecordset-class_5.cpp)]  
  
 [!code[NVC_MFCDatabase#22](../vs140/codesnippet/CPP/crecordset-class_6.cpp)]  
  
##  \<a name="crecordset__getbookmark">\</a>  CRecordset::GetBookmark  
 Obtains the bookmark value for the current record.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A reference to a [CDBVariant](../vs140/cdbvariant-class.md) object representing the bookmark on the current record.  
  
### Remarks  
 To determine if bookmarks are supported on the recordset, call [CanBookmark](#crecordset__canbookmark). To make bookmarks available if they are supported, you must set the **CRecordset::useBookmarks** option in the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function.  
  
> [!NOTE]
>  If bookmarks are unsupported or unavailable, calling <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> will result in an exception being thrown. Bookmarks are not supported on forward-only recordsets.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> assigns the value of the bookmark for the current record to a <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> object. To return to that record at any time after moving to a different record, call [SetBookmark](#crecordset__setbookmark) with the corresponding <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  After certain recordset operations, bookmarks may no longer be valid. For example, if you call <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> followed by **Requery**, you may not be able to return to the record with <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>. Call [CDatabase::GetBookmarkPersistence](../vs140/cdatabase-class.md#cdatabase__getbookmarkpersistence) to check whether you can safely call <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
 For more information about bookmarks and recordset navigation, see the articles [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md) and [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
##  \<a name="crecordset__getdefaultconnect">\</a>  CRecordset::GetDefaultConnect  
 Called to get the default connection string.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> that contains the default connection string.  
  
### Remarks  
 The framework calls this member function to get the default connection string for the data source on which the recordset is based. ClassWizard implements this function for you by identifying the same data source you use in ClassWizard to get information about tables and columns. You will probably find it convenient to rely on this default connection while developing your application. But the default connection may not be appropriate for users of your application. If that is the case, you should reimplement this function, discarding ClassWizard's version. For more information about connection strings, see the article [Data Source (ODBC)](../vs140/data-source--odbc-.md).  
  
##  \<a name="crecordset__getdefaultsql">\</a>  CRecordset::GetDefaultSQL  
 Called to get the default SQL string to execute.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> that contains the default SQL statement.  
  
### Remarks  
 The framework calls this member function to get the default SQL statement on which the recordset is based. This might be a table name or a SQL **SELECT** statement.  
  
 You indirectly define the default SQL statement by declaring your recordset class with ClassWizard, and ClassWizard performs this task for you.  
  
 If you need the SQL statement string for your own use, call <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, which returns the SQL statement used to select the recordset's records when it was opened. You can edit the default SQL string in your class's override of <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>. For example, you could specify a call to a predefined query using a **CALL** statement. (Note, however, that if you edit <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>, you also need to modify <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> to match the number of columns in the data source.)  
  
 For more information, see the article [Recordset: Declaring a Class for a Table (ODBC)](../vs140/recordset--declaring-a-class-for-a-table--odbc-.md).  
  
> [!CAUTION]
>  The table name will be empty if the framework could not identify a table name, if multiple table names were supplied, or if a **CALL** statement could not be interpreted. Note that when using a **CALL** statement, you must not insert whitespace between the curly brace and the **CALL** keyword, nor should you insert whitespace before the curly brace or before the **SELECT** keyword in a **SELECT** statement.  
  
##  \<a name="crecordset__getfieldvalue">\</a>  CRecordset::GetFieldValue  
 Retrieves field data in the current record.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The name of a field.  
  
 *varValu*e  
 A reference to a [CDBVariant](../vs140/cdbvariant-class.md) object that will store the field's value.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 The ODBC C data type of the field. Using the default value, **DEFAULT_FIELD_TYPE**, forces <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> to determine the C data type from the SQL data type, based on the following table. Otherwise, you can specify the data type directly or choose a compatible data type; for example, you can store any data type into **SQL_C_CHAR**.  
  
|C data type|SQL data type|  
|-----------------|-------------------|  
|**SQL_C_BIT**|**SQL_BIT**|  
|**SQL_C_UTINYINT**|**SQL_TINYINT**|  
|**SQL_C_SSHORT**|**SQL_SMALLINT**|  
|**SQL_C_SLONG**|**SQL_INTEGER**|  
|**SQL_C_FLOAT**|**SQL_REAL**|  
|**SQL_C_DOUBLE**|**SQL_FLOATSQL_DOUBLE**|  
|**SQL_C_TIMESTAMP**|**SQL_DATESQL_TIMESQL_TIMESTAMP**|  
|**SQL_C_CHAR**|**SQL_NUMERICSQL_DECIMALSQL_BIGINTSQL_CHARSQL_VARCHARSQL_LONGVARCHAR**|  
|**SQL_C_BINARY**|**SQL_BINARYSQL_VARBINARYSQL_LONGVARBINARY**|  
  
 For more information about ODBC data types, see the topics "SQL Data Types" and "C Data Types" in Appendix D of the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The zero-based index of the field.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object that will store the field's value converted to text, regardless of the field's data type.  
  
### Remarks  
 You can look up a field either by name or by index. You can store the field value in either a <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object or a <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> object.  
  
 If you have implemented bulk row fetching, the current record is always positioned on the first record in a rowset. To use <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> on a record within a given rowset, you must first call the [SetRowsetCursorPosition](#crecordset__setrowsetcursorposition) member function to move the cursor to the desired row within that rowset. Then call <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> for that row. To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> parameter in the [Open](#crecordset__open) member function.  
  
 You can use <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> to dynamically fetch fields at run time rather than statically binding them at design time. For example, if you have declared a recordset object directly from <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, you must use <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> to retrieve the field data; record field exchange (RFX), or bulk record field exchange (Bulk RFX), is not implemented.  
  
> [!NOTE]
>  If you declare a recordset object without deriving from <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>, do not have the ODBC Cursor Library loaded. The cursor library requires that the recordset have at least one bound column; however, when you use <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> directly, none of the columns are bound. The member functions [CDatabase::OpenEx](../vs140/cdatabase-class.md#cdatabase__openex) and [CDatabase::Open](../vs140/cdatabase-class.md#cdatabase__open) control whether the cursor library will be loaded.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> calls the ODBC API function **SQLGetData**. If your driver outputs the value **SQL_NO_TOTAL** for the actual length of the field value, <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> throws an exception. For more information about **SQLGetData**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 The following sample code illustrates calls to <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> for a recordset object declared directly from <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCDatabase#23](../vs140/codesnippet/CPP/crecordset-class_7.cpp)]  
  
> [!NOTE]
>  Unlike the DAO class <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> does not have a <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> member function. If you create an object directly from <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>, it is effectively read-only.  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__getodbcfieldcount">\</a>  CRecordset::GetODBCFieldCount  
 Retrieves the total number of fields in your recordset object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The number of fields in the recordset.  
  
### Remarks  
 For more information about creating recordsets, see the article [Recordset: Creating and Closing Recordsets (ODBC)](../vs140/recordset--creating-and-closing-recordsets--odbc-.md).  
  
##  \<a name="crecordset__getodbcfieldinfo">\</a>  CRecordset::GetODBCFieldInfo  
 Obtains information about the fields in the recordset.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The name of a field.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 The zero-based index of the field.  
  
### Remarks  
 One version of the function lets you look up a field by name. The other version lets you look up a field by index.  
  
 For a description about the information returned, see the [CODBCFieldInfo](../vs140/codbcfieldinfo-structure.md) structure.  
  
 For more information about creating recordsets, see the article [Recordset: Creating and Closing Recordsets (ODBC)](../vs140/recordset--creating-and-closing-recordsets--odbc-.md).  
  
##  \<a name="crecordset__getrecordcount">\</a>  CRecordset::GetRecordCount  
 Determines the size of the recordset.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The number of records in the recordset; 0 if the recordset contains no records; or –1 if the record count cannot be determined.  
  
### Remarks  
  
> [!CAUTION]
>  The record count is maintained as a "high water mark," the highest-numbered record yet seen as the user moves through the records. The total number of records is only known after the user has moved beyond the last record. For performance reasons, the count is not updated when you call <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>. To count the records yourself, call <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> repeatedly until <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> returns nonzero. Adding a record via **CRecordset:AddNew** and **Update** increases the count; deleting a record via <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> decreases the count.  
  
##  \<a name="crecordset__getrowsetsize">\</a>  CRecordset::GetRowsetSize  
 Obtains the current setting for the number of rows you wish to retrieve during a given fetch.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The number of rows to retrieve during a given fetch.  
  
### Remarks  
 If you are using bulk row fetching, the default rowset size when the recordset is opened is 25; otherwise, it is 1.  
  
 To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> option in the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function. To change the setting for the rowset size, call [SetRowsetSize](#crecordset__setrowsetsize).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__getrowsfetched">\</a>  CRecordset::GetRowsFetched  
 Determines how many records were actually retrieved after a fetch.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 The number of rows retrieved from the data source after a given fetch.  
  
### Remarks  
 This is useful when you have implemented bulk row fetching. The rowset size normally indicates how many rows will be retrieved from a fetch; however, the total number of rows in the recordset also affects how many rows will be retrieved in a rowset. For example, if your recordset has 10 records with a rowset size setting of 4, then looping through the recordset by calling <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> will result in the final rowset having only 2 records.  
  
 To implement bulk row fetching, you must specify the <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> option in the <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function. To specify the rowset size, call [SetRowsetSize](#crecordset__setrowsetsize).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
### Example  
 [!code[NVC_MFCDatabase#24](../vs140/codesnippet/CPP/crecordset-class_8.cpp)]  
  
##  \<a name="crecordset__getrowstatus">\</a>  CRecordset::GetRowStatus  
 Obtains the status for a row in the current rowset.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The one-based position of a row in the current rowset. This value can range from 1 to the size of the rowset.  
  
### Return Value  
 A status value for the row. For details, see Remarks.  
  
### Remarks  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> returns a value that indicates either any change in status to the row since it was last retrieved from the data source, or that no row corresponding to <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> was fetched. The following table lists the possible return values.  
  
|Status value|Description|  
|------------------|-----------------|  
|<CodeContentPlaceHolder>213\</CodeContentPlaceHolder>|The row is unchanged.|  
|<CodeContentPlaceHolder>214\</CodeContentPlaceHolder>|The row has been updated.|  
|<CodeContentPlaceHolder>215\</CodeContentPlaceHolder>|The row has been deleted.|  
|<CodeContentPlaceHolder>216\</CodeContentPlaceHolder>|The row has been added.|  
|<CodeContentPlaceHolder>217\</CodeContentPlaceHolder>|The row is unretrievable due to an error.|  
|<CodeContentPlaceHolder>218\</CodeContentPlaceHolder>|There is no row that corresponds to <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>.|  
  
 For more information, see the ODBC API function **SQLExtendedFetch** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crecordset__getstatus">\</a>  CRecordset::GetStatus  
 Determines the index of the current record in the recordset and whether the last record has been seen.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 A reference to a **CRecordsetStatus** object. See the Remarks section for more information.  
  
### Remarks  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> attempts to track the index, but under some circumstances this may not be possible. See [GetRecordCount](#crecordset__getrecordcount) for an explanation.  
  
 The **CRecordsetStatus** structure has the following form:  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>  
  
 The two members of **CRecordsetStatus** have the following meanings:  
  
-   **m_lCurrentRecord** Contains the zero-based index of the current record in the recordset, if known. If the index cannot be determined, this member contains **AFX_CURRENT_RECORD_UNDEFINED** (–2). If <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> is **TRUE** (empty recordset or attempt to scroll before first record), then **m_lCurrentRecord** is set to **AFX_CURRENT_RECORD_BOF** (–1). If on the first record, then it is set to 0, second record 1, and so on.  
  
-   **m_bRecordCountFinal** Nonzero if the total number of records in the recordset has been determined. Generally this must be accomplished by starting at the beginning of the recordset and calling <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> until <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> returns nonzero. If this member is zero, the record count as returned by <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>, if not –1, is only a "high water mark" count of the records.  
  
##  \<a name="crecordset__getsql">\</a>  CRecordset::GetSQL  
 Call this member function to get the SQL statement that was used to select the recordset's records when it was opened.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 A **const** reference to a <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> that contains the SQL statement.  
  
### Remarks  
 This will generally be a SQL **SELECT** statement. The string returned by <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> is read-only.  
  
 The string returned by <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> is typically different from any string you may have passed to the recordset in the <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> parameter to the **Open** member function. This is because the recordset constructs a full SQL statement based on what you passed to **Open**, what you specified with ClassWizard, what you may have specified in the **m_strFilter** and <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> data members, and any parameters you may have specified. For details about how the recordset constructs this SQL statement, see the article [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md).  
  
> [!NOTE]
>  Call this member function only after calling [Open](#crecordset__open).  
  
##  \<a name="crecordset__gettablename">\</a>  CRecordset::GetTableName  
 Gets the name of the SQL table on which the recordset's query is based.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 A **const** reference to a <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> that contains the table name, if the recordset is based on a table; otherwise, an empty string.  
  
### Remarks  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> is only valid if the recordset is based on a table, not a join of multiple tables or a predefined query (stored procedure). The name is read-only.  
  
> [!NOTE]
>  Call this member function only after calling [Open](#crecordset__open).  
  
##  \<a name="crecordset__isbof">\</a>  CRecordset::IsBOF  
 Returns nonzero if the recordset has been positioned before the first record. There is no current record.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset contains no records or if you have scrolled backward before the first record; otherwise 0.  
  
### Remarks  
 Call this member function before you scroll from record to record to learn whether you have gone before the first record of the recordset. You can also use <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> along with <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> to determine whether the recordset contains any records or is empty. Immediately after you call **Open**, if the recordset contains no records, <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> returns nonzero.When you open a recordset that has at least one record, the first record is the current record and <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> returns 0.  
  
 If the first record is the current record and you call <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> will subsequently return nonzero. If <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> returns nonzero and you call <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>, an error occurs. If <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> returns nonzero, the current record is undefined, and any action that requires a current record will result in an error.  
  
### Example  
 This example uses <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> to detect the limits of a recordset as the code scrolls through the recordset in both directions.  
  
 [!code[NVC_MFCDatabase#25](../vs140/codesnippet/CPP/crecordset-class_9.cpp)]  
  
##  \<a name="crecordset__isdeleted">\</a>  CRecordset::IsDeleted  
 Determines whether the current record has been deleted.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset is positioned on a deleted record; otherwise 0.  
  
### Remarks  
 If you scroll to a record and <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> returns **TRUE** (nonzero), then you must scroll to another record before you can perform any other recordset operations.  
  
 The result of <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> depends on many factors, such as your recordset type, whether your recordset is updatable, whether you specified the **CRecordset::skipDeletedRecords** option when you opened the recordset, whether your driver packs deleted records, and whether there are multiple users.  
  
 For more information about **CRecordset::skipDeletedRecords** and driver packing, see the [Open](#crecordset__open) member function.  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you should not call <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>. Instead, call the [GetRowStatus](#crecordset__getrowstatus) member function. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__iseof">\</a>  CRecordset::IsEOF  
 Returns nonzero if the recordset has been positioned after the last record. There is no current record.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset contains no records or if you have scrolled beyond the last record; otherwise 0.  
  
### Remarks  
 Call this member function as you scroll from record to record to learn whether you have gone beyond the last record of the recordset. You can also use <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> to determine whether the recordset contains any records or is empty. Immediately after you call **Open**, if the recordset contains no records, <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> returns nonzero. When you open a recordset that has at least one record, the first record is the current record and <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> returns 0.  
  
 If the last record is the current record when you call <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> will subsequently return nonzero. If <CodeContentPlaceHolder>257\</CodeContentPlaceHolder> returns nonzero and you call <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>, an error occurs. If <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> returns nonzero, the current record is undefined, and any action that requires a current record will result in an error.  
  
### Example  
 See the example for [IsBOF](#crecordset__isbof).  
  
##  \<a name="crecordset__isfielddirty">\</a>  CRecordset::IsFieldDirty  
 Determines whether the specified field data member has been changed since [Edit](#crecordset__edit) or [AddNew](#crecordset__addnew) was called.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 A pointer to the field data member whose status you want to check, or **NULL** to determine if any of the fields are dirty.  
  
### Return Value  
 Nonzero if the specified field data member has changed since calling <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> or **Edit**; otherwise 0.  
  
### Remarks  
 The data in all dirty field data members will be transferred to the record on the data source when the current record is updated by a call to the [Update](#crecordset__update) member function of <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> (following a call to **Edit** or <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>).  
  
> [!NOTE]
>  This member function is not applicable on recordsets that are using bulk row fetching. If you have implemented bulk row fetching, then <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> will always return **FALSE** and will result in a failed assertion. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 Calling <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> will reset the effects of preceding calls to [SetFieldDirty](#crecordset__setfielddirty) since the dirty status of the field is re-evaluated. In the <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> case, if the current field value differs from the pseudo null value, the field status is set dirty. In the **Edit** case, if the field value differs from the cached value, then the field status is set dirty.  
  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> is implemented through [DoFieldExchange](#crecordset__dofieldexchange).  
  
 For more information on the dirty flag, see the article [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md).  
  
##  \<a name="crecordset__isfieldnull">\</a>  CRecordset::IsFieldNull  
 Returns nonzero if the specified field in the current record is Null (has no value).  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 A pointer to the field data member whose status you want to check, or **NULL** to determine if any of the fields are Null.  
  
### Return Value  
 Nonzero if the specified field data member is flagged as Null; otherwise 0.  
  
### Remarks  
 Call this member function to determine whether the specified field data member of a recordset has been flagged as Null. (In database terminology, Null means "having no value" and is not the same as **NULL** in C++.) If a field data member is flagged as Null, it is interpreted as a column of the current record for which there is no value.  
  
> [!NOTE]
>  This member function is not applicable on recordsets that are using bulk row fetching. If you have implemented bulk row fetching, then <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> will always return **FALSE** and will result in a failed assertion. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> is implemented through [DoFieldExchange](#crecordset__dofieldexchange).  
  
##  \<a name="crecordset__isfieldnullable">\</a>  CRecordset::IsFieldNullable  
 Returns nonzero if the specified field in the current record can be set to Null (having no value).  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 A pointer to the field data member whose status you want to check, or **NULL** to determine if any of the fields can be set to a Null value.  
  
### Remarks  
 Call this member function to determine whether the specified field data member is "nullable" (can be set to a Null value; C++ **NULL** is not the same as Null, which, in database terminology, means "having no value").  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>. Instead, call the [GetODBCFieldInfo](#crecordset__getodbcfieldinfo) member function to determine whether a field can be set to a Null value. Note that you can always call <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>, regardless of whether you have implemented bulk row fetching. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 A field that cannot be Null must have a value. If you attempt to set a such a field to Null when adding or updating a record, the data source rejects the addition or update, and [Update](#crecordset__update) will throw an exception. The exception occurs when you call **Update**, not when you call [SetFieldNull](#crecordset__setfieldnull).  
  
 Using **NULL** for the first argument of the function will apply the function only to **outputColumn** fields, not **param** fields. For instance, the call  
  
 [!code[NVC_MFCDatabase#26](../vs140/codesnippet/CPP/crecordset-class_10.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
 To work on **param** fields, you must supply the actual address of the individual **param** you want to work on, such as:  
  
 [!code[NVC_MFCDatabase#27](../vs140/codesnippet/CPP/crecordset-class_11.cpp)]  
  
 This means you cannot set all **param** fields to **NULL**, as you can with **outputColumn** fields.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder> is implemented through [DoFieldExchange](#crecordset__dofieldexchange).  
  
##  \<a name="crecordset__isopen">\</a>  CRecordset::IsOpen  
 Determines if the recordset is already open.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset object's [Open](#crecordset__open) or [Requery](#crecordset__requery) member function has previously been called and the recordset has not been closed; otherwise 0.  
  
##  \<a name="crecordset__m_hstmt">\</a>  CRecordset::m_hstmt  
 Contains a handle to the ODBC statement data structure, of type **HSTMT**, associated with the recordset.  
  
### Remarks  
 Each query to an ODBC data source is associated with an **HSTMT**.  
  
> [!CAUTION]
>  Do not use **m_hstmt** before [Open](#crecordset__open) has been called.  
  
 Normally you do not need to access the **HSTMT** directly, but you might need it for direct execution of SQL statements. The <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> provides an example of using **m_hstmt**.  
  
##  \<a name="crecordset__m_nfields">\</a>  CRecordset::m_nFields  
 Contains the number of field data members in the recordset class; that is, the number of columns selected by the recordset from the data source.  
  
### Remarks  
 The constructor for the recordset class must initialize <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> with the correct number. If you have not implemented bulk row fetching, ClassWizard writes this initialization for you when you use it to declare your recordset class. You can also write it manually.  
  
 The framework uses this number to manage interaction between the field data members and the corresponding columns of the current record on the data source.  
  
> [!CAUTION]
>  This number must correspond to the number of "output columns" registered in <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> after a call to [SetFieldType](../vs140/cfieldexchange-class.md#cfieldexchange__setfieldtype) with the parameter **CFieldExchange::outputColumn**.  
  
 You can bind columns dynamically, as explained in the article "Recordset: Dynamically Binding Data Columns." If you do so, you must increase the count in <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> to reflect the number of RFX or Bulk RFX function calls in your <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>282\</CodeContentPlaceHolder> member function for the dynamically bound columns.  
  
 For more information, see the articles [Recordset: Dynamically Binding Data Columns (ODBC)](../vs140/recordset--dynamically-binding-data-columns--odbc-.md) and [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
### Example  
 See the article [Record Field Exchange: Using RFX](../vs140/record-field-exchange--using-rfx.md).  
  
##  \<a name="crecordset__m_nparams">\</a>  CRecordset::m_nParams  
 Contains the number of parameter data members in the recordset class; that is, the number of parameters passed with the recordset's query.  
  
### Remarks  
 If your recordset class has any parameter data members, the constructor for the class must initialize <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> with the correct number. The value of <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> defaults to 0. If you add parameter data members (which you must do manually) you must also manually add an initialization in the class constructor to reflect the number of parameters (which must be at least as large as the number of '?' placeholders in your **m_strFilter** or <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> string).  
  
 The framework uses this number when it parameterizes the recordset's query.  
  
> [!CAUTION]
>  This number must correspond to the number of "params" registered in <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> after a call to [SetFieldType](../vs140/cfieldexchange-class.md#cfieldexchange__setfieldtype) with a parameter value of **CFieldExchange::inputParam**, **CFieldExchange::param**, **CFieldExchange::outputParam**, or **CFieldExchange::inoutParam**.  
  
### Example  
  See the articles [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md) and [Record Field Exchange: Using RFX](../vs140/record-field-exchange--using-rfx.md).  
  
##  \<a name="crecordset__m_pdatabase">\</a>  CRecordset::m_pDatabase  
 Contains a pointer to the <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> object through which the recordset is connected to a data source.  
  
### Remarks  
 This variable is set in two ways. Typically, you pass a pointer to an already connected <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> object when you construct the recordset object. If you pass **NULL** instead, <CodeContentPlaceHolder>290\</CodeContentPlaceHolder> creates a <CodeContentPlaceHolder>291\</CodeContentPlaceHolder> object for you and connects it. In either case, <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> stores the pointer in this variable.  
  
 Normally you will not directly need to use the pointer stored in **m_pDatabase**. If you write your own extensions to <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>, however, you might need to use the pointer. For example, you might need the pointer if you throw your own <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>s. Or you might need it if you need to do something using the same <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> object, such as running transactions, setting timeouts, or calling the <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> to execute SQL statements directly.  
  
##  \<a name="crecordset__m_strfilter">\</a>  CRecordset::m_strFilter  
 After you construct the recordset object, but before you call its **Open** member function, use this data member to store a <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> containing a SQL **WHERE** clause.  
  
### Remarks  
 The recordset uses this string to constrain (or filter) the records it selects during the **Open** or **Requery** call. This is useful for selecting a subset of records, such as "all salespersons based in California" ("state = CA"). The ODBC SQL syntax for a **WHERE** clause is  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
  
 Note that you do not include the **WHERE** keyword in your string. The framework supplies it.  
  
 You can also parameterize your filter string by placing '?' placeholders in it, declaring a parameter data member in your class for each placeholder, and passing parameters to the recordset at run time. This lets you construct the filter at run time. For more information, see the article [Recordset: Parameterizing a Recordset (ODBC)](../vs140/recordset--parameterizing-a-recordset--odbc-.md).  
  
 For more information about SQL **WHERE** clauses, see the article [SQL](../vs140/sql.md). For more information about selecting and filtering records, see the article [Recordset: Filtering Records (ODBC)](../vs140/recordset--filtering-records--odbc-.md).  
  
### Example  
 [!code[NVC_MFCDatabase#30](../vs140/codesnippet/CPP/crecordset-class_12.cpp)]  
  
##  \<a name="crecordset__m_strsort">\</a>  CRecordset::m_strSort  
 After you construct the recordset object, but before you call its **Open** member function, use this data member to store a <CodeContentPlaceHolder>300\</CodeContentPlaceHolder> containing a SQL **ORDER BY** clause.  
  
### Remarks  
 The recordset uses this string to sort the records it selects during the **Open** or **Requery** call. You can use this feature to sort a recordset on one or more columns. The ODBC SQL syntax for an **ORDER BY** clause is  
  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
  
 where a sort-specification is an integer or a column name. You can also specify ascending or descending order (the order is ascending by default) by appending "ASC" or "DESC" to the column list in the sort string. The selected records are sorted first by the first column listed, then by the second, and so on. For example, you might order a "Customers" recordset by last name, then first name. The number of columns you can list depends on the data source. For more information, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]*.*  
  
 Note that you do not include the **ORDER BY** keyword in your string. The framework supplies it.  
  
 For more information about SQL clauses, see the article [SQL](../vs140/sql.md). For more information about sorting records, see the article [Recordset: Sorting Records (ODBC)](../vs140/recordset--sorting-records--odbc-.md).  
  
### Example  
 [!code[NVC_MFCDatabase#31](../vs140/codesnippet/CPP/crecordset-class_13.cpp)]  
  
##  \<a name="crecordset__move">\</a>  CRecordset::Move  
 Moves the current record pointer within the recordset, either forward or backward.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 The number of rows to move forward or backward. Positive values move forward, toward the end of the recordset. Negative values move backward, toward the beginning.  
  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 Determines the rowset that **Move** will fetch. For details, see Remarks.  
  
### Remarks  
 If you pass a value of 0 for <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>, **Move** refreshes the current record; **Move** will end any current <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> or **Edit** mode, and will restore the current record's value before <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> or **Edit** was called.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See [CRecordset::IsDeleted](#crecordset__isdeleted) for more information. When you open a <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> with the **skipDeletedRecords** option set, **Move** asserts if the <CodeContentPlaceHolder>308\</CodeContentPlaceHolder> parameter is 0. This behavior prevents the refresh of rows that are deleted by other client applications using the same data. See the <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> parameter in [Open](#crecordset__open) for a description of **skipDeletedRecords**.  
  
 **Move** repositions the recordset by rowsets. Based on the values for <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>, **Move** fetches the appropriate rowset and then makes the first record in that rowset the current record. If you have not implemented bulk row fetching, then the rowset size is always 1. When fetching a rowset, **Move** directly calls the [CheckRowsetError](#crecordset__checkrowseterror) member function to handle any errors resulting from the fetch.  
  
 Depending on the values you pass, **Move** is equivalent to other <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> member functions. In particular, the value of <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> may indicate a member function that is more intuitive and often the preferred method for moving the current record.  
  
 The following table lists the possible values for <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>, the rowset that **Move** will fetch based on <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>, and any equivalent member function corresponding to <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>.  
  
|wFetchType|Fetched rowset|Equivalent member function|  
|----------------|--------------------|--------------------------------|  
|<CodeContentPlaceHolder>318\</CodeContentPlaceHolder> (the default value)|The rowset starting <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> row(s) from the first row in the current rowset.||  
|<CodeContentPlaceHolder>320\</CodeContentPlaceHolder>|The next rowset; <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> is ignored.|[MoveNext](#crecordset__movenext)|  
|<CodeContentPlaceHolder>322\</CodeContentPlaceHolder>|The previous rowset; <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> is ignored.|[MovePrev](#crecordset__moveprev)|  
|<CodeContentPlaceHolder>324\</CodeContentPlaceHolder>|The first rowset in the recordset; <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> is ignored.|[MoveFirst](#crecordset__movefirst)|  
|<CodeContentPlaceHolder>326\</CodeContentPlaceHolder>|The last complete rowset in the recordset; <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> is ignored.|[MoveLast](#crecordset__movelast)|  
|<CodeContentPlaceHolder>328\</CodeContentPlaceHolder>|If <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> > 0, the rowset starting <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> row(s) from the beginning of the recordset. If <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> < 0, the rowset starting <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> row(s) from the end of the recordset. If <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> = 0, then a beginning-of-file (BOF) condition is returned.|[SetAbsolutePosition](#crecordset__setabsoluteposition)|  
|<CodeContentPlaceHolder>334\</CodeContentPlaceHolder>|The rowset starting at the row whose bookmark value corresponds to <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>.|[SetBookmark](#crecordset__setbookmark)|  
  
> [!NOTE]
>  For foward-only recordsets, **Move** is only valid with a value of <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  Calling **Move** throws an exception if the recordset has no records. To determine whether the recordset has any records, call [IsBOF](#crecordset__isbof) and [IsEOF](#crecordset__iseof).  
  
> [!NOTE]
>  If you have scrolled past the beginning or end of the recordset ( <CodeContentPlaceHolder>338\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> returns nonzero), calling a **Move** function will possibly throw a <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>. For example, if <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> returns nonzero and <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> does not, then <CodeContentPlaceHolder>343\</CodeContentPlaceHolder> will throw an exception, but <CodeContentPlaceHolder>344\</CodeContentPlaceHolder> will not.  
  
> [!NOTE]
>  If you call **Move** while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). For related information, see the ODBC API function **SQLExtendedFetch** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDatabase#28](../vs140/codesnippet/CPP/crecordset-class_14.cpp)]  
  
##  \<a name="crecordset__movefirst">\</a>  CRecordset::MoveFirst  
 Makes the first record in the first rowset the current record.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Remarks  
 Regardless of whether bulk row fetching has been implemented, this will always be the first record in the recordset.  
  
 You do not have to call **MoveFirst** immediately after you open the recordset. At that time, the first record (if any) is automatically the current record.  
  
> [!NOTE]
>  This member function is not valid for forward-only recordsets.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See the [IsDeleted](#crecordset__isdeleted) member function for details.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. To determine whether the recordset has any records, call <CodeContentPlaceHolder>345\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
### Example  
  See the example for [IsBOF](#crecordset__isbof).  
  
##  \<a name="crecordset__movelast">\</a>  CRecordset::MoveLast  
 Makes the first record in the last complete rowset the current record.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Remarks  
 If you have not implemented bulk row fetching, your recordset has a rowset size of 1, so <CodeContentPlaceHolder>347\</CodeContentPlaceHolder> simply moves to the last record in the recordset.  
  
> [!NOTE]
>  This member function is not valid for forward-only recordsets.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See the [IsDeleted](#crecordset__isdeleted) member function for details.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. To determine whether the recordset has any records, call <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
### Example  
  See the example for [IsBOF](#crecordset__isbof).  
  
##  \<a name="crecordset__movenext">\</a>  CRecordset::MoveNext  
 Makes the first record in the next rowset the current record.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 If you have not implemented bulk row fetching, your recordset has a rowset size of 1, so <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> simply moves to the next record.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See the [IsDeleted](#crecordset__isdeleted) member function for details.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. To determine whether the recordset has any records, call <CodeContentPlaceHolder>351\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  It is also recommended that you call <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>. For example, if you have scrolled past the end of the recordset, <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> will return nonzero; a subsequent call to <CodeContentPlaceHolder>356\</CodeContentPlaceHolder> would throw an exception.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
### Example  
  See the example for [IsBOF](#crecordset__isbof).  
  
##  \<a name="crecordset__moveprev">\</a>  CRecordset::MovePrev  
 Makes the first record in the previous rowset the current record.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Remarks  
 If you have not implemented bulk row fetching, your recordset has a rowset size of 1, so <CodeContentPlaceHolder>357\</CodeContentPlaceHolder> simply moves to the previous record.  
  
> [!NOTE]
>  This member function is not valid for forward-only recordsets.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See the [IsDeleted](#crecordset__isdeleted) member function for details.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. To determine whether the recordset has any records, call <CodeContentPlaceHolder>358\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  It is also recommended that you call <CodeContentPlaceHolder>360\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>. For example, if you have scrolled ahead of the beginning of the recordset, <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> will return nonzero; a subsequent call to <CodeContentPlaceHolder>363\</CodeContentPlaceHolder> would throw an exception.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
### Example  
  See the example for [IsBOF](#crecordset__isbof).  
  
##  \<a name="crecordset__onsetoptions">\</a>  CRecordset::OnSetOptions  
 Called to set options (used on selection) for the specified ODBC statement.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 The **HSTMT** of the ODBC statement whose options are to be set.  
  
### Remarks  
 Call <CodeContentPlaceHolder>365\</CodeContentPlaceHolder> to set options (used on selection) for the specified ODBC statement. The framework calls this member function to set initial options for the recordset. <CodeContentPlaceHolder>366\</CodeContentPlaceHolder> determines the data source's support for scrollable cursors and for cursor concurrency and sets the recordset's options accordingly. (Whereas <CodeContentPlaceHolder>367\</CodeContentPlaceHolder> is used for selection operations, <CodeContentPlaceHolder>368\</CodeContentPlaceHolder> is used for update operations.)  
  
 Override <CodeContentPlaceHolder>369\</CodeContentPlaceHolder> to set options specific to the driver or the data source. For example, if your data source supports opening for exclusive access, you might override <CodeContentPlaceHolder>370\</CodeContentPlaceHolder> to take advantage of that ability.  
  
 For more information about cursors, see the article [ODBC](../vs140/odbc-basics.md).  
  
##  \<a name="crecordset__onsetupdateoptions">\</a>  CRecordset::OnSetUpdateOptions  
 Called to set options (used on update) for the specified ODBC statement.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 The **HSTMT** of the ODBC statement whose options are to be set.  
  
### Remarks  
 Call <CodeContentPlaceHolder>372\</CodeContentPlaceHolder> to set options (used on update) for the specified ODBC statement. The framework calls this member function after it creates an HSTMT to update records in a recordset. (Whereas <CodeContentPlaceHolder>373\</CodeContentPlaceHolder> is used for selection operations, <CodeContentPlaceHolder>374\</CodeContentPlaceHolder> is used for update operations.) <CodeContentPlaceHolder>375\</CodeContentPlaceHolder> determines the data source's support for scrollable cursors and for cursor concurrency and sets the recordset's options accordingly.  
  
 Override <CodeContentPlaceHolder>376\</CodeContentPlaceHolder> to set options of an ODBC statement before that statement is used to access a database.  
  
 For more information about cursors, see the article [ODBC](../vs140/odbc-basics.md).  
  
##  \<a name="crecordset__open">\</a>  CRecordset::Open  
 Opens the recordset by retrieving the table or performing the query that the recordset represents.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>  
 Accept the default value, **AFX_DB_USE_DEFAULT_TYPE**, or use one of the following values from the **enum OpenType**:  
  
-   **CRecordset::dynaset** A recordset with bi-directional scrolling. The membership and ordering of the records are determined when the recordset is opened, but changes made by other users to the data values are visible following a fetch operation. Dynasets are also known as keyset-driven recordsets.  
  
-   **CRecordset::snapshot** A static recordset with bi-directional scrolling. The membership and ordering of the records are determined when the recordset is opened; the data values are determined when the records are fetched. Changes made by other users are not visible until the recordset is closed and then reopened.  
  
-   **CRecordset::dynamic** A recordset with bi-directional scrolling. Changes made by other users to the membership, ordering, and data values are visible following a fetch operation. Note that many ODBC drivers do not support this type of recordset.  
  
-   **CRecordset::forwardOnly** A read-only recordset with only forward scrolling.  
  
     For <CodeContentPlaceHolder>378\</CodeContentPlaceHolder>, the default value is **CRecordset::snapshot**. The default-value mechanism allows the Visual C++ wizards to interact with both ODBC <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> and DAO <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>, which have different defaults.  
  
 For more information about these recordset types, see the article [Recordset (ODBC)](../vs140/recordset--odbc-.md). For related information, see the article "Using Block and Scrollable Cursors" in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!CAUTION]
>  If the requested type is not supported, the framework throws an exception.  
  
 <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>  
 A string pointer containing one of the following:  
  
-   A **NULL** pointer.  
  
-   The name of a table.  
  
-   A SQL **SELECT** statement (optionally with a SQL **WHERE** or **ORDER BY** clause).  
  
-   A **CALL** statement specifying the name of a predefined query (stored procedure). Be careful that you do not insert whitespace between the curly brace and the **CALL** keyword.  
  
 For more information about this string, see the table and the discussion of ClassWizard's role under Remarks.  
  
> [!NOTE]
>  The order of the columns in your result set must match the order of the RFX or Bulk RFX function calls in your [DoFieldExchange](#crecordset__dofieldexchange) or [DoBulkFieldExchange](#crecordset__dobulkfieldexchange) function override.  
  
 <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>  
 A bitmask which can specify a combination of the values listed below. Some of these are mutually exclusive. The default value is **none**.  
  
-   **CRecordset::none** No options set. This parameter value is mutually exclusive with all other values. By default, the recordset can be updated with [Edit](#crecordset__edit) or [Delete](#crecordset__delete) and allows appending new records with [AddNew](#crecordset__addnew). Updatability depends on the data source as well as on the <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> option you specify. Optimization for bulk additions is not available. Bulk row fetching will not be implemented. Deleted records will not be skipped during recordset navigation. Bookmarks are not available. Automatic dirty field checking is implemented.  
  
-   **CRecordset::appendOnly** Do not allow **Edit** or **Delete** on the recordset. Allow <CodeContentPlaceHolder>384\</CodeContentPlaceHolder> only. This option is mutually exclusive with **CRecordset::readOnly**.  
  
-   **CRecordset::readOnly** Open the recordset as read-only. This option is mutually exclusive with **CRecordset::appendOnly**.  
  
-   **CRecordset::optimizeBulkAdd** Use a prepared SQL statement to optimize adding many records at one time. Applies only if you are not using the ODBC API function **SQLSetPos** to update the recordset. The first update determines which fields are marked dirty. This option is mutually exclusive with <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>386\</CodeContentPlaceHolder> Implement bulk row fetching to allow multiple rows to be retrieved in a single fetch operation. This is an advanced feature designed to improve performance; however, bulk record field exchange is not supported by ClassWizard. This option is mutually exclusive with **CRecordset::optimizeBulkAdd**. Note that if you specify <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>, then the option **CRecordset::noDirtyFieldCheck** will be turned on automatically (double buffering will not be available); on forward-only recordsets, the option **CRecordset::useExtendedFetch** will be turned on automatically. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
-   **CRecordset::skipDeletedRecords** Skip all deleted records when navigating through the recordset. This will slow performance in certain relative fetches. This option is not valid on forward-only recordsets. If you call [Move](#crecordset__move) with the <CodeContentPlaceHolder>388\</CodeContentPlaceHolder> parameter set to 0, and the **CRecordset::skipDeletedRecords** option set, **Move** will assert. Note that **CRecordset::skipDeletedRecords** is similar to                                         *driver packing*, which means that deleted rows are removed from the recordset. However, if your driver packs records, then it will skip only those records that you delete; it will not skip records deleted by other users while the recordset is open. **CRecordset::skipDeletedRecords** will skip rows deleted by other users.  
  
-   **CRecordset::useBookmarks** May use bookmarks on the recordset, if supported. Bookmarks slow data retrieval but improve performance for data navigation. Not valid on forward-only recordsets. For more information, see the article [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md).  
  
-   **CRecordset::noDirtyFieldCheck** Turn off automatic dirty field checking (double buffering). This will improve performance; however, you must manually mark fields as dirty by calling the <CodeContentPlaceHolder>389\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>390\</CodeContentPlaceHolder> member functions.Note that double buffering in class <CodeContentPlaceHolder>391\</CodeContentPlaceHolder> is similar to double buffering in class <CodeContentPlaceHolder>392\</CodeContentPlaceHolder>. However, in <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>, you cannot enable double buffering on individual fields; you either enable it for all fields or disable it for all fields. Note that if you specify the option <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>, then **CRecordset::noDirtyFieldCheck** will be turned on automatically; however, <CodeContentPlaceHolder>395\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>396\</CodeContentPlaceHolder> cannot be used on recordsets that implement bulk row fetching.  
  
-   **CRecordset::executeDirect** Do not use a prepared SQL statement. For improved performance, specify this option if the **Requery** member function will never be called.  
  
-   **CRecordset::useExtendedFetch** Implement **SQLExtendedFetch** instead of **SQLFetch**. This is designed for implementing bulk row fetching on forward-only recordsets. If you specify the option <CodeContentPlaceHolder>397\</CodeContentPlaceHolder> on a forward-only recordset, then **CRecordset::useExtendedFetch** will be turned on automatically.  
  
-   **CRecordset::userAllocMultiRowBuffers** The user will allocate storage buffers for the data. Use this option in conjunction with <CodeContentPlaceHolder>398\</CodeContentPlaceHolder> if you want to allocate your own storage; otherwise, the framework will automatically allocate the necessary storage. For more information, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). Note that specifying **CRecordset::userAllocMultiRowBuffers** without specifying <CodeContentPlaceHolder>399\</CodeContentPlaceHolder> will result in a failed assertion.  
  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>400\</CodeContentPlaceHolder> object was successfully opened; otherwise 0 if [CDatabase::Open](../vs140/cdatabase-class.md#cdatabase__open) (if called) returns 0.  
  
### Remarks  
 You must call this member function to run the query defined by the recordset. Before calling **Open**, you must construct the recordset object.  
  
 This recordset's connection to the data source depends on how you construct the recordset before calling **Open**. If you pass a [CDatabase](../vs140/cdatabase-class.md) object to the recordset constructor that has not been connected to the data source, this member function uses [GetDefaultConnect](#crecordset__getdefaultconnect) to attempt to open the database object. If you pass **NULL** to the recordset constructor, the constructor constructs a <CodeContentPlaceHolder>401\</CodeContentPlaceHolder> object for you, and **Open** attempts to connect the database object. For details on closing the recordset and the connection under these varying circumstances, see [Close](#crecordset__close).  
  
> [!NOTE]
>  Access to a data source through a <CodeContentPlaceHolder>402\</CodeContentPlaceHolder> object is always shared. Unlike the <CodeContentPlaceHolder>403\</CodeContentPlaceHolder> class, you cannot use a <CodeContentPlaceHolder>404\</CodeContentPlaceHolder> object to open a data source with exclusive access.  
  
 When you call **Open**, a query, usually a SQL **SELECT** statement, selects records based on criteria shown in the following table.  
  
|Value of the lpszSQL parameter|Records selected are determined by|Example|  
|------------------------------------|----------------------------------------|-------------|  
|**NULL**|The string returned by <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>.||  
|SQL table name|All columns of the table-list in <CodeContentPlaceHolder>406\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>.|<CodeContentPlaceHolder>408\</CodeContentPlaceHolder>|  
|Predefined query (stored procedure) name|The columns the query is defined to return.|<CodeContentPlaceHolder>409\</CodeContentPlaceHolder>|  
|**SELECT** column-list **FROM** table-list|The specified columns from the specified table(s).|<CodeContentPlaceHolder>410\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>|  
  
> [!CAUTION]
>  Be careful that you do not insert extra whitespace in your SQL string. For example, if you insert whitespace between the curly brace and the **CALL** keyword, MFC will misinterpret the SQL string as a table name and incorporate it into a **SELECT** statement, which will result in an exception being thrown. Similarly, if your predefined query uses an output parameter, do not insert whitespace between the curly brace and the '?' symbol. Finally, you must not insert whitespace before the curly brace in a **CALL** statement or before the **SELECT** keyword in a **SELECT** statment.  
  
 The usual procedure is to pass **NULL** to **Open**; in this case, **Open** calls [GetDefaultSQL](#crecordset__getdefaultsql). If you are using a derived <CodeContentPlaceHolder>412\</CodeContentPlaceHolder> class, **GetDefaultSQL** gives the table name(s) you specified in ClassWizard. You can instead specify other information in the <CodeContentPlaceHolder>413\</CodeContentPlaceHolder> parameter.  
  
 Whatever you pass, **Open** constructs a final SQL string for the query (the string may have SQL **WHERE** and **ORDER BY** clauses appended to the <CodeContentPlaceHolder>414\</CodeContentPlaceHolder> string you passed) and then executes the query. You can examine the constructed string by calling [GetSQL](#crecordset__getsql) after calling **Open**. For additional details about how the recordset constructs a SQL statement and selects records, see the article [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md).  
  
 The field data members of your recordset class are bound to the columns of the data selected. If any records are returned, the first record becomes the current record.  
  
 If you want to set options for the recordset, such as a filter or sort, specify these after you construct the recordset object but before you call **Open**. If you want to refresh the records in the recordset after the recordset is already open, call [Requery](#crecordset__requery).  
  
 For more information, including additional examples, see the articles [Recordset (ODBC)](../vs140/recordset--odbc-.md), [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md), and [Recordset: Creating and Closing Recordsets (ODBC)](../vs140/recordset--creating-and-closing-recordsets--odbc-.md).  
  
### Example  
 The following code examples show different forms of the **Open** call.  
  
 [!code[NVC_MFCDatabase#16](../vs140/codesnippet/CPP/crecordset-class_15.cpp)]  
  
##  \<a name="crecordset__refreshrowset">\</a>  CRecordset::RefreshRowset  
 Updates the data and the status for a row in the current rowset.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 The one-based position of a row in the current rowset. This value can range from zero to the size of the rowset.  
  
 <CodeContentPlaceHolder>416\</CodeContentPlaceHolder>  
 A value indicating how to lock the row after it has been refreshed. For details, see Remarks.  
  
### Remarks  
 If you pass a value of zero for <CodeContentPlaceHolder>417\</CodeContentPlaceHolder>, then every row in the rowset will be refreshed.  
  
 To use <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>, you must have implemented bulk row fetching by specifying the **CRecordset::useMulitRowFetch** option in the [Open](#crecordset__open) member function.  
  
 <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> calls the ODBC API function **SQLSetPos**. The <CodeContentPlaceHolder>420\</CodeContentPlaceHolder> parameter specifies the lock state of the row after **SQLSetPos** has executed. The following table describes the possible values for <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>e.  
  
|wLockType|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>422\</CodeContentPlaceHolder> (the default value)|The driver or data source ensures that the row is in the same locked or unlocked state as it was before <CodeContentPlaceHolder>423\</CodeContentPlaceHolder> was called.|  
|<CodeContentPlaceHolder>424\</CodeContentPlaceHolder>|The driver or data source locks the row exclusively. Not all data sources support this type of lock.|  
|<CodeContentPlaceHolder>425\</CodeContentPlaceHolder>|The driver or data source unlocks the row. Not all data sources support this type of lock.|  
  
 For more information about **SQLSetPos**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__requery">\</a>  CRecordset::Requery  
 Rebuilds (refreshes) a recordset.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the recordset was successfully rebuilt; otherwise 0.  
  
### Remarks  
 If any records are returned, the first record becomes the current record.  
  
 In order for the recordset to reflect the additions and deletions that you or other users are making to the data source, you must rebuild the recordset by calling **Requery**. If the recordset is a dynaset, it automatically reflects updates that you or other users make to its existing records (but not additions). If the recordset is a snapshot, you must call **Requery** to reflect edits by other users as well as additions and deletions.  
  
 For either a dynaset or a snapshot, call **Requery** any time you want to rebuild the recordset using a new filter or sort, or new parameter values. Set the new filter or sort property by assigning new values to **m_strFilter** and <CodeContentPlaceHolder>426\</CodeContentPlaceHolder> before calling **Requery**. Set new parameters by assigning new values to parameter data members before calling **Requery**. If the filter and sort strings are unchanged, you can reuse the query, which improves performance.  
  
 If the attempt to rebuild the recordset fails, the recordset is closed. Before you call **Requery**, you can determine whether the recordset can be requeried by calling the <CodeContentPlaceHolder>427\</CodeContentPlaceHolder> member function. <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> does not guarantee that **Requery** will succeed.  
  
> [!CAUTION]
>  Call **Requery** only after you have called [Open](#crecordset__open).  
  
### Example  
 This example rebuilds a recordset to apply a different sort order.  
  
 [!code[NVC_MFCDatabase#29](../vs140/codesnippet/CPP/crecordset-class_16.cpp)]  
  
##  \<a name="crecordset__setabsoluteposition">\</a>  CRecordset::SetAbsolutePosition  
 Positions the recordset on the record corresponding to the specified record number.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>429\</CodeContentPlaceHolder>  
 The one-based ordinal position for the current record in the recordset.  
  
### Remarks  
 <CodeContentPlaceHolder>430\</CodeContentPlaceHolder> moves the current record pointer based on this ordinal position.  
  
> [!NOTE]
>  This member function is not valid on forward-only recordsets.  
  
 For ODBC recordsets, an absolute position setting of 1 refers to the first record in the recordset; a setting of 0 refers to the beginning-of-file (BOF) position.  
  
 You can also pass negative values to <CodeContentPlaceHolder>431\</CodeContentPlaceHolder>. In this case the recordset's position is evaluated from the end of the recordset. For example, <CodeContentPlaceHolder>432\</CodeContentPlaceHolder> moves the current record pointer to the last record in the recordset.  
  
> [!NOTE]
>  Absolute position is not intended to be used as a surrogate record number. Bookmarks are still the recommended way of retaining and returning to a given position, since a record's position changes when preceding records are deleted. In addition, you cannot be assured that a given record will have the same absolute position if the recordset is re-created again because the order of individual records within a recordset is not guaranteed unless it is created with a SQL statement using an **ORDER BY** clause.  
  
 For more information about recordset navigation and bookmarks, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md).  
  
##  \<a name="crecordset__setbookmark">\</a>  CRecordset::SetBookmark  
 Positions the recordset on the record containing the specified bookmark.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>433\</CodeContentPlaceHolder>  
 A reference to a [CDBVariant](../vs140/cdbvariant-class.md) object containing the bookmark value for a specific record.  
  
### Remarks  
 To determine if bookmarks are supported on the recordset, call [CanBookmark](#crecordset__canbookmark). To make bookmarks available if they are supported, you must set the **CRecordset::useBookmarks** option in the <CodeContentPlaceHolder>434\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function.  
  
> [!NOTE]
>  If bookmarks are unsupported or unavailable, calling <CodeContentPlaceHolder>435\</CodeContentPlaceHolder> will result in an exception being thrown. Bookmarks are not supported on forward-only recordsets.  
  
 To first retrieve the bookmark for the current record, call [GetBookmark](#crecordset__getbookmark), which saves the bookmark value to a <CodeContentPlaceHolder>436\</CodeContentPlaceHolder> object. Later, you can return to that record by calling <CodeContentPlaceHolder>437\</CodeContentPlaceHolder> using the saved bookmark value.  
  
> [!NOTE]
>  After certain recordset operations, you should check the bookmark persistence before calling <CodeContentPlaceHolder>438\</CodeContentPlaceHolder>. For example, if you retrieve a bookmark with <CodeContentPlaceHolder>439\</CodeContentPlaceHolder> and then call **Requery**, the bookmark may no longer be valid. Call [CDatabase::GetBookmarkPersistence](../vs140/cdatabase-class.md#cdatabase__getbookmarkpersistence) to check whether you can safely call <CodeContentPlaceHolder>440\</CodeContentPlaceHolder>.  
  
 For more information about bookmarks and recordset navigation, see the articles [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md) and [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md).  
  
##  \<a name="crecordset__setfielddirty">\</a>  CRecordset::SetFieldDirty  
 Flags a field data member of the recordset as changed or as unchanged.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>441\</CodeContentPlaceHolder>  
 Contains the address of a field data member in the recordset or **NULL**. If **NULL**, all field data members in the recordset are flagged. (C++ **NULL** is not the same as Null in database terminology, which means "having no value.")  
  
 <CodeContentPlaceHolder>442\</CodeContentPlaceHolder>  
 **TRUE** if the field data member is to be flagged as "dirty" (changed). Otherwise **FALSE** if the field data member is to be flagged as "clean" (unchanged).  
  
### Remarks  
 Marking fields as unchanged ensures the field is not updated and results in less SQL traffic.  
  
> [!NOTE]
>  This member function is not applicable on recordsets that are using bulk row fetching. If you have implemented bulk row fetching, then <CodeContentPlaceHolder>443\</CodeContentPlaceHolder> will result in a failed assertion. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 The framework marks changed field data members to ensure they will be written to the record on the data source by the record field exchange (RFX) mechanism. Changing the value of a field generally sets the field dirty automatically, so you will seldom need to call <CodeContentPlaceHolder>444\</CodeContentPlaceHolder> yourself, but you might sometimes want to ensure that columns will be explicitly updated or inserted regardless of what value is in the field data member.  
  
> [!CAUTION]
>  Call this member function only after you have called [Edit](#crecordset__edit) or [AddNew](#crecordset__addnew).  
  
 Using **NULL** for the first argument of the function will apply the function only to **outputColumn** fields, not **param** fields. For instance, the call  
  
 [!code[NVC_MFCDatabase#26](../vs140/codesnippet/CPP/crecordset-class_10.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
 To work on **param** fields, you must supply the actual address of the individual **param** you want to work on, such as:  
  
 [!code[NVC_MFCDatabase#27](../vs140/codesnippet/CPP/crecordset-class_11.cpp)]  
  
 This means you cannot set all **param** fields to **NULL**, as you can with **outputColumn** fields.  
  
##  \<a name="crecordset__setfieldnull">\</a>  CRecordset::SetFieldNull  
 Flags a field data member of the recordset as Null (specifically having no value) or as non-Null.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>445\</CodeContentPlaceHolder>  
 Contains the address of a field data member in the recordset or **NULL**. If **NULL**, all field data members in the recordset are flagged. (C++ **NULL** is not the same as Null in database terminology, which means "having no value.")  
  
 <CodeContentPlaceHolder>446\</CodeContentPlaceHolder>  
 Nonzero if the field data member is to be flagged as having no value (Null). Otherwise 0 if the field data member is to be flagged as non-Null.  
  
### Remarks  
 When you add a new record to a recordset, all field data members are initially set to a Null value and flagged as "dirty" (changed). When you retrieve a record from a data source, its columns either already have values or are Null.  
  
> [!NOTE]
>  Do not call this member function on recordsets that are using bulk row fetching. If you have implemented bulk row fetching, calling <CodeContentPlaceHolder>447\</CodeContentPlaceHolder> results in a failed assertion. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 If you specifically wish to designate a field of the current record as not having a value, call <CodeContentPlaceHolder>448\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>449\</CodeContentPlaceHolder> set to **TRUE** to flag it as Null. If a field was previously marked Null and you now want to give it a value, simply set its new value. You do not have to remove the Null flag with <CodeContentPlaceHolder>450\</CodeContentPlaceHolder>. To determine whether the field is allowed to be Null, call <CodeContentPlaceHolder>451\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  Call this member function only after you have called [Edit](#crecordset__edit) or [AddNew](#crecordset__addnew).  
  
 Using **NULL** for the first argument of the function will apply the function only to **outputColumn** fields, not **param** fields. For instance, the call  
  
 [!code[NVC_MFCDatabase#26](../vs140/codesnippet/CPP/crecordset-class_10.cpp)]  
  
 will set only **outputColumn** fields to **NULL**; **param** fields will be unaffected.  
  
 To work on **param** fields, you must supply the actual address of the individual **param** you want to work on, such as:  
  
 [!code[NVC_MFCDatabase#27](../vs140/codesnippet/CPP/crecordset-class_11.cpp)]  
  
 This means you cannot set all **param** fields to **NULL**, as you can with **outputColumn** fields.  
  
> [!NOTE]
>  When setting parameters to Null, a call to <CodeContentPlaceHolder>452\</CodeContentPlaceHolder> before the recordset is opened results in an assertion. In this case, call [SetParamNull](#crecordset__setparamnull).  
  
 <CodeContentPlaceHolder>453\</CodeContentPlaceHolder> is implemented through [DoFieldExchange](#crecordset__dofieldexchange).  
  
##  \<a name="crecordset__setlockingmode">\</a>  CRecordset::SetLockingMode  
 Sets the locking mode to "optimistic" locking (the default) or "pessimistic" locking. Determines how records are locked for updates.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>454\</CodeContentPlaceHolder>  
 Contains one of the following values from the **enum LockMode**:  
  
-   **optimistic** Optimistic locking locks the record being updated only during the call to **Update**.  
  
-   **pessimistic** Pessimistic locking locks the record as soon as **Edit** is called and keeps it locked until the **Update** call completes or you move to a new record.  
  
### Remarks  
 Call this member function if you need to specify which of two record-locking strategies the recordset is using for updates. By default, the locking mode of a recordset is **optimistic**. You can change that to a more cautious **pessimistic** locking strategy. Call <CodeContentPlaceHolder>455\</CodeContentPlaceHolder> after you construct and open the recordset object but before you call **Edit**.  
  
##  \<a name="crecordset__setparamnull">\</a>  CRecordset::SetParamNull  
 Flags a parameter as Null (specifically having no value) or as non-Null.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>  
 The zero-based index of the parameter.  
  
 <CodeContentPlaceHolder>457\</CodeContentPlaceHolder>  
 If **TRUE** (the default value), the parameter is flagged as Null. Otherwise, the parameter is flagged as non-Null.  
  
### Remarks  
 Unlike [SetFieldNull](#crecordset__setfieldnull), you can call <CodeContentPlaceHolder>458\</CodeContentPlaceHolder> before you have opened the recordset.  
  
 <CodeContentPlaceHolder>459\</CodeContentPlaceHolder> is typically used with predefined queries (stored procedures).  
  
##  \<a name="crecordset__setrowsetcursorposition">\</a>  CRecordset::SetRowsetCursorPosition  
 Moves the cursor to a row within the current rowset.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>460\</CodeContentPlaceHolder>  
 The one-based position of a row in the current rowset. This value can range from 1 to the size of the rowset.  
  
 <CodeContentPlaceHolder>461\</CodeContentPlaceHolder>  
 Value indicating how to lock the row after it has been refreshed. For details, see Remarks.  
  
### Remarks  
 When implementing bulk row fetching, records are retrieved by rowsets, where the first record in the fetched rowset is the current record. In order to make another record within the rowset the current record, call <CodeContentPlaceHolder>462\</CodeContentPlaceHolder>. For example, you can combine <CodeContentPlaceHolder>463\</CodeContentPlaceHolder> with the [GetFieldValue](#crecordset__getfieldvalue) member function to dynamically retrieve the data from any record of your recordset.  
  
 To use <CodeContentPlaceHolder>464\</CodeContentPlaceHolder>, you must have implemented bulk row fetching by specifying the <CodeContentPlaceHolder>465\</CodeContentPlaceHolder> option of the <CodeContentPlaceHolder>466\</CodeContentPlaceHolder> parameter in the [Open](#crecordset__open) member function.  
  
 <CodeContentPlaceHolder>467\</CodeContentPlaceHolder> calls the ODBC API function **SQLSetPos**. The <CodeContentPlaceHolder>468\</CodeContentPlaceHolder> parameter specifies the lock state of the row after **SQLSetPos** has executed. The following table describes the possible values for <CodeContentPlaceHolder>469\</CodeContentPlaceHolder>e.  
  
|wLockType|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>470\</CodeContentPlaceHolder> (the default value)|The driver or data source ensures that the row is in the same locked or unlocked state as it was before <CodeContentPlaceHolder>471\</CodeContentPlaceHolder> was called.|  
|<CodeContentPlaceHolder>472\</CodeContentPlaceHolder>|The driver or data source locks the row exclusively. Not all data sources support this type of lock.|  
|<CodeContentPlaceHolder>473\</CodeContentPlaceHolder>|The driver or data source unlocks the row. Not all data sources support this type of lock.|  
  
 For more information about **SQLSetPos**, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__setrowsetsize">\</a>  CRecordset::SetRowsetSize  
 Specifies the number of records you wish to retrieve during a fetch.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 *dwNewRowsetSize*  
 The number of rows to retrieve during a given fetch.  
  
### Remarks  
 This virtual member function specifies how many rows you wish to retrieve during a single fetch when using bulk row fetching. To implement bulk row fetching, you must set the <CodeContentPlaceHolder>474\</CodeContentPlaceHolder> option in the <CodeContentPlaceHolder>475\</CodeContentPlaceHolder> parameter of the [Open](#crecordset__open) member function.  
  
> [!NOTE]
>  Calling <CodeContentPlaceHolder>476\</CodeContentPlaceHolder> without implementing bulk row fetching will result in a failed assertion.  
  
 Call <CodeContentPlaceHolder>477\</CodeContentPlaceHolder> before calling **Open** to initially set the rowset size for the recordset. The default rowset size when implementing bulk row fetching is 25.  
  
> [!NOTE]
>  Use caution when calling <CodeContentPlaceHolder>478\</CodeContentPlaceHolder>. If you are manually allocating storage for the data (as specified by the **CRecordset::userAllocMultiRowBuffers** option of the dwOptions parameter in **Open**), you should check whether you need to reallocate these storage buffers after you call <CodeContentPlaceHolder>479\</CodeContentPlaceHolder>, but before you perform any cursor navigation operation.  
  
 To obtain the current setting for the rowset size, call [GetRowsetSize](#crecordset__getrowsetsize).  
  
 For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
##  \<a name="crecordset__update">\</a>  CRecordset::Update  
 Completes an <CodeContentPlaceHolder>480\</CodeContentPlaceHolder> or **Edit** operation by saving the new or edited data on the data source.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if one record was successfully updated; otherwise 0 if no columns have changed. If no records were updated, or if more than one record was updated, an exception is thrown. An exception is also thrown for any other failure on the data source.  
  
### Remarks  
 Call this member function after a call to the [AddNew](#crecordset__addnew) or [Edit](#crecordset__edit) member function. This call is required to complete the <CodeContentPlaceHolder>481\</CodeContentPlaceHolder> or **Edit** operation.  
  
> [!NOTE]
>  If you have implemented bulk row fetching, you cannot call **Update**. This will result in a failed assertion. Although class <CodeContentPlaceHolder>482\</CodeContentPlaceHolder> does not provide a mechanism for updating bulk rows of data, you can write your own functions by using the ODBC API function **SQLSetPos**. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
 Both <CodeContentPlaceHolder>483\</CodeContentPlaceHolder> and **Edit** prepare an edit buffer in which the added or edited data is placed for saving to the data source. **Update** saves the data. Only those fields marked or detected as changed are updated.  
  
 If the data source supports transactions, you can make the **Update** call (and its corresponding <CodeContentPlaceHolder>484\</CodeContentPlaceHolder> or **Edit** call) part of a transaction. For more information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
> [!CAUTION]
>  If you call **Update** without first calling either <CodeContentPlaceHolder>485\</CodeContentPlaceHolder> or **Edit**, **Update** throws a <CodeContentPlaceHolder>486\</CodeContentPlaceHolder>. If you call <CodeContentPlaceHolder>487\</CodeContentPlaceHolder> or **Edit**, you must call **Update** before you call a **Move** operation or before you close either the recordset or the data source connection. Otherwise, your changes are lost without notification.  
  
 For details on handling **Update** failures, see the article [Recordset: How Recordsets Update Records (ODBC)](../vs140/recordset--how-recordsets-update-records--odbc-.md).  
  
### Example  
 See the article [Transaction: Performing a Transaction in a Recordset (ODBC)](../vs140/transaction--performing-a-transaction-in-a-recordset--odbc-.md).  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase](../vs140/cdatabase-class.md)   
 [CRecordView](../vs140/crecordview-class.md)