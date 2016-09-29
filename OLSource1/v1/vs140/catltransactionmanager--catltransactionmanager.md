---
title: "CAtlTransactionManager::CAtlTransactionManager"
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
  - "CAtlTransactionManager"
  - "atltransactionmanager/CAtlTransactionManager::CAtlTransactionManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlTransactionManager, constructor"
ms.assetid: fbbd610f-c8f5-404b-b685-ecbc07081bb6
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::CAtlTransactionManager
CAtlTransactionManager constructor.  
  
## Syntax  
  
```  
CAtlTransactionManager(  
   BOOL bFallback = TRUE,  
   BOOL bAutoCreateTransaction = TRUE  
);  
```  
  
#### Parameters  
 `bFallback`  
 `TRUE` indicates support fallback. If transacted function fails, the class automatically calls the "non-transacted" function. `FALSE` indicates no "fallback" calls.  
  
 `bAutoCreateTransaction`  
 `TRUE` indicates that the transaction handler is created automatically in the constructor. `FALSE` indicates that it is not.  
  
## Remarks  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)