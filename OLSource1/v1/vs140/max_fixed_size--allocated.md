---
title: "max_fixed_size::allocated"
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
  - "allocators/stdext::max_fixed_size::allocated"
  - "stdext::max_fixed_size::allocated"
  - "max_fixed_size::allocated"
  - "max_fixed_size.allocated"
  - "stdext.max_fixed_size.allocated"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "allocated method"
ms.assetid: 749b4cd2-f027-46ed-bd64-433b434668b5
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# max_fixed_size::allocated
Increments the count of allocated memory blocks.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The increment value.|  
  
## Remarks  
 The member function does nothing. This member function is called after each successful call by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to operator <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the number of memory blocks in the chunk allocated by operator <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<allocators>  
  
 **Namespace:** stdext  
  
## See Also  
 [max_fixed_size Class](../vs140/max_fixed_size-class.md)