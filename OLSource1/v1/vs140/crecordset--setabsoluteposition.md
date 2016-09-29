---
title: "CRecordset::SetAbsolutePosition"
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
  - "CRecordset::SetAbsolutePosition"
  - "CRecordset.SetAbsolutePosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAbsolutePosition method, recordsets"
  - "recordsets, navigating"
  - "absolute positions"
ms.assetid: 6bd953cb-78af-4e8f-81cb-cdb73368aff5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::SetAbsolutePosition
Positions the recordset on the record corresponding to the specified record number.  
  
## Syntax  
  
```  
  
      void SetAbsolutePosition(   
   long nRows    
);  
```  
  
#### Parameters  
 `nRows`  
 The one-based ordinal position for the current record in the recordset.  
  
## Remarks  
 `SetAbsolutePosition` moves the current record pointer based on this ordinal position.  
  
> [!NOTE]
>  This member function is not valid on forward-only recordsets.  
  
 For ODBC recordsets, an absolute position setting of 1 refers to the first record in the recordset; a setting of 0 refers to the beginning-of-file (BOF) position.  
  
 You can also pass negative values to `SetAbsolutePosition`. In this case the recordset's position is evaluated from the end of the recordset. For example, `SetAbsolutePosition( -1 )` moves the current record pointer to the last record in the recordset.  
  
> [!NOTE]
>  Absolute position is not intended to be used as a surrogate record number. Bookmarks are still the recommended way of retaining and returning to a given position, since a record's position changes when preceding records are deleted. In addition, you cannot be assured that a given record will have the same absolute position if the recordset is re-created again because the order of individual records within a recordset is not guaranteed unless it is created with a SQL statement using an **ORDER BY** clause.  
  
 For more information about recordset navigation and bookmarks, see the articles [Recordset: Scrolling (ODBC)](../vs140/recordset--scrolling--odbc-.md) and [Recordset: Bookmarks and Absolute Positions (ODBC)](../vs140/recordset--bookmarks-and-absolute-positions--odbc-.md).  
  
## Exceptions  
 This method can throw exceptions of type **CDBException\*** and `CMemoryException*`.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::SetBookmark](../vs140/crecordset--setbookmark.md)