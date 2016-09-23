---
title: "CDaoRecordset::Requery"
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
  - CDaoRecordset::Requery
  - CDaoRecordset.Requery
dev_langs: 
  - C++
helpviewer_keywords: 
  - recordsets, requerying
  - CDaoRecordset class, requerying
  - Requery method
ms.assetid: 6fd9c3f6-0442-45b0-a861-9f3d7e6593b8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::Requery
Call this member function to rebuild (refresh) a recordset.  
  
## Syntax  
  
```  
  
virtual void Requery( );  
  
```  
  
## Remarks  
 If any records are returned, the first record becomes the current record.  
  
 In order for the recordset to reflect the additions and deletions that you or other users are making to the data source, you must rebuild the recordset by calling **Requery**. If the recordset is a dynaset, it automatically reflects updates that you or other users make to its existing records (but not additions). If the recordset is a snapshot, you must call **Requery** to reflect edits by other users as well as additions and deletions.  
  
 For either a dynaset or a snapshot, call **Requery** any time you want to rebuild the recordset using parameter values. Set the new filter or sort by setting [m_strFilter](../vs140/cdaorecordset--m_strfilter.md) and [m_strSort](../vs140/cdaorecordset--m_strsort.md) before calling **Requery**. Set new parameters by assigning new values to parameter data members before calling **Requery**.  
  
 If the attempt to rebuild the recordset fails, the recordset is closed. Before you call **Requery**, you can determine whether the recordset can be requeried by calling the [CanRestart](../vs140/cdaorecordset--canrestart.md) member function. `CanRestart` does not guarantee that **Requery** will succeed.  
  
> [!CAUTION]
>  Call **Requery** only after you have called **Open**.  
  
> [!NOTE]
>  Calling [Requery](#_mfc_cdaorecordset.3a3a.requery) changes DAO bookmarks.  
  
 You can't call **Requery** on a dynaset-type or snapshot-type recordset if calling `CanRestart` returns 0, nor can you use it on a table-type recordset.  
  
 If both `IsBOF` and `IsEOF` return nonzero after you call **Requery**, the query didn't return any records and the recordset will contain no data.  
  
 For related information, see the topic "Requery Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::CanRestart](../vs140/cdaorecordset--canrestart.md)