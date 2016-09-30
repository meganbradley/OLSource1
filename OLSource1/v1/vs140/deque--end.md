---
title: "deque::end"
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
  - "std.deque.end"
  - "end"
  - "std::deque::end"
  - "deque/std::deque::end"
  - "deque.end"
  - "deque::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: b6c81821-b5b7-446c-9374-9d982036762b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::end
Returns an iterator that addresses the location succeeding the last element in a deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A random-access iterator that addresses the location succeeding the last element in a deque. If the deque is empty, then deque::end == deque::begin.  
  
## Remarks  
 **end** is used to test whether an iterator has reached the end of its deque.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last integer of c1 is 30**  
**The new next-to-last integer of c1 is 400**  
**The deque is now: 10 400 30**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::begin and deque::end](../vs140/deque--begin-and-deque--end.md)   
 [Standard Template Library](../vs140/standard-template-library.md)