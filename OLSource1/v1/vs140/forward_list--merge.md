---
title: "forward_list::merge"
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
  - "merge"
  - "std.forward_list.merge"
  - "forward_list/std::forward_list::merge"
  - "forward_list::merge"
  - "forward_list.merge"
  - "std::forward_list::merge"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "merge method"
ms.assetid: 23f97869-c9fa-41d6-bf86-46fb2acd88ea
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::merge
Combines two sorted sequences into a single sorted sequence in linear time. Removes the elements from the argument list, and inserts them into this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The two lists should be sorted by the same compare function object before the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The combined list will be sorted by that compare function object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The forward list to merge from.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The compare function object that is used to sort elements.|  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> removes the elements from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and inserts them into this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Both sequences must be ordered by the same predicate, described below. The combined sequence is also ordered by that compare function object.  
  
 For the iterators <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> designating elements at positions <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the first member function imposes the order <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. (The elements are sorted in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> order.) The second member function imposes the order <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> whenever <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 No pairs of elements in the original controlled sequence are reversed in the resulting controlled sequence. If a pair of elements in the resulting controlled sequence compares equal (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>), an element from the original controlled sequence appears before an element from the sequence controlled by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 An exception occurs only if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> throws an exception. In that case, the controlled sequence is left in unspecified order and the exception is rethrown.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)