---
title: "rts_alloc::allocate"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "stdext.rts_alloc.allocate"
  - "rts_alloc.allocate"
  - "rts_alloc::allocate"
  - "stdext::rts_alloc::allocate"
  - "allocators/stdext::rts_alloc::allocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocate method"
ms.assetid: d3c55aad-e31e-448d-8aae-c9d107acfd4c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rts_alloc::allocate
Allocates a block of memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The number of elements in the array to be allocated.|  
  
## Return Value  
 A pointer to the allocated object.  
  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, where the index <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is determined by the requested block size <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or, if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is too large, it returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which represents the cache object.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [rts_alloc Class](../vs140/rts_alloc-class.md)