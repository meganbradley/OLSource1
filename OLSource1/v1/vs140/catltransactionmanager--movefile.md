---
title: "CAtlTransactionManager::MoveFile"
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
  - "atltransactionmanager/CAtlTransactionManager::MoveFile"
  - "MoveFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveFile"
ms.assetid: 4811a415-0708-49c5-a4b2-620be697a606
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::MoveFile
Moves an existing file or a directory, including its children, as a transacted operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The current name of the existing file or directory on the local computer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new name for the file or directory. This name must not already exist. A new file may be on a different file system or drive. A new directory must be on the same drive.  
  
## Remarks  
 This wrapper calls the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)