---
title: "CDaoRecordset::SetPercentPosition"
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
  - CDaoRecordset.SetPercentPosition
  - CDaoRecordset::SetPercentPosition
  - SetPercentPosition
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDaoRecordset class, setting percent position
  - recordsets, setting position
  - SetPercentPosition method
ms.assetid: ea0834ad-5b85-49ee-b1b3-643451773a7e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::SetPercentPosition
Call this member function to set a value that changes the approximate location of the current record in the recordset object based on a percentage of the records in the recordset.  
  
## Syntax  
  
```  
  
      void SetPercentPosition(  
   float fPosition   
);  
```  
  
#### Parameters  
 *fPosition*  
 A number between 0 and 100.  
  
## Remarks  
 When working with a dynaset-type or snapshot-type recordset, first populate the recordset by moving to the last record before you call `SetPercentPosition`. If you call `SetPercentPosition` before fully populating the recordset, the amount of movement is relative to the number of records accessed as indicated by the value of [GetRecordCount](../vs140/cdaorecordset--getrecordcount.md). You can move to the last record by calling `MoveLast`.  
  
 Once you call `SetPercentPosition`, the record at the approximate position corresponding to that value becomes current.  
  
> [!NOTE]
>  Calling `SetPercentPosition` to move the current record to a specific record in a recordset is not recommended. Call the [SetBookmark](../vs140/cdaorecordset--setbookmark.md) member function instead.  
  
 For related information, see the topic "PercentPosition Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetPercentPosition](../vs140/cdaorecordset--getpercentposition.md)