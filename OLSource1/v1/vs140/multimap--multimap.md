---
title: "multimap::multimap"
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
  - "multimap"
  - "multimap::multimap"
  - "std.multimap.multimap"
  - "std::multimap::multimap"
  - "multimap.multimap"
  - "map/std::multimap::multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "multimap method"
  - "multimap class, constructor"
ms.assetid: 522a21b7-1471-4f9e-9783-0656331b020c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::multimap
Constructs a multimap that is empty or that is a copy of all or part of some other multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The storage allocator class to be used for this multimap object, which defaults to Allocator.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The comparison function of type **constTraits** used to order the elements in the map, which defaults to **Traits**.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The map of which the constructed set is to be a copy.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
## Remarks  
 All constructors store a type of allocator object that manages memory storage for the multimap and that can later be returned by calling [get_allocator](../vs140/multimap--get_allocator.md). The allocator parameter is often omitted in the class declarations and preprocessing macros used to substitute alternative allocators.  
  
 All constructors initialize their multimap.  
  
 All constructors store a function object of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that is used to establish an order among the keys of the multimap and that can later be returned by calling [key_comp](../vs140/multimap--key_comp.md).  
  
 The first three constructors specify an empty initial multimap, the second specifying the type of comparison function (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) to be used in establishing the order of the elements and the third explicitly specifying the allocator type (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) to be used. The key word <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> suppresses certain kinds of automatic type conversion.  
  
 The fourth constructor specifies a copy of the multimap <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The fifth constructor specifies a copy of the multimap by moving <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The sixth, seventh, and eighth constructors copy the members of an initializer_list.  
  
 The next three constructors copy the range <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> of a map with increasing explicitness in specifying the type of comparison function of class **Traits** and allocator.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **m1 =1 10, 2 20, 3 30, 4 40,m2 =1 10, 2 20,m3 =3 30,m4 =1 10, 2 20, 3 30, 4 40,m5 =1 10, 2 20,m6 =1 10,m8: = 1 1, 2 2, 3 3, 4 4,m9: = 5 5, 6 6, 7 7, 8 8,m10: = 9 9, 10 10, 11 11, 12 12,**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)