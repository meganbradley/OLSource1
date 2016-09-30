---
title: "max_unbounded::full"
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
  - "stdext.max_unbounded.full"
  - "max_unbounded.full"
  - "max_unbounded::full"
  - "stdext::max_unbounded::full"
  - "allocators/stdext::max_unbounded::full"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "full method"
ms.assetid: b1879cb7-ce2b-41c0-a66f-602e2d049a98
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_unbounded::full
Returns a value that specifies whether more memory blocks should be added to the free list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The member function always returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 This member function is called by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to deallocate the block.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_unbounded Class](../vs140/max_unbounded-class.md)