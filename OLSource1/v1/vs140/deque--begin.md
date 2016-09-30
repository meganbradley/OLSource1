---
title: "deque::begin"
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
  - "deque.begin"
  - "deque/std::deque::begin"
  - "deque::begin"
  - "std::deque::begin"
  - "std.deque.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method"
  - "begin method, deque class"
ms.assetid: 0a7d5781-39ce-4df8-9914-4344a0a52b2b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::begin
Returns an iterator addressing the first element in the deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A random-access iterator addressing the first element in the deque or to the location succeeding an empty deque.  
  
## Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the deque object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the deque object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of c1 is 1**  
**The first element of c1 is now 20**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::begin and deque::end](../vs140/deque--begin-and-deque--end.md)   
 [Standard Template Library](../vs140/standard-template-library.md)