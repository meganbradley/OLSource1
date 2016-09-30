---
title: "list::splice"
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
  - "std.list.splice"
  - "list/std::list::splice"
  - "list::splice"
  - "list.splice"
  - "splice"
  - "std::list::splice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splice method"
ms.assetid: 40420837-597b-434f-b865-bc36dbe7d59f
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::splice
Removes elements from a source list and inserts them into a destination list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position in the destination list before which to insert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The source list that is to be inserted into the destination list.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The element to be inserted from the source list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The first element in the range to be inserted from the source list.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The first position beyond the last element in the range to be inserted from the source list.  
  
## Remarks  
 The first pair of member functions inserts all elements in the source list into the destination list before the position referred to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and removes all elements from the source list. (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must not equal <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.)  
  
 The second pair of member functions inserts the element referred to by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> before the position in the destination list referred to by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and removes <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> from the source list. (If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, no change occurs.)  
  
 The third pair of member functions inserts the range designated by [<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) before the element in the destination list referred to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and removes that range of elements from the source list. (If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the range <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> must not include the element pointed to by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.)  
  
 If the ranged splice inserts <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> elements, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, an object of class [iterator](../vs140/forward_list--iterator.md) is incremented <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> times.  
  
 In all cases iterators, pointers, or references that refer to spliced elements remain valid and are transferred to the destination container.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Beginning state of lists:c1 = 2 elements: (10) (11)c2 = 3 elements: (20) (21) (22)c3 = 2 elements: (30) (31)c4 = 4 elements: (40) (41) (42) (43)After splicing c1 into c2:c1 = 0 elements:c2 = 5 elements: (20) (10) (11) (21) (22)After splicing the first element of c3 into c2:c3 = 1 elements: (31)c2 = 6 elements: (20) (10) (11) (30) (21) (22)After splicing a range of c4 into c2:c4 = 2 elements: (40) (43)c2 = 8 elements: (20) (10) (11) (30) (41) (42) (21) (22)**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)