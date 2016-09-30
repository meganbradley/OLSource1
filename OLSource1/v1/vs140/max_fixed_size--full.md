---
title: "max_fixed_size::full"
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
  - "stdext::max_fixed_size::full"
  - "stdext.max_fixed_size.full"
  - "max_fixed_size::full"
  - "allocators/stdext::max_fixed_size::full"
  - "max_fixed_size.full"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "full method"
ms.assetid: ce92febf-750d-4cca-bb75-c1a3e422539f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_fixed_size::full
Returns a value that specifies whether more memory blocks should be added to the free list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 This member function is called by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to deallocate the block.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_fixed_size Class](../vs140/max_fixed_size-class.md)