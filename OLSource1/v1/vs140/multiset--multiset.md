---
title: "multiset::multiset"
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
  - "std.multiset.multiset"
  - "multiset.multiset"
  - "std::multiset::multiset"
  - "multiset"
  - "set/std::multiset::multiset"
  - "multiset::multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multiset method"
  - "multiset class, constructor"
ms.assetid: 9e73b658-6f3d-408d-b9ab-a0f62153f021
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::multiset
Constructs a multiset that is empty or that is a copy of all or part of some other multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The storage allocator class to be used for this multiset object, which defaults to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The comparison function of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> used to order the elements in the multiset, which defaults to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The multiset of which the constructed multiset is to be a copy.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the multiset and that can later be returned by calling [get_allocator](../vs140/multiset--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their multiset.  
  
 All constructors store a function object of type Compare that is used to establish an order among the keys of the multiset and that can later be returned by calling [key_comp](../vs140/multiset--key_comp.md).  
  
 The first three constructors specify an empty initial multiset, the second specifying the type of comparison function (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) to be used. The keyword <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the multiset <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a copy of the multiset by moving <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The sixth, seventh, and eighth constructors specify an initializer_list from which to copy the elements.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> of a multiset with increasing explicitness in specifying the type of comparison function and allocator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)