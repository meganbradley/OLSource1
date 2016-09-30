---
title: "deque::crbegin"
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
  - "deque::crbegin"
  - "deque/std::deque::crbegin"
  - "std::deque::crbegin"
  - "std.deque.crbegin"
  - "deque.crbegin"
  - "crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method, deque class"
  - "crbegin method"
ms.assetid: c7a08d74-e8fd-433b-9a99-ba21bb9b072f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::crbegin
Returns a const iterator to the first element in a reversed deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse random-access iterator addressing the first element in a reversed [deque](../vs140/deque-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 With the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object cannot be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of deque is 1.**  
**The first element of the reversed deque is 2.**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)