---
title: "CAtlTransactionManager::GetHandle"
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
  - "GetHandle"
  - "atltransactionmanager/CAtlTransactionManager::GetHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHandle"
ms.assetid: 5a4b6fa0-2c5a-4a76-bcf3-0ddfb1fff88d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::GetHandle
Returns the transaction handle.  
  
## Syntax  
  
```  
HANDLE GetHandle() const;  
```  
  
## Return Value  
 Returns the transaction handle for a class. Returns `NULL` if the `CAtlTransactionManager` is not attached to a handle.  
  
## Remarks  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)