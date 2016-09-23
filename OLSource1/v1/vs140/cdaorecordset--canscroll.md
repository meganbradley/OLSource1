---
title: "CDaoRecordset::CanScroll"
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
  - CDaoRecordset::CanScroll
  - CanScroll
  - CDaoRecordset.CanScroll
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanScroll method
  - CDaoRecordset class, scrolling
ms.assetid: f685c0c3-7900-4c5e-8419-158612845632
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::CanScroll
Call this member function to determine whether the recordset allows scrolling.  
  
## Syntax  
  
```  
  
BOOL CanScroll( ) const;  
  
```  
  
## Return Value  
 Nonzero if you can scroll through the records, otherwise 0.  
  
## Remarks  
 If you call [Open](../vs140/cdaorecordset--open.md) with **dbForwardOnly**, the recordset can only scroll forward.  
  
 For related information, see the topic "Positioning the Current Record Pointer with DAO" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::CanAppend](../vs140/cdaorecordset--canappend.md)   
 [CDaoRecordset::CanBookmark](../vs140/cdaorecordset--canbookmark.md)   
 [CDaoRecordset::CanRestart](../vs140/cdaorecordset--canrestart.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)   
 [CDaoRecordset::CanUpdate](../vs140/cdaorecordset--canupdate.md)   
 [CDaoRecordset::Open](../vs140/cdaorecordset--open.md)