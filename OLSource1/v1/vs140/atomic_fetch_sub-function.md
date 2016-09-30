---
title: "atomic_fetch_sub Function"
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
  - "atomic/std::atomic_fetch_sub"
dev_langs: 
  - "C++"
ms.assetid: f2bee484-b4d7-48ab-8bf7-1c36e6ce7978
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_fetch_sub Function
Subtracts a value from an existing value that is stored in an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that stores a pointer to type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 The value of the pointer contained by the atomic object immediately before the operation was performed.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> operation to atomically subtract <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> from the stored value in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[memory_order](../vs140/memory_order-enum.md) constraint.  
  
 When the atomic type is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and the operation treats the stored pointer as a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 This operation is also overloaded for integral types:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** atomic  
  
 **Namespace:** std  
  
## See Also  
 [\<atomic>](../vs140/-atomic-.md)   
 [atomic Structure](../vs140/atomic-structure.md)   
 [atomic_fetch_sub_explicit](../vs140/atomic_fetch_sub_explicit-function.md)