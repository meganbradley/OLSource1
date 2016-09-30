---
title: "deque::deque"
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
  - "deque::deque"
  - "deque.deque"
  - "std.deque.deque"
  - "deque"
  - "std::deque::deque"
  - "deque/std::deque::deque"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "deque class, constructor"
  - "deque method"
ms.assetid: 99c87b88-63f4-4ab4-aee4-f4436b7427f1
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::deque
Constructs a deque of a specific size, or with elements of a specific value, or with a specific allocator, or as a copy of all or part of some other deque.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The allocator class to use with this object.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The number of elements in the constructed deque.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The value of the elements in the constructed deque.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The deque of which the constructed deque is to be a copy.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The initializer_list to be copied.|  
  
## Remarks  
 All constructors store an allocator object (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) and initialize the deque.  
  
 The first two constructors specify an empty initial deque; the second one also specifies the allocator type (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) to be used.  
  
 The third constructor specifies a repetition of a specified number (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) of elements of the default value for class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The fourth and fifth constructors specify a repetition of (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) elements of value <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The sixth constructor specifies a copy of the deque <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The seventh and eighth constructors copy the range <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> of a deque.  
  
 The seventh constructor moves the deque <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The eighth constructor copies the contents of an initializer_list.  
  
 None of the constructors perform any interim reallocations.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)