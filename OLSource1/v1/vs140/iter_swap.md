---
title: "iter_swap"
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
  - "std::iter_swap"
  - "std.iter_swap"
  - "xutility/std::iter_swap"
  - "iter_swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iter_swap"
  - "iter_swap function"
ms.assetid: c29e658c-0e99-4f11-ad60-d09301a15e1d
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# iter_swap
Exchanges two values referred to by a pair of specified iterators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the forward iterators whose value is to be exchanged.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second of the forward iterators whose value is to be exchanged.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should be used in preference to i**ter_swap**, which was included in the C++ Standard for backward compatibility. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are forward iterators, then <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> ( <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> ), is equivalent to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> ( *<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, \*<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> ).  
  
 The value types of the input forward iterators must have the same value.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original deque of CInts is deq1 = ( CInt(5), CInt(1), CInt(10) ).**  
**The deque of CInts with first & last elements swapped is:**  
 **deq1 = ( CInt(10), CInt(1), CInt(5) ).**  
**The deque of CInts with first & last elements swapped back is:**  
 **deq1 = ( CInt(5), CInt(1), CInt(10) ).**  
**Vector v1 is ( 0 1 2 3 ).**  
**Deque deq2 is ( 4 5 ).**  
**After exchanging first elements,**  
 **vector v1 is: v1 = ( 4 1 2 3 ).**  
 **& deque deq2 is: deq2 = ( 0 5 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [iter_swap](../vs140/iter_swap--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)