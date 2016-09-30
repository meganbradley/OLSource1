---
title: "forward_list::unique"
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
  - "forward_list.unique"
  - "std::forward_list::unique"
  - "std.forward_list.unique"
  - "forward_list::unique"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unique method"
ms.assetid: dee8098e-7320-42e4-938f-50b83d755f77
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::unique
Eliminates all but the first element from every consecutive group of equal elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The binary predicate used to compare successive elements.|  
  
## Remarks  
 Keeps the first of each unique element, and removes the rest. The elements must be sorted so that elements of equal value are adjacent in the list.  
  
 The first member function removes from the controlled sequence every element that compares equal to its preceding element. For the iterators <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> designating elements at positions <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the second member function removes every element for which <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For a controlled sequence of length <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (> 0), the predicate <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is evaluated <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> times.  
  
 An exception occurs only if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in an unspecified state and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)