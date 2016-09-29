---
title: "CAtlTransactionManager::Create"
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
  - "Create"
  - "atltransactionmanager/CAtlTransactionManager::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create"
ms.assetid: c23a07c7-d519-4da5-a27a-b878e9c93a9a
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::Create
Creates the transaction handle.  
  
## Syntax  
  
```  
inline BOOL CAtlTransactionManager::Create();  
```  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 This wrapper calls the `CreateTransaction` function. Check it for  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)