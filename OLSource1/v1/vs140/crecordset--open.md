---
title: "CRecordset::Open"
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
  - "CRecordset.Open"
  - "OpenType"
  - "CRecordset::Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
  - "OpenType"
ms.assetid: fb837c3c-133d-45e9-8f6c-aeb276193081
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::Open
Opens the recordset by retrieving the table or performing the query that the recordset represents.  
  
## Syntax  
  
```  
  
      virtual BOOL Open(   
   UINT nOpenType = AFX_DB_USE_DEFAULT_TYPE,   
   LPCTSTR lpszSQL = NULL,   
   DWORD dwOptions = none    
);  
```  
  
#### Parameters  
 `nOpenType`  
 Accept the default value, **AFX_DB_USE_DEFAULT_TYPE**, or use one of the following values from the **enum OpenType**:  
  
-   **CRecordset::dynaset** A recordset with bi-directional scrolling. The membership and ordering of the records are determined when the recordset is opened, but changes made by other users to the data values are visible following a fetch operation. Dynasets are also known as keyset-driven recordsets.  
  
-   **CRecordset::snapshot** A static recordset with bi-directional scrolling. The membership and ordering of the records are determined when the recordset is opened; the data values are determined when the records are fetched. Changes made by other users are not visible until the recordset is closed and then reopened.  
  
-   **CRecordset::dynamic** A recordset with bi-directional scrolling. Changes made by other users to the membership, ordering, and data values are visible following a fetch operation. Note that many ODBC drivers do not support this type of recordset.  
  
-   **CRecordset::forwardOnly** A read-only recordset with only forward scrolling.  
  
     For `CRecordset`, the default value is **CRecordset::snapshot**. The default-value mechanism allows the Visual C++ wizards to interact with both ODBC `CRecordset` and DAO `CDaoRecordset`, which have different defaults.  
  
 For more information about these recordset types, see the article [Recordset (ODBC)](../vs140/recordset--odbc-.md). For related information, see the article "Using Block and Scrollable Cursors" in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!CAUTION]
>  If the requested type is not supported, the framework throws an exception.  
  
 `lpszSQL`  
 A string pointer containing one of the following:  
  
-   A **NULL** pointer.  
  
-   The name of a table.  
  
-   A SQL **SELECT** statement (optionally with a SQL **WHERE** or **ORDER BY** clause).  
  
-   A **CALL** statement specifying the name of a predefined query (stored procedure). Be careful that you do not insert whitespace between the curly brace and the **CALL** keyword.  
  
 For more information about this string, see the table and the discussion of ClassWizard's role under Remarks.  
  
> [!NOTE]
>  The order of the columns in your result set must match the order of the RFX or Bulk RFX function calls in your [DoFieldExchange](../vs140/crecordset--dofieldexchange.md) or [DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md) function override.  
  
 `dwOptions`  
 A bitmask which can specify a combination of the values listed below. Some of these are mutually exclusive. The default value is **none**.  
  
-   **CRecordset::none** No options set. This parameter value is mutually exclusive with all other values. By default, the recordset can be updated with [Edit](../vs140/crecordset--edit.md) or [Delete](../vs140/crecordset--delete.md) and allows appending new records with [AddNew](../vs140/crecordset--addnew.md). Updatability depends on the data source as well as on the `nOpenType` option you specify. Optimization for bulk additions is not available. Bulk row fetching will not be implemented. Deleted records will not be skipped during recordset navigation. Bookmarks are not available. Automatic dirty field checking is implemented.  
  
-   **CRecordset::appendOnly** Do not allow **Edit** or **Delete** on the recordset. Allow `AddNew` only. This option is mutually exclusive with **CRecordset::readOnly**.  
  
-   **CRecordset::readOnly** Open the recordset as read-only. This option is mutually exclusive with **CRecordset::appendOnly**.  
  
-   **CRecordset::optimizeBulkAdd** Use a prepared SQL statement to optimize adding many records at one time. Applies only if you are not using the ODBC API function **SQLSetPos** to update the recordset. The first update determines which fields are marked dirty. This option is mutually exclusive with `CRecordset::useMultiRowFetch`.  
  
-   `CRecordset::useMultiRowFetch` Implement bulk row fetching to allow multiple rows to be retrieved in a single fetch operation. This is an advanced feature designed to improve performance; however, bulk record field exchange is not supported by ClassWizard. This option is mutually exclusive with **CRecordset::optimizeBulkAdd**. Note that if you specify `CRecordset::useMultiRowFetch`, then the option **CRecordset::noDirtyFieldCheck** will be turned on automatically (double buffering will not be available); on forward-only recordsets, the option **CRecordset::useExtendedFetch** will be turned on automatically. For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
-   **CRecordset::skipDeletedRecords** Skip all deleted records when navigating through the recordset. This will slow performance in certain relative fetches. This option is not valid on forward-only recordsets. If you call [Move](../vs140/crecordset--move.md) with the `nRows` parameter set to 0, and the **CRecordset::skipDeletedRecords** option set, **Move** will assert. Note that **CRecordset::skipDeletedRecords** is similar to *driver packing*, which means that deleted rows are removed from the recordset. However, if your driver packs records, then it will skip only those records that you delete; it will not skip records deleted by other users while the recordset is open. **CRecordset::skipDeletedRecords** will skip rows deleted by other users.  
  
-   **CRecordset::useBookmarks** May use bookmarks on the recordset, if supported. Bookmarks slow data retrieval but improve performance for data navigation. Not valid on forward-only recordsets. For more information, see the article [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md).  
  
-   **CRecordset::noDirtyFieldCheck** Turn off automatic dirty field checking (double buffering). This will improve performance; however, you must manually mark fields as dirty by calling the `SetFieldDirty` and `SetFieldNull` member functions.Note that double buffering in class `CRecordset` is similar to double buffering in class `CDaoRecordset`. However, in `CRecordset`, you cannot enable double buffering on individual fields; you either enable it for all fields or disable it for all fields. Note that if you specify the option `CRecordset::useMultiRowFetch`, then **CRecordset::noDirtyFieldCheck** will be turned on automatically; however, `SetFieldDirty` and `SetFieldNull` cannot be used on recordsets that implement bulk row fetching.  
  
-   **CRecordset::executeDirect** Do not use a prepared SQL statement. For improved performance, specify this option if the **Requery** member function will never be called.  
  
-   **CRecordset::useExtendedFetch** Implement **SQLExtendedFetch** instead of **SQLFetch**. This is designed for implementing bulk row fetching on forward-only recordsets. If you specify the option `CRecordset::useMultiRowFetch` on a forward-only recordset, then **CRecordset::useExtendedFetch** will be turned on automatically.  
  
-   **CRecordset::userAllocMultiRowBuffers** The user will allocate storage buffers for the data. Use this option in conjunction with `CRecordset::useMultiRowFetch` if you want to allocate your own storage; otherwise, the framework will automatically allocate the necessary storage. For more information, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). Note that specifying **CRecordset::userAllocMultiRowBuffers** without specifying `CRecordset::useMultiRowFetch` will result in a failed assertion.  
  
## Return Value  
 Nonzero if the `CRecordset` object was successfully opened; otherwise 0 if [CDatabase::Open](../vs140/cdatabase--open.md) (if called) returns 0.  
  
## Remarks  
 You must call this member function to run the query defined by the recordset. Before calling **Open**, you must construct the recordset object.  
  
 This recordset's connection to the data source depends on how you construct the recordset before calling **Open**. If you pass a [CDatabase](../vs140/cdatabase-class.md) object to the recordset constructor that has not been connected to the data source, this member function uses [GetDefaultConnect](../vs140/crecordset--getdefaultconnect.md) to attempt to open the database object. If you pass **NULL** to the recordset constructor, the constructor constructs a `CDatabase` object for you, and **Open** attempts to connect the database object. For details on closing the recordset and the connection under these varying circumstances, see [Close](../vs140/crecordset--close.md).  
  
> [!NOTE]
>  Access to a data source through a `CRecordset` object is always shared. Unlike the `CDaoRecordset` class, you cannot use a `CRecordset` object to open a data source with exclusive access.  
  
 When you call **Open**, a query, usually a SQL **SELECT** statement, selects records based on criteria shown in the following table.  
  
|Value of the lpszSQL parameter|Records selected are determined by|Example|  
|------------------------------------|----------------------------------------|-------------|  
|**NULL**|The string returned by `GetDefaultSQL`.||  
|SQL table name|All columns of the table-list in `DoFieldExchange` or `DoBulkFieldExchange`.|`"Customer"`|  
|Predefined query (stored procedure) name|The columns the query is defined to return.|`"{call OverDueAccts}"`|  
|**SELECT** column-list **FROM** table-list|The specified columns from the specified table(s).|`"SELECT CustId, CustName FROM`<br /><br /> `Customer"`|  
  
> [!CAUTION]
>  Be careful that you do not insert extra whitespace in your SQL string. For example, if you insert whitespace between the curly brace and the **CALL** keyword, MFC will misinterpret the SQL string as a table name and incorporate it into a **SELECT** statement, which will result in an exception being thrown. Similarly, if your predefined query uses an output parameter, do not insert whitespace between the curly brace and the '?' symbol. Finally, you must not insert whitespace before the curly brace in a **CALL** statement or before the **SELECT** keyword in a **SELECT** statment.  
  
 The usual procedure is to pass **NULL** to **Open**; in this case, **Open** calls [GetDefaultSQL](../vs140/crecordset--getdefaultsql.md). If you are using a derived `CRecordset` class, **GetDefaultSQL** gives the table name(s) you specified in ClassWizard. You can instead specify other information in the `lpszSQL` parameter.  
  
 Whatever you pass, **Open** constructs a final SQL string for the query (the string may have SQL **WHERE** and **ORDER BY** clauses appended to the `lpszSQL` string you passed) and then executes the query. You can examine the constructed string by calling [GetSQL](../vs140/crecordset--getsql.md) after calling **Open**. For additional details about how the recordset constructs a SQL statement and selects records, see the article [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md).  
  
 The field data members of your recordset class are bound to the columns of the data selected. If any records are returned, the first record becomes the current record.  
  
 If you want to set options for the recordset, such as a filter or sort, specify these after you construct the recordset object but before you call **Open**. If you want to refresh the records in the recordset after the recordset is already open, call [Requery](../vs140/crecordset--requery.md).  
  
 For more information, including additional examples, see the articles [Recordset (ODBC)](../vs140/recordset--odbc-.md), [Recordset: How Recordsets Select Records (ODBC)](../vs140/recordset--how-recordsets-select-records--odbc-.md), and [Recordset: Creating and Closing Recordsets (ODBC)](../vs140/recordset--creating-and-closing-recordsets--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and `CMemoryException*`.  
  
## Example  
 The following code examples show different forms of the **Open** call.  
  
 [!code[NVC_MFCDatabase#16](../vs140/codesnippet/CPP/crecordset--open_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::CRecordset](../vs140/crecordset--crecordset.md)   
 [CRecordset::Close](../vs140/crecordset--close.md)   
 [CRecordset::GetDefaultSQL](../vs140/crecordset--getdefaultsql.md)   
 [CRecordset::GetSQL](../vs140/crecordset--getsql.md)   
 [CRecordset::m_strFilter](../vs140/crecordset--m_strfilter.md)   
 [CRecordset::m_strSort](../vs140/crecordset--m_strsort.md)   
 [CRecordset::Requery](../vs140/crecordset--requery.md)