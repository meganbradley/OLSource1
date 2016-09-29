---
title: "CDaoRecordset::FindFirst"
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
  - "CDaoRecordset.FindFirst"
  - "CDaoRecordset::FindFirst"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, finding data"
  - "recordsets, finding records"
  - "DAO recordsets, finding records"
  - "FindFirst method"
ms.assetid: 8fe8b89d-aab4-4965-8155-d2df5e0398a7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::FindFirst
Call this member function to find the first record that matches a specified condition.  
  
## Syntax  
  
```  
  
      BOOL FindFirst(  
   LPCTSTR lpszFilter   
);  
```  
  
#### Parameters  
 `lpszFilter`  
 A string expression (like the **WHERE** clause in a SQL statement without the word **WHERE**) used to locate the record.  
  
## Return Value  
 Nonzero if matching records are found, otherwise 0.  
  
## Remarks  
 The `FindFirst` member function begins its search from the beginning of the recordset and searches to the end of the recordset.  
  
 If you want to include all the records in your search (not just those that meet a specific condition) use one of the Move operations to move from record to record. To locate a record in a table-type recordset, call the `Seek` member function.  
  
 If a record matching the criteria is not located, the current record pointer is undetermined, and `FindFirst` returns zero. If the recordset contains more than one record that satisfies the criteria, `FindFirst` locates the first occurrence, `FindNext` locates the next occurrence, and so on.  
  
> [!CAUTION]
>  If you edit the current record, be sure to save the changes by calling the **Update** member function before you move to another record. If you move to another record without updating, your changes are lost without warning.  
  
 The **Find** member functions search from the location and in the direction specified in the following table:  
  
|Find operations|Begin|Search direction|  
|---------------------|-----------|----------------------|  
|`FindFirst`|Beginning of recordset|End of recordset|  
|`FindLast`|End of recordset|Beginning of recordset|  
|`FindNext`|Current record|End of recordset|  
|**FindPrevious**|Current record|Beginning of recordset|  
  
> [!NOTE]
>  When you call `FindLast`, the Microsoft Jet database engine fully populates your recordset before beginning the search, if this has not already been done. The first search may take longer than subsequent searches.  
  
 Using one of the Find operations is not the same as calling **MoveFirst** or `MoveNext`, however, which simply makes the first or next record current without specifying a condition. You can follow a Find operation with a Move operation.  
  
 Keep the following in mind when using the Find operations:  
  
-   If **Find** returns nonzero, the current record is not defined. In this case, you must position the current record pointer back to a valid record.  
  
-   You cannot use a Find operation with a forward-only scrolling snapshot-type recordset.  
  
-   You should use the U.S. date format (month-day-year) when you search for fields containing dates, even if you are not using the U.S. version of the Microsoft Jet database engine; otherwise, matching records may not be found.  
  
-   When working with ODBC databases and large dynasets, you may discover that using the Find operations is slow, especially when working with large recordsets. You can improve performance by using SQL queries with customized **ORDER BY** or **WHERE** clauses, parameter queries, or **CDaoQuerydef** objects that retrieve specific indexed records.  
  
 For related information, see the topic "FindFirst, FindLast, FindNext, FindPrevious Methods" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::Find](../vs140/cdaorecordset--find.md)   
 [CDaoRecordset::FindLast](../vs140/cdaorecordset--findlast.md)   
 [CDaoRecordset::FindNext](../vs140/cdaorecordset--findnext.md)   
 [CDaoRecordset::FindPrev](../vs140/cdaorecordset--findprev.md)