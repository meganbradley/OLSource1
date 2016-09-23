---
title: "CDaoRecordset::CanRestart"
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
  - CDaoRecordset.CanRestart
  - CDaoRecordset::CanRestart
  - CanRestart
dev_langs: 
  - C++
helpviewer_keywords: 
  - recordsets, requerying
  - DAO recordsets, requerying
  - requerying recordsets
  - CDaoRecordset class, restarting queries
  - DAO recordsets
  - CanRestart method
  - refreshing recordsets
ms.assetid: 455d874a-9c10-46e9-873b-5a9f7e130f47
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::CanRestart
Call this member function to determine whether the recordset allows restarting its query (to refresh its records) by calling the **Requery** member function.  
  
## Syntax  
  
```  
  
BOOL CanRestart( );  
  
```  
  
## Return Value  
 Nonzero if **Requery** can be called to run the recordset's query again, otherwise 0.  
  
## Remarks  
 Table-type recordsets do not support **Requery**.  
  
 If **Requery** is not supported, call [Close](../vs140/cdaorecordset--close.md) then [Open](../vs140/cdaorecordset--open.md) to refresh the data. You can call **Requery** to update a recordset object's underlying parameter query after the parameter values have been changed.  
  
 For related information, see the topic "Restartable Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::CanAppend](../vs140/cdaorecordset--canappend.md)   
 [CDaoRecordset::CanBookmark](../vs140/cdaorecordset--canbookmark.md)   
 [CDaoRecordset::CanScroll](../vs140/cdaorecordset--canscroll.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)   
 [CDaoRecordset::CanUpdate](../vs140/cdaorecordset--canupdate.md)