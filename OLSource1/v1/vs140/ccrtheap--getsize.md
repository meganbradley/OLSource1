---
title: "CCRTHeap::GetSize"
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
  - "CCRTHeap::GetSize"
  - "ATL.CCRTHeap.GetSize"
  - "CCRTHeap.GetSize"
  - "ATL::CCRTHeap::GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 8173e2fc-04ef-4f62-9bae-18872abc2832
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCRTHeap::GetSize
Call this method to get the allocated size of a memory block allocated by this memory manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to memory previously allocated by this memory manager.  
  
## Return Value  
 Returns the size of the allocated memory block in bytes.  
  
## Remarks  
 Implemented using [_msize](../vs140/_msize.md).  
  
## Requirements  
 **Header:** atlmem.h  
  
## See Also  
 [CCRTHeap Class](../vs140/ccrtheap-class.md)