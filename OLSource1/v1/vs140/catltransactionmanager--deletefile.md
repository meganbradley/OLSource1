---
title: "CAtlTransactionManager::DeleteFile"
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
  - "DeleteFile"
  - "atltransactionmanager/CAtlTransactionManager::DeleteFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteFile"
ms.assetid: a6ff1c0d-5f18-4363-b91e-04620b6a545b
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::DeleteFile
Deletes an existing file as a transacted operation.  
  
## Syntax  
  
```  
inline BOOL CAtlTransactionManager::DeleteFile(  
   LPCTSTR lpFileName  
);  
```  
  
#### Parameters  
 `lpFileName`  
 The name of the file to be deleted.  
  
## Remarks  
 This wrapper calls the `DeleteFileTransacted` function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)