---
title: "max_variable_size::allocated"
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
  - "max_variable_size::allocated"
  - "allocators/stdext::max_variable_size::allocated"
  - "stdext::max_variable_size::allocated"
  - "max_variable_size.allocated"
  - "stdext.max_variable_size.allocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocated method"
ms.assetid: c45b0fec-9680-4d10-a0dd-ba50c5641469
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_variable_size::allocated
Increments the count of allocated memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The increment value.|  
  
## Remarks  
 This member function adds <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the stored value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This member function is called after each successful call by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_variable_size Class](../vs140/max_variable_size-class.md)