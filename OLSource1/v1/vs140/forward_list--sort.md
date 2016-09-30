---
title: "forward_list::sort"
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
  - "forward_list::sort"
  - "std.forward_list.sort"
  - "forward_list.sort"
  - "forward_list/std::forward_list::sort"
  - "sort"
  - "std::forward_list::sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sort method"
ms.assetid: 4fc4a8ab-4cdd-4d03-891a-e28cf1050aa9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::sort
Arranges the elements in ascending order or with an order specified by a predicate.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The ordering predicate.|  
  
## Remarks  
 Both member functions order the elements in the controlled sequence by a predicate, described below.  
  
 For the iterators <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> designating elements at positions <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the first member function imposes the order <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. (The elements are sorted in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> order.) The member template function imposes the order <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. No ordered pairs of elements in the original controlled sequence are reversed in the resulting controlled sequence. (The sort is stable.)  
  
 An exception occurs only if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in unspecified order and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)