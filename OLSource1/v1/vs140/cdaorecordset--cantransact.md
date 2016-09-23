---
title: "CDaoRecordset::CanTransact"
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
  - CDaoRecordset.CanTransact
  - CanTransact
  - CDaoRecordset::CanTransact
dev_langs: 
  - C++
helpviewer_keywords: 
  - CanTransact method
  - CDaoRecordset class, transactions
  - recordsets, transactions
ms.assetid: e1465fd6-4467-4962-ad32-ab9490d1ca28
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::CanTransact
Call this member function to determine whether the recordset allows transactions.  
  
## Syntax  
  
```  
  
BOOL CanTransact( );  
  
```  
  
## Return Value  
 Nonzero if the underlying data source supports transactions, otherwise 0.  
  
## Remarks  
 For related information, see the topic "Transactions Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::AddNew](../vs140/cdaorecordset--addnew.md)   
 [CDaoRecordset::CanAppend](../vs140/cdaorecordset--canappend.md)   
 [CDaoRecordset::CancelUpdate](../vs140/cdaorecordset--cancelupdate.md)   
 [CDaoRecordset::CanScroll](../vs140/cdaorecordset--canscroll.md)   
 [CDaoRecordset::CanRestart](../vs140/cdaorecordset--canrestart.md)   
 [CDaoRecordset::CanUpdate](../vs140/cdaorecordset--canupdate.md)   
 [CDaoRecordset::Delete](../vs140/cdaorecordset--delete.md)   
 [CDaoRecordset::Edit](../vs140/cdaorecordset--edit.md)   
 [CDaoRecordset::Update](../vs140/cdaorecordset--update.md)