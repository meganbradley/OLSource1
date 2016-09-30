---
title: "CHeapPtr::Reallocate"
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
  - "ATL::CHeapPtr::Reallocate"
  - "Reallocate"
  - "ATL.CHeapPtr.Reallocate"
  - "CHeapPtr::Reallocate"
  - "CHeapPtr.Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: de27f137-1c50-41d1-bf61-e8237202d404
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtr::Reallocate
Call this method to reallocate the memory on the heap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new number of elements used to calculate the amount of memory to allocate.  
  
## Return Value  
 Returns true if the memory was successfully allocated, false on failure.  
  
## Example  
 [!code[NVC_ATL_Utilities#79](../vs140/codesnippet/CPP/cheapptr--reallocate_1.cpp)]  
  
## Requirements  
 **Header:** atlalloc.h  
  
## See Also  
 [CHeapPtr Class](../vs140/cheapptr-class.md)   
 [CHeapPtr::Allocate](../vs140/cheapptr--allocate.md)