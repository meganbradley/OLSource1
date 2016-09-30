---
title: "atomic_fetch_or_explicit Function"
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
  - "atomic/std::atomic_fetch_or_explicit"
dev_langs: 
  - "C++"
ms.assetid: 5b1ff955-e6a5-4dfb-83e8-683b37f69fab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_or_explicit Function
Performs a bitwise <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on a value and an existing value that is stored in an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/memory_order-enum.md).  
  
## Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, within the [memory_order](../vs140/memory_order-enum.md) constraints specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_or](../vs140/atomic_fetch_or-function.md)