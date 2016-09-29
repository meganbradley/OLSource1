---
title: "CAtlTransactionManager::Commit"
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
  - "Commit"
  - "atltransactionmanager/CAtlTransactionManager::Commit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Commit"
ms.assetid: 0477d3c0-83ed-43c3-a79c-d82880160d1f
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::Commit
Requests that the transaction be committed.  
  
## Syntax  
  
```  
inline BOOL CAtlTransactionManager::Commit();  
```  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 This wrapper calls the `CommitTransaction` function. The method is automatically called in the destructor.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)