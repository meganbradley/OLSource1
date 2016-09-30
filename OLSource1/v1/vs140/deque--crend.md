---
title: "deque::crend"
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
  - "deque.crend"
  - "std.deque.crend"
  - "deque/std::deque::crend"
  - "crend"
  - "deque::crend"
  - "std::deque::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method, deque class"
  - "crend method"
ms.assetid: 75c4377c-ae59-41ba-87c5-b2b1a002d159
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse random-access iterator that addresses the location succeeding the last element in a reversed [deque](../vs140/deque-class.md) (the location that had preceded the first element in the unreversed deque).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> just as [cend](../vs140/array--cend.md) is used with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (suitably decremented), the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its deque.  
  
 The value returned by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **2**  
**1**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)