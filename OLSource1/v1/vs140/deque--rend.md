---
title: "deque::rend"
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
  - "deque::rend"
  - "rend"
  - "std.deque.rend"
  - "deque.rend"
  - "std::deque::rend"
  - "deque/std::deque::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 7b193566-e408-48d2-83f7-e014100510a2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::rend
Returns an iterator that addresses the location succeeding the last element in a reversed deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed deque (the location that had preceded the first element in the unreversed deque).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed deque just as [end](../vs140/deque--end.md) is used with a deque.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the deque object can be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to test whether a reverse iterator has reached the end of its deque.  
  
 The value returned by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element in the deque is: 10**  
**The deque is: 10 20 30**   
**The reversed deque is: 30 20 10**   
**The modified reversed deque is: 30 20 40**    
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::rbegin and deque::rend](../vs140/deque--rbegin-and-deque--rend.md)   
 [Standard Template Library](../vs140/standard-template-library.md)