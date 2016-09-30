---
title: "memory_order Enum"
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
  - "atomic/std::memory_order"
dev_langs: 
  - "C++"
ms.assetid: 55c584b6-c9b3-422d-8e68-9077ae3cc4dd
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memory_order Enum
Supplies symbolic names for synchronization operations on memory locations. These operations affect how assignments in one thread become visible in another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|No ordering required.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A load operation acts as a consume operation on the memory location.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A load operation acts as an acquire operation on the memory location.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A store operation acts as a release operation on the memory location.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Combines <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Combines <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Memory accesses that are marked as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> must be sequentially consistent.|  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)