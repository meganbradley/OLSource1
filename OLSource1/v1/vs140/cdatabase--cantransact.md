---
title: "CDatabase::CanTransact"
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
  - "CDatabase::CanTransact"
  - "CDatabase.CanTransact"
  - "CanTransact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanTransact method"
  - "CDatabase class, database attributes"
ms.assetid: 80996888-62ae-4fd5-8079-476beb719ddb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDatabase::CanTransact
Call this member function to determine whether the database allows transactions.  
  
## Syntax  
  
```  
  
BOOL CanTransact( ) const;  
```  
  
## Return Value  
 Nonzero if recordsets using this `CDatabase` object allow transactions; otherwise 0.  
  
## Remarks  
 For information about transactions, see the article [Transaction (ODBC)](../vs140/transaction--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CDatabase Class](../vs140/cdatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDatabase::BeginTrans](../vs140/cdatabase--begintrans.md)   
 [CDatabase::CommitTrans](../vs140/cdatabase--committrans.md)   
 [CDatabase::Rollback](../vs140/cdatabase--rollback.md)