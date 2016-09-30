---
title: "max_none::full"
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
  - "max_none::full"
  - "allocators/stdext::max_none::full"
  - "stdext.max_none.full"
  - "stdext::max_none::full"
  - "max_none.full"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "full method"
ms.assetid: fc44210e-e45b-47c1-a247-8adc7153c4e8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_none::full
Returns a value that specifies whether more memory blocks should be added to the free list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 This member function always returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 This member function is called by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to deallocate the block.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_none Class](../vs140/max_none-class.md)