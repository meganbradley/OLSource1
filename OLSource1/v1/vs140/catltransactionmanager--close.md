---
title: "CAtlTransactionManager::Close"
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
  - "Close"
  - "atltransactionmanager/CAtlTransactionManager::Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close"
ms.assetid: 072c2f53-b557-462f-9ac3-45eacf6e66b0
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::Close
Closes the transaction handle.  
  
## Syntax  
  
```  
inline BOOL CAtlTransactionManager::Close();  
```  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
 This wrapper calls the `CloseHandle` function. The method is automatically called in the destructor.  
  
## Requirements  
 **Header:** atltransactionmanagerh  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)