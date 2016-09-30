---
title: "max_unbounded::deallocated"
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
  - "max_unbounded::deallocated"
  - "allocators/stdext::max_unbounded::deallocated"
  - "max_unbounded.deallocated"
  - "stdext.max_unbounded.deallocated"
  - "stdext::max_unbounded::deallocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocated method"
ms.assetid: 8f3d525c-5847-4c25-a6a7-51cab98a932a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_unbounded::deallocated
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
 [max_unbounded Class](../vs140/max_unbounded-class.md)