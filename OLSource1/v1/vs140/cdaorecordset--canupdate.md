---
title: "CDaoRecordset::CanUpdate"
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
  - "CDaoRecordset::CanUpdate"
  - "CDaoRecordset.CanUpdate"
  - "CanUpdate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanUpdate method"
  - "CDaoRecordset class, updating records"
  - "recordsets, updating"
ms.assetid: 7ff4d6b8-243b-4e5e-8ec7-fde909f468c2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::CanUpdate
Call this member function to determine whether the recordset can be updated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset can be updated (add, update, and delete records), otherwise 0.  
  
## Remarks  
 A recordset might be read-only if the underlying data source is read-only or if you specified **dbReadOnly** for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when you called [Open](../vs140/cdaorecordset--open.md) for the recordset.  
  
 For related information, see the topics "AddNew Method", "Edit Method", "Delete Method", "Update Method", and "Updatable Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::CanAppend](../vs140/cdaorecordset--canappend.md)   
 [CDaoRecordset::CanBookmark](../vs140/cdaorecordset--canbookmark.md)   
 [CDaoRecordset::CanScroll](../vs140/cdaorecordset--canscroll.md)   
 [CDaoRecordset::CanRestart](../vs140/cdaorecordset--canrestart.md)   
 [CDaoRecordset::CanTransact](../vs140/cdaorecordset--cantransact.md)