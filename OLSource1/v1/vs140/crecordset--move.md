---
title: "CRecordset::Move"
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
  - "CRecordset::Move"
  - "SQL_FETCH_RELATIVE"
  - "SQL_FETCH_BOOKMARK"
  - "SQL_FETCH_NEXT"
  - "SQL_FETCH_LAST"
  - "CRecordset.Move"
  - "SQL_FETCH_FIRST"
  - "SQL_FETCH_PRIOR"
  - "SQL_FETCH_ABSOLUTE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SQL_FETCH_RELATIVE"
  - "SQL_FETCH_PRIOR"
  - "SQL_FETCH_NEXT"
  - "SQL_FETCH_FIRST"
  - "SQL_FETCH_BOOKMARK"
  - "Move method (recordsets)"
  - "SQL_FETCH_ABSOLUTE"
  - "SQL_FETCH_LAST"
ms.assetid: 2823a210-69f6-4f0a-a0fa-c2d5a98f0860
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::Move
Moves the current record pointer within the recordset, either forward or backward.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of rows to move forward or backward. Positive values move forward, toward the end of the recordset. Negative values move backward, toward the beginning.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Determines the rowset that **Move** will fetch. For details, see Remarks.  
  
## Remarks  
 If you pass a value of 0 for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, **Move** refreshes the current record; **Move** will end any current <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or **Edit** mode, and will restore the current record's value before <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or **Edit** was called.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See [CRecordset::IsDeleted](../vs140/crecordset--isdeleted.md) for more information. When you open a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the **skipDeletedRecords** option set, **Move** asserts if the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter is 0. This behavior prevents the refresh of rows that are deleted by other client applications using the same data. See the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter in [Open](../vs140/crecordset--open.md) for a description of **skipDeletedRecords**.  
  
 **Move** repositions the recordset by rowsets. Based on the values for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, **Move** fetches the appropriate rowset and then makes the first record in that rowset the current record. If you have not implemented bulk row fetching, then the rowset size is always 1. When fetching a rowset, **Move** directly calls the [CheckRowsetError](../vs140/crecordset--checkrowseterror.md) member function to handle any errors resulting from the fetch.  
  
 Depending on the values you pass, **Move** is equivalent to other <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member functions. In particular, the value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> may indicate a member function that is more intuitive and often the preferred method for moving the current record.  
  
 The following table lists the possible values for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the rowset that **Move** will fetch based on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and any equivalent member function corresponding to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
|wFetchType|Fetched rowset|Equivalent member function|  
|----------------|--------------------|--------------------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (the default value)|The rowset starting <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> row(s) from the first row in the current rowset.||  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The next rowset; <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is ignored.|[MoveNext](../vs140/crecordset--movenext.md)|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The previous rowset; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is ignored.|[MovePrev](../vs140/crecordset--moveprev.md)|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The first rowset in the recordset; <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is ignored.|[MoveFirst](../vs140/crecordset--movefirst.md)|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The last complete rowset in the recordset; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is ignored.|[MoveLast](../vs140/crecordset--movelast.md)|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> > 0, the rowset starting <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> row(s) from the beginning of the recordset. If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> < 0, the rowset starting <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> row(s) from the end of the recordset. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> = 0, then a beginning-of-file (BOF) condition is returned.|[SetAbsolutePosition](../vs140/crecordset--setabsoluteposition.md)|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|The rowset starting at the row whose bookmark value corresponds to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|[SetBookmark](../vs140/crecordset--setbookmark.md)|  
  
> [!NOTE]
>  For foward-only recordsets, **Move** is only valid with a value of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
> [!CAUTION]
>  Calling **Move** throws an exception if the recordset has no records. To determine whether the recordset has any records, call [IsBOF](../vs140/crecordset--isbof.md) and [IsEOF](../vs140/crecordset--iseof.md).  
  
> [!NOTE]
>  If you have scrolled past the beginning or end of the recordset (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> returns nonzero), calling a **Move** function will possibly throw a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For example, if <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> returns nonzero and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> does not, then <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> will throw an exception, but <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> will not.  
  
> [!NOTE]
>  If you call **Move** while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md). For related information, see the ODBC API function **SQLExtendedFetch** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCDatabase#28](../vs140/codesnippet/CPP/crecordset--move_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::MoveNext](../vs140/crecordset--movenext.md)   
 [CRecordset::MovePrev](../vs140/crecordset--moveprev.md)   
 [CRecordset::MoveFirst](../vs140/crecordset--movefirst.md)   
 [CRecordset::MoveLast](../vs140/crecordset--movelast.md)   
 [CRecordset::SetAbsolutePosition](../vs140/crecordset--setabsoluteposition.md)   
 [CRecordset::SetBookmark](../vs140/crecordset--setbookmark.md)   
 [CRecordset::IsBOF](../vs140/crecordset--isbof.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)   
 [CRecordset::CheckRowsetError](../vs140/crecordset--checkrowseterror.md)