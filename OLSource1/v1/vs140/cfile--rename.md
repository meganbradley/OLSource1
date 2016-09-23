---
title: "CFile::Rename"
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
  - CFile.Rename
  - CFile::Rename
dev_langs: 
  - C++
helpviewer_keywords: 
  - Rename method
  - CFile class, static
ms.assetid: b65539c5-ba0d-4a29-bfcf-c4d3beab2c09
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFile::Rename
This static function renames the specified file.  
  
## Syntax  
  
```  
  
      static void PASCAL Rename(  
   LPCTSTR lpszOldName,  
   LPCTSTR lpszNewName,  
   CAtlTransactionManager* pTM = NULL  
);  
```  
  
#### Parameters  
 `lpszOldName`  
 The old path.  
  
 `lpszNewName`  
 The new path.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 Directories cannot be renamed. This is equivalent to the REN command.  
  
## Example  
 [!code[NVC_MFCFiles#18](../vs140/codesnippet/CPP/cfile--rename_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)