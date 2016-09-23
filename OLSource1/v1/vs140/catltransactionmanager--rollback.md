---
title: "CAtlTransactionManager::Rollback"
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
  - Rollback
  - atltransactionmanager/CAtlTransactionManager::Rollback
dev_langs: 
  - C++
helpviewer_keywords: 
  - Rollback
ms.assetid: 986c066d-d901-40d9-b292-dd9b2c5815e0
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlTransactionManager::Rollback
Requests that the transaction be rolled back.  
  
## Syntax  
  
```  
inline BOOL CAtlTransactionManager::Rollback();  
```  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 This wrapper calls the `RollbackTransaction` function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)