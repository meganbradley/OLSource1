---
title: "deque::resize"
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
  - "Resize"
  - "std::deque::resize"
  - "std.deque.resize"
  - "deque.resize"
  - "resize"
  - "deque/std::deque::resize"
  - "deque::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method, deque class"
  - "resize method"
ms.assetid: 8761c5d1-b5a9-4bbf-a30a-e1074343c5b1
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::resize
Specifies a new size for a deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new size of the deque.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of the new elements to be added to the deque if the new size is larger that the original size. If the value is omitted, the new elements are assigned the default value for the class.  
  
## Remarks  
 If the deque's size is less than the requested size, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, elements are added to the deque until it reaches the requested size.  
  
 If the deque's size is larger than the requested size, the elements closest to the end of the deque are deleted until the deque reaches the size <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 If the present size of the deque is the same as the requested size, no action is taken.  
  
 [size](../vs140/deque--size.md) reflects the current size of the deque.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The size of c1 is: 4**  
**The value of the last element is 40**  
**The size of c1 is now: 5**  
**The value of the last element is now 0**  
**The reduced size of c1 is: 2**  
**The value of the last element is now 20**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::size and deque::resize](../vs140/deque--size-and-deque--resize.md)   
 [Standard Template Library](../vs140/standard-template-library.md)