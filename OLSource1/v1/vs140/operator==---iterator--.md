---
title: "operator== (&lt;iterator&gt;)"
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
  - "std.=="
  - "std::=="
  - "iterator/std::operator=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, iterators"
  - "operator ==, iterators"
  - "== operator, with specific standard C++ objects"
ms.assetid: e6eda1da-bc7a-44e7-80f3-c597c4bf3396
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;iterator&gt;)
Tests if the iterator object on the left side of the operator is equal to the iterator object on the right side.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type iterator.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the iterator objects are equal; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the iterator objects are not equal.  
  
## Remarks  
 One iterator object is equal to another if they address the same elements in a container. If two iterators point to different elements in a container, then they are not equal.  
  
 The first two template operators return true only if both <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> store the same iterator. The third template operator returns true only if both <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> store the same stream pointer. The fourth template operator returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The vector vec is: ( 2 4 6 8 10 ).**  
**The iterator rVPOS1 initially points to the first element**  
 **in the reversed sequence: 10.**  
**The iterators are equal.**  
**The iterator rVPOS1 now points to the second element**  
 **in the reversed sequence: 8.**  
**The iterators are not equal.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)