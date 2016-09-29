---
title: "CDaoDatabase::CanTransact"
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
  - "CDaoDatabase::CanTransact"
  - "CanTransact"
  - "CDaoDatabase.CanTransact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoDatabase class, transaction support"
  - "CanTransact method"
  - "DAO [C++], transactions"
  - "transactions [C++], support for"
  - "databases [C++], transaction support"
  - "checking transaction support [C++]"
ms.assetid: 2773b162-245f-4632-8966-0e99a7acc32a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoDatabase::CanTransact
Call this member function to determine whether the database allows transactions.  
  
## Syntax  
  
```  
  
BOOL CanTransact( );  
  
```  
  
## Return Value  
 Nonzero if the database supports transactions; otherwise 0.  
  
## Remarks  
 Transactions are managed in the database's workspace.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoDatabase Class](../vs140/cdaodatabase-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoWorkspace::BeginTrans](../vs140/cdaoworkspace--begintrans.md)   
 [CDaoWorkspace::CommitTrans](../vs140/cdaoworkspace--committrans.md)   
 [CDaoWorkspace::Rollback](../vs140/cdaoworkspace--rollback.md)