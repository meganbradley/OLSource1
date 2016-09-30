---
title: "CAtlTransactionManager::FindFirstFile"
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
  - "FindFirstFile"
  - "atltransactionmanager/CAtlTransactionManager::FindFirstFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindFirstFile"
ms.assetid: 44b9514e-3aeb-41f8-853a-b38f992bc695
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTransactionManager::FindFirstFile
Searches a directory for a file or subdirectory as a transacted operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The directory or path, and the file name to search for. This parameter can include wildcard characters, such as an asterisk (*) or a question mark (?).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the WIN32_FIND_DATA structure that receives information about a found file or subdirectory.  
  
## Return Value  
 If the function succeeds, the return value is a search handle used in a subsequent call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the function fails or fails to locate files from the search string in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter, the return value is INVALID_HANDLE_VALUE.  
  
## Remarks  
 This wrapper calls the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function.  
  
## Requirements  
 **Header:** atltransactionmanager.h  
  
## See Also  
 [CAtlTransactionManager Class](../vs140/catltransactionmanager-class.md)