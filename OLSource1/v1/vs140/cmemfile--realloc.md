---
title: "CMemFile::Realloc"
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
  - "CMemFile.Realloc"
  - "CMemFile::Realloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReAlloc method"
  - "CMemFile class, advanced overridables"
ms.assetid: 08b60639-229b-4e30-8798-96a020132b9d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile::Realloc
This function is called by `CMemFile` member functions.  
  
## Syntax  
  
```  
  
      virtual BYTE* Realloc(  
   BYTE* lpMem,  
   SIZE_T nBytes   
);  
```  
  
#### Parameters  
 `lpMem`  
 A pointer to the memory block to be reallocated.  
  
 `nBytes`  
 New size for the memory block.  
  
## Return Value  
 A pointer to the memory block that was reallocated (and possibly moved), or **NULL** if the reallocation failed.  
  
## Remarks  
 Override this function to implement custom memory reallocation. If you override this function, you'll probably want to override [Alloc](../vs140/cmemfile--alloc.md) and [Free](../vs140/cmemfile--free.md) as well.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::Alloc](../vs140/cmemfile--alloc.md)   
 [CMemFile::Free](../vs140/cmemfile--free.md)