---
title: "CDaoRecordset::GetRecordCount"
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
  - "CDaoRecordset::GetRecordCount"
  - "CDaoRecordset.GetRecordCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting information"
  - "CDaoRecordset class, getting record counts"
  - "GetRecordCount method"
ms.assetid: 60b8aea9-1a47-4a83-af61-514c075ae25d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetRecordCount
Call this member function to find out how many records in a recordset have been accessed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the number of records accessed in a recordset object.  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does not indicate how many records are contained in a dynaset-type or snapshot-type recordset until all records have been accessed. This member function call may take a significant amount of time to complete.  
  
 Once the last record has been accessed, the return value indicates the total number of undeleted records in the recordset. To force the last record to be accessed, call the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function for the recordset. You can also use a SQL Count to determine the approximate number of records your query will return.  
  
 As your application deletes records in a dynaset-type recordset, the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> decreases. However, records deleted by other users are not reflected by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> until the current record is positioned to a deleted record. If you execute a transaction that affects the record count and subsequently roll back the transaction, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will not reflect the actual number of remaining records.  
  
 The value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> from a snapshot-type recordset is not affected by changes in the underlying tables.  
  
 The value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> from a table-type recordset reflects the approximate number of records in the table and is affected immediately as table records are added and deleted.  
  
 A recordset with no records returns a value of 0. When working with attached tables or ODBC databases, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> always returns – 1. Calling the **Requery** member function on a recordset resets the value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> just as if the query were re-executed.  
  
 For related information, see the topic "RecordCount Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetFieldCount](../vs140/cdaorecordset--getfieldcount.md)   
 [CDaoRecordset::GetFieldInfo](../vs140/cdaorecordset--getfieldinfo.md)   
 [CDaoRecordset::GetIndexCount](../vs140/cdaorecordset--getindexcount.md)   
 [CDaoRecordset::GetIndexInfo](../vs140/cdaorecordset--getindexinfo.md)