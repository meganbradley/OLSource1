---
title: "CAtlTransactionManager::GetFileAttributes"
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
  - GetFileAttributes
  - atltransactionmanager/CAtlTransactionManager::GetFileAttributes
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFileAttributes
ms.assetid: f82ab29b-0e57-42d8-b477-8edec5429d5f
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlTransactionManager::GetFileAttributes
Retrieves file system attributes for a specified file or directory as a transacted operation.  
  
## Syntax  
  
```  
inline DWORD CAtlTransactionManager::GetFileAttributes(  
   LPCTSTR lpFileName  
);  
```  
  
#### Parameters  
 `lpFileName`  
 The name of the file or directory.  
  
## Remarks  
 This wrapper calls the `GetFileAttributesTransacted` function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)