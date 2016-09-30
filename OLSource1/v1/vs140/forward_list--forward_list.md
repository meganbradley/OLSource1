---
title: "forward_list::forward_list"
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
  - "std.forward_list.forward_list"
  - "forward_list/std::forward_list::forward_list"
  - "forward_list::forward_list"
  - "forward_list"
  - "forward_list.forward_list"
  - "std::forward_list::forward_list"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "forward_list method"
  - "forward_list class, constructor"
ms.assetid: bd90a932-35a1-4338-9ad2-a39708933e16
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# forward_list::forward_list
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The allocator class to use with this object.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The number of elements in the list constructed.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The value of the elements in the list constructed.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The list of which the constructed list is to be a copy.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The initializer_list to copy.|  
  
## Remarks  
 All constructors store an [allocator](../vs140/allocator-class.md) and initialize the controlled sequence. The allocator object is the argument <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, if present. For the copy constructor, it is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Otherwise, it is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The first two constructors specify an empty initial controlled sequence.  
  
 The third constructor specifies a repetition of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The fourth and fifth constructors specify a repetition of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is an integer type, the next two constructors specify a repetition of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> elements of value <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. Otherwise, the next two constructors specify the sequence <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 The ninth and tenth constructors are the same as the sixth, but with an [rvalue](../vs140/rvalue-reference-declarator----.md) reference.  
  
 The last constructor specifies the initial controlled sequence with an object of class <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<forward_list>  
  
 **Namespace:** std  
  
## See Also  
 [forward_list Class](../vs140/forward_list-class.md)