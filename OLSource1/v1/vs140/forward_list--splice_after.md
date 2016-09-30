---
title: "forward_list::splice_after"
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
  - "forward_list.splice_after"
  - "forward_list::splice_after"
  - "splice_after"
  - "std.forward_list.splice_after"
  - "forward_list/std::forward_list::splice_after"
  - "std::forward_list::splice_after"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "splice_after method"
ms.assetid: 93c4f10b-473e-4c39-ba1f-3de79c210094
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::splice_after
Removes elements from a source forward_list and inserts them into a destination forward_list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The position in the destination forward_list after which to insert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The source forward_list that is to be inserted into the destination forward_list.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The element to be inserted from the source forward_list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The first element in the range to be inserted from source forward_list.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The first position beyond the range to be inserted from the source forward_list.  
  
## Remarks  
 The first pair of member functions inserts the sequence controlled by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> just after the element in the controlled sequence pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. It also removes all elements from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must not equal <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.)  
  
 The second pair of member functions removes the element just after <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the sequence controlled by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and inserts it just after the element in the controlled sequence pointed to by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. (If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, no change occurs.)  
  
 The third pair of member functions (ranged splice) inserts the subrange designated by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> from the sequence controlled by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> just after the element in the controlled sequence pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. It also removes the original subrange from the sequence controlled by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. (If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the range <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must not include the element pointed to by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.)  
  
 If the ranged splice inserts <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> elements, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, an object of class [iterator](../vs140/forward_list--iterator.md) is incremented <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> times.  
  
 No iterators, pointers, or references that designate spliced elements become invalid.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Beginning state of lists:c1 = (10) (11)c2 = (20) (21) (22)c3 = (30) (31)c4 = (40) (41) (42) (43)After splicing c1 into c2:c1 =c2 = (20) (21) (10) (11) (22)After splicing the first element of c3 into c2:c3 = (30)c2 = (20) (21) (31) (10) (11) (22)After splicing a range of c4 into c2:c4 = (40) (41)c2 = (20) (21) (42) (43) (31) (10) (11) (22)**   
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)