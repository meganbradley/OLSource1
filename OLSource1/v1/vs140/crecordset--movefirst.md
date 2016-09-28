---
title: "CRecordset::MoveFirst"
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
  - "CRecordset::MoveFirst"
  - "CRecordset.MoveFirst"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveFirst method"
ms.assetid: c10a2106-70d8-45db-8ea0-6aecbd5174aa
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::MoveFirst
Makes the first record in the first rowset the current record.  
  
## Syntax  
  
```  
  
void MoveFirst( );  
  
```  
  
## Remarks  
 Regardless of whether bulk row fetching has been implemented, this will always be the first record in the recordset.  
  
 You do not have to call **MoveFirst** immediately after you open the recordset. At that time, the first record (if any) is automatically the current record.  
  
> [!NOTE]
>  This member function is not valid for forward-only recordsets.  
  
> [!NOTE]
>  When you move through a recordset, you cannot skip deleted records. See the [IsDeleted](../vs140/crecordset--isdeleted.md) member function for details.  
  
> [!CAUTION]
>  Calling any of the **Move** functions throws an exception if the recordset has no records. To determine whether the recordset has any records, call `IsBOF` and `IsEOF`.  
  
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
 [CRecordset::MoveLast](../vs140/crecordset--movelast.md)   
 [CRecordset::MoveNext](../vs140/crecordset--movenext.md)   
 [CRecordset::MovePrev](../vs140/crecordset--moveprev.md)   
 [CRecordset::IsBOF](../vs140/crecordset--isbof.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)