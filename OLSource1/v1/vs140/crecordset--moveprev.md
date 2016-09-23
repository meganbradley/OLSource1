---
title: "CRecordset::MovePrev"
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
  - MovePrev
  - CRecordset.MovePrev
  - CRecordset::MovePrev
dev_langs: 
  - C++
helpviewer_keywords: 
  - MovePrev method
ms.assetid: eb871a03-706a-4306-a73c-13f4cacb799c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::MovePrev
Makes the first record in the previous rowset the current record.  
  
## Syntax  
  
```  
  
void MovePrev( );  
  
```  
  
## Remarks  
 If you have not implemented bulk row fetching, your recordset has a rowset size of 1, so `MovePrev` simply moves to the previous record.  
  
> [!NOTE]
>  This member function is not valid for forward-only recordsets.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See the [IsDeleted](../vs140/crecordset--isdeleted.md) member function for details.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. To determine whether the recordset has any records, call `IsBOF` and `IsEOF`.  
  
> [!NOTE]
>  It is also recommended that you call `IsBOF` before calling `MovePrev`. For example, if you have scrolled ahead of the beginning of the recordset, `IsBOF` will return nonzero; a subsequent call to `MovePrev` would throw an exception.  
  
> [!NOTE]
>  If you call any of the **Move** functions while the current record is being updated or added, the updates are lost without warning.  
  
 For more information about recordset navigation, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md). For more information about bulk row fetching, see the article [Recordset: Fetching Records in Bulk (ODBC)](../vs140/recordset--fetching-records-in-bulk--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and `CMemoryException*`.  
  
## Example  
 See the example for [IsBOF](../vs140/crecordset--isbof.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Move](../vs140/crecordset--move.md)   
 [CRecordset::MoveNext](../vs140/crecordset--movenext.md)   
 [CRecordset::MoveFirst](../vs140/crecordset--movefirst.md)   
 [CRecordset::MoveLast](../vs140/crecordset--movelast.md)   
 [CRecordset::IsBOF](../vs140/crecordset--isbof.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)