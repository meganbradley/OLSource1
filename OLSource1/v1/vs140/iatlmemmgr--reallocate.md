---
title: "IAtlMemMgr::Reallocate"
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
  - "Reallocate"
  - "ATL::IAtlMemMgr::Reallocate"
  - "IAtlMemMgr.Reallocate"
  - "ATL.IAtlMemMgr.Reallocate"
  - "IAtlMemMgr::Reallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Reallocate method"
ms.assetid: 2e2696ac-5b43-40c5-b41d-63122ee794f0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAtlMemMgr::Reallocate
Call this method to reallocate memory allocated by this memory manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The requested number of bytes in the new memory block.  
  
## Return Value  
 Returns a pointer to the start of the newly allocated memory block.  
  
## Remarks  
 Call [IAtlMemMgr::Free](../vs140/iatlmemmgr--free.md) or [IAtlMemMgr::Reallocate](#vclrfiatlmemmgrreallocate) to free the memory allocated by this method.  
  
 Conceptually this method frees the existing memory and allocates a new memory block. In reality, the existing memory may be extended or otherwise reused.  
  
## Example  
 For an example, see the [IAtlMemMgr Overview](../vs140/iatlmemmgr-class.md).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [IAtlMemMgr Class](../vs140/iatlmemmgr-class.md)