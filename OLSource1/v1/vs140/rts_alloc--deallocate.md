---
title: "rts_alloc::deallocate"
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
  - "stdext::rts_alloc::deallocate"
  - "allocators/stdext::rts_alloc::deallocate"
  - "stdext.rts_alloc.deallocate"
  - "rts_alloc::deallocate"
  - "rts_alloc.deallocate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocate method"
ms.assetid: 407f70e8-763d-4384-95a6-5b8ac8df7342
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# rts_alloc::deallocate
Frees a specified number of objects from storage beginning at a specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the first object to be deallocated from storage.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The number of objects to be deallocated from storage.|  
  
## Remarks  
 The member function calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, where the index <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is determined by the requested block size <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or, if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is too large, it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [rts_alloc Class](../vs140/rts_alloc-class.md)