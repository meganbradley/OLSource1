---
title: "stack::top"
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
  - "stack::top"
  - "stack.top"
  - "std::stack::top"
  - "Top"
  - "std.stack.top"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "top method"
ms.assetid: d5b36f82-7d9d-40f8-ad81-429507daa691
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::top
Returns a reference to an element at the top of the stack.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to the last element in the container at the top of the stack.  
  
## Remarks  
 The stack must be nonempty to apply the member function. The top of the stack is the position occupied by the most recently added element and is the last element at the end of the container.  
  
 If the return value of **top** is assigned to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the stack object cannot be modified. If the return value of **top** is assigned to a **reference**, the stack object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The top integer of the stack s1 is 2.**  
**The next integer down is 1.**   
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
## See Also  
 [stack Class](../vs140/stack-class.md)   
 [stack::top and stack::empty](../vs140/stack--top-and-stack--empty.md)   
 [Standard Template Library](../vs140/standard-template-library.md)