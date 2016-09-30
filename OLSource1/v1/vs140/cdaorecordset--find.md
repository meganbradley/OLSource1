---
title: "CDaoRecordset::Find"
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
  - "CDaoRecordset.Find"
  - "CDaoRecordset::Find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, finding data"
  - "recordsets, finding records"
  - "DAO recordsets, finding records"
  - "DAO recordsets"
  - "Find method"
ms.assetid: b2ad1564-7958-453a-98ce-43eb9c5f2eb2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::Find
Call this member function to locate a particular string in a dynaset- or snapshot-type recordset using a comparison operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lFindType*  
 A value indicating the type of Find operation desired. The possible values are:  
  
-   **AFX_DAO_NEXT** Find the next location of a matching string.  
  
-   **AFX_DAO_PREV** Find the previous location of a matching string.  
  
-   **AFX_DAO_FIRST** Find the first location of a matching string.  
  
-   **AFX_DAO_LAST** Find the last location of a matching string.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string expression (like the **WHERE** clause in a SQL statement without the word **WHERE**) used to locate the record. For example:  
  
 [!code[NVC_MFCDatabase#3](../vs140/codesnippet/CPP/cdaorecordset--find_1.cpp)]  
  
## Return Value  
 Nonzero if matching records are found, otherwise 0.  
  
## Remarks  
 You can find the first, next, previous, or last instance of the string. **Find** is a virtual function, so you can override it and add your own implementation. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member functions call the **Find** member function, so you can use **Find** to control the behavior of all Find operations.  
  
 To locate a record in a table-type recordset, call the [Seek](../vs140/cdaorecordset--seek.md) member function.  
  
> [!TIP]
>  The smaller the set of records you have, the more effective **Find** will be. In general, and especially with ODBC data, it is better to create a new query that retrieves just the records you want.  
  
 For related information, see the topic "FindFirst, FindLast, FindNext, FindPrevious Methods" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::FindFirst](../vs140/cdaorecordset--findfirst.md)   
 [CDaoRecordset::FindLast](../vs140/cdaorecordset--findlast.md)   
 [CDaoRecordset::FindNext](../vs140/cdaorecordset--findnext.md)   
 [CDaoRecordset::FindPrev](../vs140/cdaorecordset--findprev.md)