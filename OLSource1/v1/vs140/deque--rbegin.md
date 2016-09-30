---
title: "deque::rbegin"
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
  - "deque::rbegin"
  - "std::deque::rbegin"
  - "rbegin"
  - "deque.rbegin"
  - "std.deque.rbegin"
  - "deque/std::deque::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 3248eded-ce82-4f04-b4a3-c78c6bfcb6f6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::rbegin
Returns an iterator to the first element in a reversed deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse random-access iterator addressing the first element in a reversed deque or addressing what had been the last element in the unreversed deque.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed deque just as [begin](../vs140/deque--begin.md) is used with a deque.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the deque object can be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to iterate through a deque backwards.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Last element in the deque is 30.**  
**The deque contains the elements: 10 20 30 in that order.**  
**The reversed deque is: 30 20 10**   
**Last element in deque is now 40.**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::rbegin and deque::rend](../vs140/deque--rbegin-and-deque--rend.md)   
 [Standard Template Library](../vs140/standard-template-library.md)