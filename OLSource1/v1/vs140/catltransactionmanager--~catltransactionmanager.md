---
title: "CAtlTransactionManager::~CAtlTransactionManager"
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
  - "~CAtlTransactionManager"
  - "atltransactionmanager/CAtlTransactionManager::~CAtlTransactionManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~CAtlTransactionManager, destructor"
ms.assetid: 9b639a1b-7fd3-4f02-9837-f7c578bbc5f9
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::~CAtlTransactionManager
CAtlTransactionManager destructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In normal processing, the transaction is automatically committed and closed. If the destructor is called during an exception unwind, the transaction is rolled back and closed.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)