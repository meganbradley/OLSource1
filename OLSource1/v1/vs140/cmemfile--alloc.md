---
title: "CMemFile::Alloc"
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
  - "Alloc"
  - "CMemFile.Alloc"
  - "CMemFile::Alloc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Alloc method"
  - "CMemFile class, advanced overridables"
ms.assetid: c1656bac-c2a0-4fb9-a1b6-d3bcd22152f8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile::Alloc
This function is called by `CMemFile` member functions.  
  
## Syntax  
  
```  
  
      virtual BYTE* Alloc(  
   SIZE_T nBytes   
);  
```  
  
#### Parameters  
 `nBytes`  
 Number of bytes of memory to be allocated.  
  
## Return Value  
 A pointer to the memory block that was allocated, or **NULL** if the allocation failed.  
  
## Remarks  
 Override this function to implement custom memory allocation. If you override this function, you'll probably want to override [Free](../vs140/cmemfile--free.md) and [Realloc](../vs140/cmemfile--realloc.md) as well.  
  
 The default implementation uses the run-time library function [malloc](../vs140/malloc.md) to allocate memory.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::Free](../vs140/cmemfile--free.md)   
 [CMemFile::Realloc](../vs140/cmemfile--realloc.md)   
 [malloc](../vs140/malloc.md)