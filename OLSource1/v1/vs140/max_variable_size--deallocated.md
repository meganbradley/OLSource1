---
title: "max_variable_size::deallocated"
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
  - "allocators/stdext::max_variable_size::deallocated"
  - "max_variable_size.deallocated"
  - "stdext::max_variable_size::deallocated"
  - "max_variable_size::deallocated"
  - "stdext.max_variable_size.deallocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deallocated method"
ms.assetid: 4073c5fe-360e-4fa4-b89e-1d3cd1df73b9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# max_variable_size::deallocated
Decrements the count of allocated memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The increment value.|  
  
## Remarks  
 The member function subtracts <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> from the stored value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This member function is called after each call by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the number of memory blocks in the chunk deallocated by operator <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_variable_size Class](../vs140/max_variable_size-class.md)