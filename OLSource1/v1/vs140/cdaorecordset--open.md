---
title: "CDaoRecordset::Open"
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
  - "CDaoRecordset::Open"
  - "CDaoRecordset.Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, opening"
  - "CDaoRecordset class, opening"
  - "Open method"
ms.assetid: e2163c6b-08e0-43cd-b06f-bbff8ed2c14f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::Open
You must call this member function to retrieve the records for the recordset.  
  
## Syntax  
  
```  
  
      virtual void Open(  
   int nOpenType = AFX_DAO_USE_DEFAULT_TYPE,  
   LPCTSTR lpszSQL = NULL,  
   int nOptions = 0   
);  
virtual void Open(  
   CDaoTableDef* pTableDef,  
   int nOpenType = dbOpenTable,  
   int nOptions = 0   
);  
virtual void Open(  
   CDaoQueryDef* pQueryDef,  
   int nOpenType = dbOpenDynaset,  
   int nOptions = 0   
);  
```  
  
#### Parameters  
 `nOpenType`  
 One of the following values:  
  
-   **dbOpenDynaset** A dynaset-type recordset with bidirectional scrolling. This is the default.  
  
-   **dbOpenTable** A table-type recordset with bidirectional scrolling.  
  
-   **dbOpenSnapshot** A snapshot-type recordset with bidirectional scrolling.  
  
 `lpszSQL`  
 A string pointer containing one of the following:  
  
-   A **NULL** pointer.  
  
-   The name of one or more tabledefs and/or querydefs (comma-separated).  
  
-   A SQL **SELECT** statement (optionally with a SQL **WHERE** or **ORDER BY** clause).  
  
-   A pass-through query.  
  
 `nOptions`  
 One or more of the options listed below. The default value is 0. Possible values are as follows:  
  
-   **dbAppendOnly** You can only append new records (dynaset-type recordset only). This option means literally that records may only be appended. The MFC ODBC database classes have an append-only option that allows records to be retrieved and appended.  
  
-   **dbForwardOnly** The recordset is a forward-only scrolling snapshot.  
  
-   **dbSeeChanges** Generate an exception if another user is changing data you are editing.  
  
-   **dbDenyWrite** Other users cannot modify or add records.  
  
-   **dbDenyRead** Other users cannot view records (table-type recordset only).  
  
-   **dbReadOnly** You can only view records; other users can modify them.  
  
-   **dbInconsistent** Inconsistent updates are allowed (dynaset-type recordset only).  
  
-   **dbConsistent** Only consistent updates are allowed (dynaset-type recordset only).  
  
> [!NOTE]
>  The constants **dbConsistent** and **dbInconsistent** are mutually exclusive. You can use one or the other, but not both in a given instance of **Open**.  
  
 *pTableDef*  
 A pointer to a [CDaoTableDef](../vs140/cdaotabledef-class.md) object. This version is valid only for table-type recordsets. When using this option, the `CDaoDatabase` pointer used to construct the `CDaoRecordset` is not used; rather, the database in which the tabledef resides is used.  
  
 *pQueryDef*  
 A pointer to a [CDaoQueryDef](../vs140/cdaoquerydef-class.md) object. This version is valid only for dynaset-type and snapshot-type recordsets. When using this option, the `CDaoDatabase` pointer used to construct the `CDaoRecordset` is not used; rather, the database in which the querydef resides is used.  
  
## Remarks  
 Before calling **Open**, you must construct the recordset object. There are several ways to do this:  
  
-   When you construct the recordset object, pass a pointer to a `CDaoDatabase` object that is already open.  
  
-   When you construct the recordset object, pass a pointer to a `CDaoDatabase` object that is not open. The recordset opens a `CDaoDatabase` object, but will not close it when the recordset object closes.  
  
-   When you construct the recordset object, pass a **NULL** pointer. The recordset object calls `GetDefaultDBName` to get the name of the Microsoft Access .MDB file to open. The recordset then opens a `CDaoDatabase` object and keeps it open as long as the recordset is open. When you call **Close** on the recordset, the `CDaoDatabase` object is also closed.  
  
    > [!NOTE]
    >  When the recordset opens the `CDaoDatabase` object, it opens the data source with nonexclusive access.  
  
 For the version of **Open** that uses the `lpszSQL` parameter, once the recordset is open you can retrieve records in one of several ways. The first option is to have DFX functions in your `DoFieldExchange`. The second option is to use dynamic binding by calling the `GetFieldValue` member function. These options can be implemented separately or in combination. If they are combined, you will have to pass in the SQL statement yourself on the call to **Open**.  
  
 When you use the second version of **Open** where you pass in a `CDaoTableDef` object, the resulting columns will be available for you to bind via `DoFieldExchange` and the DFX mechanism, and/or bind dynamically via `GetFieldValue`.  
  
> [!NOTE]
>  You can only call **Open** using a `CDaoTableDef` object for table-type recordsets.  
  
 When you use the third version of **Open** where you pass in a `CDaoQueryDef` object, that query will be executed, and the resulting columns will be available for you to bind via `DoFieldExchange` and the DFX mechanism, and/or bind dynamically via `GetFieldValue`.  
  
> [!NOTE]
>  You can only call **Open** using a `CDaoQueryDef` object for dynaset-type and snapshot-type recordsets.  
  
 For the first version of **Open** that uses the `lpszSQL` parameter, records are selected based on criteria shown in the following table.  
  
|Value of the `lpszSQL` parameter|Records selected are determined by|Example|  
|--------------------------------------|----------------------------------------|-------------|  
|**NULL**|The string returned by `GetDefaultSQL`.||  
|A comma-separated list of one or more tabledefs and/or querydef names.|All columns represented in the `DoFieldExchange`.|`"Customer"`|  
|**SELECT** column-list **FROM** table-list|The specified columns from the specified tabledef(s) and/or querydef(s).|`"SELECT CustId, CustName`<br /><br /> `FROM Customer"`|  
  
 The usual procedure is to pass **NULL** to **Open**; in that case, **Open** calls `GetDefaultSQL`, an overridable member function that ClassWizard generates when creating a `CDaoRecordset`-derived class. This value gives the tabledef(s) and/or querydef name(s) you specified in ClassWizard. You can instead specify other information in the `lpszSQL` parameter.  
  
 Whatever you pass, **Open** constructs a final SQL string for the query (the string may have SQL **WHERE** and **ORDER BY** clauses appended to the `lpszSQL` string you passed) and then executes the query. You can examine the constructed string by calling `GetSQL` after calling **Open**.  
  
 The field data members of your recordset class are bound to the columns of the data selected. If any records are returned, the first record becomes the current record.  
  
 If you want to set options for the recordset, such as a filter or sort, set `m_strSort` or **m_strFilter** after you construct the recordset object but before you call **Open**. If you want to refresh the records in the recordset after the recordset is already open, call **Requery**.  
  
 If you call **Open** on a dynaset-type or snapshot-type recordset, or if the data source refers to a SQL statement or a tabledef that represents an attached table, you cannot use **dbOpenTable** for the type argument; if you do, MFC throws an exception. To determine whether a tabledef object represents an attached table, create a [CDaoTableDef](../vs140/cdaotabledef-class.md) object and call its [GetConnect](../vs140/cdaotabledef--getconnect.md) member function.  
  
 Use the **dbSeeChanges** flag if you wish to trap changes made by another user or another program on your machine when you are editing or deleting the same record. For example, if two users start editing the same record, the first user to call the **Update** member function succeeds. When **Update** is called by the second user, a `CDaoException` is thrown. Similarly, if the second user tries to call **Delete** to delete the record, and it has already been changed by the first user, a `CDaoException` occurs.  
  
 Typically, if the user gets this `CDaoException` while updating, your code should refresh the contents of the fields and retrieve the newly modified values. If the exception occurs in the process of deleting, your code could display the new record data to the user and a message indicating that the data has recently changed. At this point, your code can request a confirmation that the user still wants to delete the record.  
  
> [!TIP]
>  Use the forward-only scrolling option (**dbForwardOnly**) to improve performance when your application makes a single pass through a recordset opened from an ODBC data source.  
  
 For related information, see the topic "OpenRecordset Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Close](../vs140/cdaorecordset--close.md)   
 [CDaoRecordset::CDaoRecordset](../vs140/cdaorecordset--cdaorecordset.md)