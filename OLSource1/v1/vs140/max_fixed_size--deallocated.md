---
title: "max_fixed_size::deallocated"
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
  - "stdext.max_fixed_size.deallocated"
  - "max_fixed_size.deallocated"
  - "stdext::max_fixed_size::deallocated"
  - "allocators/stdext::max_fixed_size::deallocated"
  - "max_fixed_size::deallocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocated method"
ms.assetid: eed406a0-6ee8-46f0-a89f-304b8f11a1e2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_fixed_size::deallocated
Decrements the count of allocated memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The increment value.|  
  
## Remarks  
 The member function does nothing. This member function is called after each call by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the number of memory blocks in the chunk deallocated by operator <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_fixed_size Class](../vs140/max_fixed_size-class.md)