---
title: "CMemFile::Free"
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
  - "CMemFile.Free"
  - "CMemFile::Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
  - "CMemFile class, advanced overridables"
ms.assetid: 4fcaa453-ae1b-4e6e-8c90-26bafa3387dc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile::Free
This function is called by `CMemFile` member functions.  
  
## Syntax  
  
```  
  
      virtual void Free(  
   BYTE * lpMem   
);  
```  
  
#### Parameters  
 `lpMem`  
 Pointer to the memory to be deallocated*.*  
  
## Remarks  
 Override this function to implement custom memory deallocation. If you override this function, you'll probably want to override [Alloc](../vs140/cmemfile--alloc.md) and [Realloc](../vs140/cmemfile--realloc.md) as well.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::Alloc](../vs140/cmemfile--alloc.md)   
 [CMemFile::Realloc](../vs140/cmemfile--realloc.md)