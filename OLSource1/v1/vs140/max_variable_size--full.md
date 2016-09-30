---
title: "max_variable_size::full"
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
  - "stdext.max_variable_size.full"
  - "max_variable_size::full"
  - "allocators/stdext::max_variable_size::full"
  - "max_variable_size.full"
  - "stdext::max_variable_size::full"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "full method"
ms.assetid: c2b15915-4bbf-4ec9-a4e7-b8eec1f7561d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_variable_size::full
Returns a value that specifies whether more memory blocks should be added to the free list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This member function is called by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the call returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> puts the memory block on the free list; if it returns false, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls operator <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to deallocate the block.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_variable_size Class](../vs140/max_variable_size-class.md)