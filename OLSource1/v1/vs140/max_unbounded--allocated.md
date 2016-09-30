---
title: "max_unbounded::allocated"
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
  - "stdext::max_unbounded::allocated"
  - "stdext.max_unbounded.allocated"
  - "max_unbounded::allocated"
  - "max_unbounded.allocated"
  - "allocators/stdext::max_unbounded::allocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocated method"
ms.assetid: 6407b176-f6f8-440a-8dd4-c67f7b94d3a1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_unbounded::allocated
Increments the count of allocated memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The increment value.|  
  
## Remarks  
 This member function does nothing. It is called after each successful call by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_unbounded Class](../vs140/max_unbounded-class.md)