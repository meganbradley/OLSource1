---
title: "deque::assign"
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
  - "assign"
  - "deque.assign"
  - "Assign"
  - "std.deque.assign"
  - "std::deque::assign"
  - "deque/std::deque::assign"
  - "deque::assign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assign method"
  - "assign function"
ms.assetid: 07b57b31-474d-486a-8e3f-9a015031860b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::assign
Erases elements from a deque and copies a new set of elements to the target deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the first element in the range of elements to be copied from the argument deque.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the first element beyond the range of elements to be copied from the argument deque.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of copies of an element being inserted into the deque.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The value of the element being inserted into the deque.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The initializer_list being inserted into the deque.  
  
## Remarks  
 After any existing elements in the target deque are erased, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> either inserts a specified range of elements from the original deque or from some other deque into the target deque, or inserts copies of a new element of a specified value into the target deque.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **d1 = 5678c1 =102030c1 =5060c1 =4444444**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::assign and deque::swap](../vs140/deque--assign-and-deque--swap.md)   
 [Standard Template Library](../vs140/standard-template-library.md)