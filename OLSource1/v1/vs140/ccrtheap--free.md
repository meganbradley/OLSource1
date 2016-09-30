---
title: "CCRTHeap::Free"
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
  - "CCRTHeap.Free"
  - "CCRTHeap::Free"
  - "ATL::CCRTHeap::Free"
  - "ATL.CCRTHeap.Free"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Free method"
ms.assetid: 74c0bef5-988b-4b41-9c27-e45921ab980b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCRTHeap::Free
Call this method to free a block of memory allocated by this memory manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager. NULL is a valid value and does nothing.  
  
## Remarks  
 Implemented using [free](../vs140/free.md).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CCRTHeap Class](../vs140/ccrtheap-class.md)   
 [CCRTHeap::Allocate](../vs140/ccrtheap--allocate.md)   
 [CCRTHeap::Reallocate](../vs140/ccrtheap--reallocate.md)