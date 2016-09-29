---
title: "CFile::Remove"
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
  - "CFile::Remove"
  - "CFile.Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
  - "CFile class, static"
ms.assetid: 819294a3-be29-47e2-b32c-e5ebf6e6e885
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Remove
This static function deletes the file specified by the path.  
  
## Syntax  
  
```  
  
      static void PASCAL Remove(  
   LPCTSTR lpszFileName,  
   CAtlTransactionManager* pTM = NULL  
);  
```  
  
#### Parameters  
 `lpszFileName`  
 A string that is the path to the desired file. The path can be relative or absolute, and can contain a network name.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 It will not remove a directory.  
  
 The **Remove** member function throws an exception if the connected file is open or if the file cannot be removed. This is equivalent to the DEL command.  
  
## Example  
 [!code[NVC_MFCFiles#17](../vs140/codesnippet/CPP/cfile--remove_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)